
namespace IdeaPit
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>s
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
            this.LoginWindow = new System.Windows.Forms.Panel();
            this.RegButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.IdeaPitLogo = new System.Windows.Forms.Label();
            this.EnterButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.LoginWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginWindow
            // 
            this.LoginWindow.BackColor = System.Drawing.Color.Thistle;
            this.LoginWindow.Controls.Add(this.RegButton);
            this.LoginWindow.Controls.Add(this.CloseButton);
            this.LoginWindow.Controls.Add(this.IdeaPitLogo);
            this.LoginWindow.Controls.Add(this.EnterButton);
            this.LoginWindow.Controls.Add(this.label4);
            this.LoginWindow.Controls.Add(this.label5);
            this.LoginWindow.Controls.Add(this.label3);
            this.LoginWindow.Controls.Add(this.PasswordField);
            this.LoginWindow.Controls.Add(this.LoginField);
            this.LoginWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginWindow.Location = new System.Drawing.Point(0, 0);
            this.LoginWindow.Name = "LoginWindow";
            this.LoginWindow.Size = new System.Drawing.Size(452, 230);
            this.LoginWindow.TabIndex = 0;
            this.LoginWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseDown);
            this.LoginWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseMove);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.MediumPurple;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RegButton.FlatAppearance.BorderSize = 0;
            this.RegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.RegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RegButton.Location = new System.Drawing.Point(228, 180);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(211, 38);
            this.RegButton.TabIndex = 4;
            this.RegButton.Text = "Регистрация";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.BlueViolet;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(420, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 27);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // IdeaPitLogo
            // 
            this.IdeaPitLogo.BackColor = System.Drawing.Color.MediumPurple;
            this.IdeaPitLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdeaPitLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdeaPitLogo.Font = new System.Drawing.Font("Regular Brush", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaPitLogo.ForeColor = System.Drawing.Color.Gold;
            this.IdeaPitLogo.Location = new System.Drawing.Point(0, 0);
            this.IdeaPitLogo.Name = "IdeaPitLogo";
            this.IdeaPitLogo.Size = new System.Drawing.Size(452, 50);
            this.IdeaPitLogo.TabIndex = 0;
            this.IdeaPitLogo.Text = "Idea Pit";
            this.IdeaPitLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IdeaPitLogo.Click += new System.EventHandler(this.IdeaPitLogo_Click);
            this.IdeaPitLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IdeaPitLogo_MouseDown);
            this.IdeaPitLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IdeaPitLogo_MouseMove);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.Color.MediumPurple;
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.FlatAppearance.BorderSize = 0;
            this.EnterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.EnterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Violet;
            this.EnterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterButton.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EnterButton.Location = new System.Drawing.Point(9, 180);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(203, 38);
            this.EnterButton.TabIndex = 3;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(143, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 27);
            this.label4.TabIndex = 2;
            this.label4.Text = "Авторизация";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "Пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(3, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Bebas Neue Pro SemiExp", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(95, 123);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(345, 38);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Bebas Neue Pro SemiExp", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginField.Location = new System.Drawing.Point(95, 79);
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(345, 38);
            this.LoginField.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(452, 230);
            this.Controls.Add(this.LoginWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.LoginWindow.ResumeLayout(false);
            this.LoginWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel LoginWindow;
        private System.Windows.Forms.Label IdeaPitLogo;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button RegButton;
        private System.ServiceProcess.ServiceController serviceController1;
    }
}