namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            idTitle = new Label();
            idLogin = new Label();
            txtLogin = new TextBox();
            btnLogin = new Button();
            btnGuest = new Button();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // idTitle
            // 
            idTitle.AutoSize = true;
            idTitle.Location = new Point(338, 177);
            idTitle.Name = "idTitle";
            idTitle.Size = new Size(89, 15);
            idTitle.TabIndex = 0;
            idTitle.Text = "Вход в систему";
            // 
            // idLogin
            // 
            idLogin.AutoSize = true;
            idLogin.Location = new Point(200, 230);
            idLogin.Name = "idLogin";
            idLogin.Size = new Size(41, 15);
            idLogin.TabIndex = 1;
            idLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.Location = new Point(275, 227);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(249, 23);
            txtLogin.TabIndex = 2;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(352, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Войти";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(433, 289);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(75, 23);
            btnGuest.TabIndex = 4;
            btnGuest.Text = "Смотреть каталог без входа";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // picLogo
            // 
            picLogo.Location = new Point(338, 101);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(90, 65);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 5;
            picLogo.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picLogo);
            Controls.Add(btnGuest);
            Controls.Add(btnLogin);
            Controls.Add(txtLogin);
            Controls.Add(idLogin);
            Controls.Add(idTitle);
            Name = "Form1";
            Text = "Чудо Обувь - вход в систему";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idTitle;
        private Label idLogin;
        private TextBox txtLogin;
        private Button btnLogin;
        private Button btnGuest;
        private PictureBox picLogo;
    }
}
