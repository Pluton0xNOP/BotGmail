using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using MailKit.Net.Imap;
using MailKit.Search;
using MailKit;
using MimeKit;
using System.Net;
using System.Net.Mail;
using System.Net.Http;

namespace BotGmail
{
    public partial class Main : MaterialForm
    {
        private static readonly string apiUrl = "https://api.openai.com/v1/chat/completions";
        private CancellationTokenSource cancellationTokenSource;

        public Main()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);
            LogMessage("Aplicación iniciada - " + DateTime.Now);
        }

        private void LogMessage(string message)
        {
            if (logs.InvokeRequired)
            {
                logs.Invoke(new Action(() => logs.Text = logs.Text + message + "\r\n"));
            }
            else
            {
                logs.Text += message + "\r\n";
            }
        }

        private (string gmailUser, string gmailPassword, string openaiKey, string promptText) ObtenerDatosUI()
        {
            string gmailUser = "";
            string gmailPassword = "";
            string openaiKey = "";
            string promptText = "";
            if (InvokeRequired)
            {
                Invoke(new Action(() =>
                {
                    gmailUser = gmail_user.Text;
                    gmailPassword = gmail_password.Text;
                    openaiKey = openaikey.Text.Trim();
                    promptText = prompt.Text;
                }));
            }
            else
            {
                gmailUser = gmail_user.Text;
                gmailPassword = gmail_password.Text;
                openaiKey = openaikey.Text.Trim();
                promptText = prompt.Text;
            }
            return (gmailUser, gmailPassword, openaiKey, promptText);
        }

        private bool ValidarCampos(string gmailUser, string gmailPassword, string openaiKey)
        {
            if (string.IsNullOrWhiteSpace(gmailUser) || string.IsNullOrWhiteSpace(gmailPassword))
            {
                LogMessage("Error: Usuario o contraseña de Gmail vacíos.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(openaiKey))
            {
                LogMessage("Error: Clave de API de OpenAI vacía.");
                return false;
            }
            return true;
        }

        public void EnviarCorreo(string destinatario, string asunto, string mensaje, string gmailUser, string gmailPassword)
        {
            try
            {
                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential(gmailUser, gmailPassword),
                    EnableSsl = true
                };
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(gmailUser),
                    Subject = asunto,
                    Body = mensaje,
                    IsBodyHtml = false
                };
                mailMessage.To.Add(destinatario);
                smtpClient.Send(mailMessage);
                LogMessage("Correo enviado a: " + destinatario);
            }
            catch (Exception ex)
            {
                LogMessage("Error al enviar correo: " + ex.Message);
            }
        }

        public async Task<string> GetCompletionAsync(string cuerpoMensaje, string openaiKey, string promptText)
        {
            string promptCompleto = promptText + "\n" + cuerpoMensaje;
            var requestBody = new { model = "gpt-3.5-turbo", messages = new[] { new { role = "user", content = promptCompleto } }, max_tokens = 100 };
            var jsonBody = JsonConvert.SerializeObject(requestBody);
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {openaiKey}");
                var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    string responseString = await response.Content.ReadAsStringAsync();
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseString);
                    return jsonResponse.choices[0].message.content.ToString();
                }
                else
                {
                    LogMessage("Error en la API de OpenAI: " + response.StatusCode);
                    return "";
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private async Task LeerCorreosYResponder(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var (gmailUser, gmailPassword, openaiKey, promptText) = ObtenerDatosUI();
                    if (!ValidarCampos(gmailUser, gmailPassword, openaiKey)) return;
                    using (var client = new ImapClient())
                    {
                        client.Connect("imap.gmail.com", 993, true);
                        client.Authenticate(gmailUser, gmailPassword);
                        var inbox = client.Inbox;
                        inbox.Open(FolderAccess.ReadWrite);
                        var uids = inbox.Search(SearchQuery.NotSeen.And(SearchQuery.SentSince(DateTime.Today)));
                        if (uids.Any())
                        {
                            LogMessage("Correos no leídos encontrados: " + uids.Count);
                            foreach (var uid in uids)
                            {
                                if (cancellationToken.IsCancellationRequested) break;
                                var message = inbox.GetMessage(uid);
                                var remitente = message.From.Mailboxes.FirstOrDefault()?.Address;
                                var asunto = message.Subject ?? "Sin asunto";
                                var cuerpoMensaje = message.TextBody ?? "";
                                LogMessage("Procesando correo de: " + remitente + ", Asunto: " + asunto);
                                var respuestaIA = await GetCompletionAsync(cuerpoMensaje, openaiKey, promptText);
                                if (!string.IsNullOrWhiteSpace(respuestaIA))
                                {
                                    EnviarCorreo(remitente, "Re: " + asunto, respuestaIA, gmailUser, gmailPassword);
                                    inbox.AddFlags(uid, MessageFlags.Seen, true);
                                }
                            }
                        }
                        client.Disconnect(true);
                    }
                }
                catch (Exception ex)
                {
                    LogMessage("Error al leer o responder correos: " + ex.Message);
                }
                await Task.Delay(2000);
            }
            LogMessage("Proceso detenido.");
        }

        private void start_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource != null)
            {
                LogMessage("El proceso ya está en ejecución.");
                return;
            }
            cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => LeerCorreosYResponder(cancellationTokenSource.Token));
            LogMessage("Inicio de la verificación de correos.");
        }

        private void stop_Click(object sender, EventArgs e)
        {
            if (cancellationTokenSource == null)
            {
                LogMessage("No hay procesos en ejecución.");
                return;
            }
            cancellationTokenSource.Cancel();
            cancellationTokenSource = null;
            LogMessage("Se ha detenido la verificación de correos.");
        }
    }
}
