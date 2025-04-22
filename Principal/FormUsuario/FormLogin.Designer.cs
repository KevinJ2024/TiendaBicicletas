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
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            btnCancelar_Click = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tbContraseñaLogin
            // 
            tbContraseñaLogin.Location = new Point(116, 156);
            tbContraseñaLogin.Name = "tbContraseñaLogin";
            tbContraseñaLogin.PlaceholderText = "contraseña";
            tbContraseñaLogin.Size = new Size(195, 23);
            tbContraseñaLogin.TabIndex = 15;
            // 
            // tbEmailLogin
            // 
            tbEmailLogin.Location = new Point(116, 90);
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
            btnLogin.Location = new Point(78, 240);
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
            lbTitleLogin.BackColor = SystemColors.ControlLightLight;
            lbTitleLogin.Font = new Font("Old English Text MT", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitleLogin.Location = new Point(39, 119);
            lbTitleLogin.Name = "lbTitleLogin";
            lbTitleLogin.Size = new Size(213, 77);
            lbTitleLogin.TabIndex = 8;
            lbTitleLogin.Text = "sign in";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1889, 966);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(lbTitleLogin);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(-26, -112);
            panel2.Name = "panel2";
            panel2.Size = new Size(1951, 1951);
            panel2.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLightLight;
            panel4.Controls.Add(btnCancelar_Click);
            panel4.Controls.Add(tbEmailLogin);
            panel4.Controls.Add(btnLogin);
            panel4.Controls.Add(tbContraseñaLogin);
            panel4.Location = new Point(754, 402);
            panel4.Name = "panel4";
            panel4.Size = new Size(428, 304);
            panel4.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 100);
            panel3.TabIndex = 16;
            // 
            // btnCancelar_Click
            // 
            btnCancelar_Click.Location = new Point(218, 240);
            btnCancelar_Click.Name = "btnCancelar_Click";
            btnCancelar_Click.Size = new Size(112, 48);
            btnCancelar_Click.TabIndex = 16;
            btnCancelar_Click.Text = "Cancelar";
            btnCancelar_Click.UseVisualStyleBackColor = true;
            btnCancelar_Click.Click += this.btnCancelar_Click_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1879, 1061);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Name = "FormLogin";
            Text = "FormLogin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbContraseñaLogin;
        private TextBox tbEmailLogin;
        private Button btnCancelar;
        private Button btnLogin;
        private Label lbTitleLogin;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Button btnCancelar_Click;
    }
}