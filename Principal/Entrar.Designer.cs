namespace Principal
{
    partial class Entrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogin = new Button();
            buttonRegister = new Button();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(297, 119);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(163, 59);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += button1_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(297, 201);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(163, 57);
            buttonRegister.TabIndex = 1;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // Entrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRegister);
            Controls.Add(buttonLogin);
            Name = "Entrar";
            Text = "Entrar";
            Load += Entrar_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogin;
        private Button buttonRegister;
    }
}