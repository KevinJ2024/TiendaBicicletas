namespace Principal
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbContraseñaLogin = new TextBox();
            tbEmailLogin = new TextBox();
            btnCancelar = new Button();
            btnLogin = new Button();
            lbTitleLogin = new Label();
            SuspendLayout();
            // 
            // tbContraseñaLogin
            // 
            tbContraseñaLogin.Location = new Point(304, 199);
            tbContraseñaLogin.Name = "tbContraseñaLogin";
            tbContraseñaLogin.PlaceholderText = "contraseña";
            tbContraseñaLogin.Size = new Size(195, 23);
            tbContraseñaLogin.TabIndex = 15;
            // 
            // tbEmailLogin
            // 
            tbEmailLogin.Location = new Point(304, 127);
            tbEmailLogin.Name = "tbEmailLogin";
            tbEmailLogin.PlaceholderText = "Email";
            tbEmailLogin.Size = new Size(195, 23);
            tbEmailLogin.TabIndex = 11;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(410, 370);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 48);
            btnCancelar.TabIndex = 10;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(287, 370);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 48);
            btnLogin.TabIndex = 9;
            btnLogin.Text = "Ok";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lbTitleLogin
            // 
            lbTitleLogin.AutoSize = true;
            lbTitleLogin.Font = new Font("Segoe UI", 20F);
            lbTitleLogin.Location = new Point(304, 32);
            lbTitleLogin.Name = "lbTitleLogin";
            lbTitleLogin.Size = new Size(95, 37);
            lbTitleLogin.TabIndex = 8;
            lbTitleLogin.Text = "sign in";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbContraseñaLogin);
            Controls.Add(tbEmailLogin);
            Controls.Add(btnCancelar);
            Controls.Add(btnLogin);
            Controls.Add(lbTitleLogin);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbContraseñaLogin;
        private TextBox tbEmailLogin;
        private Button btnCancelar;
        private Button btnLogin;
        private Label lbTitleLogin;
    }
}