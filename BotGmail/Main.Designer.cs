namespace BotGmail
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gmail_user = new MaterialSkin.Controls.MaterialTextBox();
            this.openaikey = new MaterialSkin.Controls.MaterialTextBox();
            this.gmail_password = new MaterialSkin.Controls.MaterialTextBox();
            this.prompt = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.start = new MaterialSkin.Controls.MaterialButton();
            this.stop = new MaterialSkin.Controls.MaterialButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logs = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gmail_user
            // 
            this.gmail_user.AnimateReadOnly = false;
            this.gmail_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gmail_user.Depth = 0;
            this.gmail_user.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gmail_user.LeadingIcon = null;
            this.gmail_user.Location = new System.Drawing.Point(231, 34);
            this.gmail_user.MaxLength = 50;
            this.gmail_user.MouseState = MaterialSkin.MouseState.OUT;
            this.gmail_user.Multiline = false;
            this.gmail_user.Name = "gmail_user";
            this.gmail_user.Size = new System.Drawing.Size(317, 36);
            this.gmail_user.TabIndex = 1;
            this.gmail_user.Text = "";
            this.gmail_user.TrailingIcon = null;
            this.gmail_user.UseTallSize = false;
            // 
            // openaikey
            // 
            this.openaikey.AnimateReadOnly = false;
            this.openaikey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.openaikey.Depth = 0;
            this.openaikey.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.openaikey.LeadingIcon = null;
            this.openaikey.Location = new System.Drawing.Point(231, 97);
            this.openaikey.MaxLength = 9999;
            this.openaikey.MouseState = MaterialSkin.MouseState.OUT;
            this.openaikey.Multiline = false;
            this.openaikey.Name = "openaikey";
            this.openaikey.Size = new System.Drawing.Size(317, 36);
            this.openaikey.TabIndex = 2;
            this.openaikey.Text = "";
            this.openaikey.TrailingIcon = null;
            this.openaikey.UseTallSize = false;
            // 
            // gmail_password
            // 
            this.gmail_password.AnimateReadOnly = false;
            this.gmail_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gmail_password.Depth = 0;
            this.gmail_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gmail_password.LeadingIcon = null;
            this.gmail_password.Location = new System.Drawing.Point(231, 159);
            this.gmail_password.MaxLength = 9999;
            this.gmail_password.MouseState = MaterialSkin.MouseState.OUT;
            this.gmail_password.Multiline = false;
            this.gmail_password.Name = "gmail_password";
            this.gmail_password.Size = new System.Drawing.Size(317, 36);
            this.gmail_password.TabIndex = 3;
            this.gmail_password.Text = "";
            this.gmail_password.TrailingIcon = null;
            this.gmail_password.UseTallSize = false;
            // 
            // prompt
            // 
            this.prompt.AnimateReadOnly = false;
            this.prompt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.prompt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.prompt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prompt.Depth = 0;
            this.prompt.HideSelection = true;
            this.prompt.Location = new System.Drawing.Point(15, 34);
            this.prompt.MaxLength = 32767;
            this.prompt.MouseState = MaterialSkin.MouseState.OUT;
            this.prompt.Name = "prompt";
            this.prompt.PasswordChar = '\0';
            this.prompt.ReadOnly = false;
            this.prompt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prompt.SelectedText = "";
            this.prompt.SelectionLength = 0;
            this.prompt.SelectionStart = 0;
            this.prompt.ShortcutsEnabled = true;
            this.prompt.Size = new System.Drawing.Size(528, 115);
            this.prompt.TabIndex = 4;
            this.prompt.TabStop = false;
            this.prompt.Text = "Por favor, responde de manera amigable, con mucho ánimo y utilizando emojis en la" +
    " respuesta";
            this.prompt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.prompt.UseSystemPasswordChar = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.openaikey);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.gmail_password);
            this.groupBox1.Controls.Add(this.materialLabel1);
            this.groupBox1.Controls.Add(this.gmail_user);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 210);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(17, 99);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(107, 20);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Openai API key";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(17, 161);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(196, 20);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Contraseña de aplicaciones";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 99);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(1, 0);
            this.materialLabel2.TabIndex = 2;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 34);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(128, 20);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Correo electronico";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.prompt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(24, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(563, 173);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "prompt";
            // 
            // start
            // 
            this.start.AutoSize = false;
            this.start.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.start.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.start.Depth = 0;
            this.start.HighEmphasis = true;
            this.start.Icon = null;
            this.start.Location = new System.Drawing.Point(24, 491);
            this.start.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.start.MouseState = MaterialSkin.MouseState.HOVER;
            this.start.Name = "start";
            this.start.NoAccentTextColor = System.Drawing.Color.Empty;
            this.start.Size = new System.Drawing.Size(226, 36);
            this.start.TabIndex = 7;
            this.start.Text = "Iniciar";
            this.start.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.start.UseAccentColor = false;
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // stop
            // 
            this.stop.AutoSize = false;
            this.stop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.stop.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.stop.Depth = 0;
            this.stop.HighEmphasis = true;
            this.stop.Icon = null;
            this.stop.Location = new System.Drawing.Point(361, 491);
            this.stop.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stop.MouseState = MaterialSkin.MouseState.HOVER;
            this.stop.Name = "stop";
            this.stop.NoAccentTextColor = System.Drawing.Color.Empty;
            this.stop.Size = new System.Drawing.Size(226, 36);
            this.stop.TabIndex = 8;
            this.stop.Text = "Parar";
            this.stop.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.stop.UseAccentColor = false;
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logs);
            this.groupBox3.Controls.Add(this.materialLabel7);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(609, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(485, 404);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Logs";
            // 
            // logs
            // 
            this.logs.AnimateReadOnly = false;
            this.logs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.logs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.logs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.logs.Depth = 0;
            this.logs.HideSelection = true;
            this.logs.Location = new System.Drawing.Point(20, 34);
            this.logs.MaxLength = 32767;
            this.logs.MouseState = MaterialSkin.MouseState.OUT;
            this.logs.Name = "logs";
            this.logs.PasswordChar = '\0';
            this.logs.ReadOnly = false;
            this.logs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.logs.SelectedText = "";
            this.logs.SelectionLength = 0;
            this.logs.SelectionStart = 0;
            this.logs.ShortcutsEnabled = true;
            this.logs.Size = new System.Drawing.Size(448, 346);
            this.logs.TabIndex = 5;
            this.logs.TabStop = false;
            this.logs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logs.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(17, 99);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(1, 0);
            this.materialLabel7.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "BotGmail - Isoft";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox gmail_user;
        private MaterialSkin.Controls.MaterialTextBox openaikey;
        private MaterialSkin.Controls.MaterialTextBox gmail_password;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 prompt;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton start;
        private MaterialSkin.Controls.MaterialButton stop;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 logs;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
    }
}

