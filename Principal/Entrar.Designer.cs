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
            pane = new Panel();
            asasa = new Label();
            panel2 = new Panel();
            label1 = new Label();
            pane.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(116, 42);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(163, 44);
            buttonLogin.TabIndex = 0;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += button1_Click;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(116, 144);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(163, 41);
            buttonRegister.TabIndex = 1;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // pane
            // 
            pane.BackColor = SystemColors.AppWorkspace;
            pane.Controls.Add(asasa);
            pane.Controls.Add(panel2);
            pane.Controls.Add(label1);
            pane.Location = new Point(0, -2);
            pane.Name = "pane";
            pane.Size = new Size(2362, 1047);
            pane.TabIndex = 2;
            // 
            // asasa
            // 
            asasa.AutoSize = true;
            asasa.BackColor = SystemColors.ButtonHighlight;
            asasa.Font = new Font("Old English Text MT", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            asasa.Location = new Point(12, 11);
            asasa.Name = "asasa";
            asasa.Size = new Size(560, 89);
            asasa.TabIndex = 2;
            asasa.Text = "Tienda de Bicicletas";
            asasa.UseCompatibleTextRendering = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Controls.Add(buttonLogin);
            panel2.Controls.Add(buttonRegister);
            panel2.Location = new Point(696, 323);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 235);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 4;
            // 
            // Entrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1880, 959);
            Controls.Add(pane);
            Name = "Entrar";
            Text = "Entrar";
            Load += Entrar_Load;
            pane.ResumeLayout(false);
            pane.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button buttonLogin;
        private Button buttonRegister;
        private Panel pane;
        private Panel panel2;
        private Label label1;
        private Label asasa;
    }
}