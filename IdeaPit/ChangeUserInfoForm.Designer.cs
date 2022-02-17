
namespace IdeaPit
{
    partial class ChangeUserInfoForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.IdeaPitLogo = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.bDateField = new System.Windows.Forms.DateTimePicker();
            this.LoginWindow = new System.Windows.Forms.Panel();
            this.WindowName = new System.Windows.Forms.Label();
            this.bioField = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RepPassField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.PhoneField = new System.Windows.Forms.TextBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.LoginWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.DarkCyan;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginButton.Location = new System.Drawing.Point(462, 302);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(203, 50);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "Назад";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // IdeaPitLogo
            // 
            this.IdeaPitLogo.BackColor = System.Drawing.Color.DarkCyan;
            this.IdeaPitLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdeaPitLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdeaPitLogo.Font = new System.Drawing.Font("Regular Brush", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaPitLogo.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.IdeaPitLogo.Location = new System.Drawing.Point(0, 0);
            this.IdeaPitLogo.Name = "IdeaPitLogo";
            this.IdeaPitLogo.Size = new System.Drawing.Size(676, 47);
            this.IdeaPitLogo.TabIndex = 0;
            this.IdeaPitLogo.Text = "Idea Pit";
            this.IdeaPitLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IdeaPitLogo.Click += new System.EventHandler(this.IdeaPitLogo_Click);
            this.IdeaPitLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.IdeaPitLogo_MouseDown);
            this.IdeaPitLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.IdeaPitLogo_MouseMove);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.DarkCyan;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(644, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 27);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // bDateField
            // 
            this.bDateField.Location = new System.Drawing.Point(190, 274);
            this.bDateField.Name = "bDateField";
            this.bDateField.Size = new System.Drawing.Size(158, 22);
            this.bDateField.TabIndex = 4;
            // 
            // LoginWindow
            // 
            this.LoginWindow.BackColor = System.Drawing.Color.MediumTurquoise;
            this.LoginWindow.Controls.Add(this.WindowName);
            this.LoginWindow.Controls.Add(this.bioField);
            this.LoginWindow.Controls.Add(this.bDateField);
            this.LoginWindow.Controls.Add(this.CloseButton);
            this.LoginWindow.Controls.Add(this.RegButton);
            this.LoginWindow.Controls.Add(this.IdeaPitLogo);
            this.LoginWindow.Controls.Add(this.LoginButton);
            this.LoginWindow.Controls.Add(this.label6);
            this.LoginWindow.Controls.Add(this.label5);
            this.LoginWindow.Controls.Add(this.label7);
            this.LoginWindow.Controls.Add(this.label4);
            this.LoginWindow.Controls.Add(this.label3);
            this.LoginWindow.Controls.Add(this.RepPassField);
            this.LoginWindow.Controls.Add(this.PasswordField);
            this.LoginWindow.Controls.Add(this.PhoneField);
            this.LoginWindow.Controls.Add(this.LoginField);
            this.LoginWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginWindow.Location = new System.Drawing.Point(0, 0);
            this.LoginWindow.Name = "LoginWindow";
            this.LoginWindow.Size = new System.Drawing.Size(676, 362);
            this.LoginWindow.TabIndex = 0;
            this.LoginWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseDown);
            this.LoginWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseMove);
            // 
            // WindowName
            // 
            this.WindowName.BackColor = System.Drawing.Color.Transparent;
            this.WindowName.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowName.Font = new System.Drawing.Font("Metropol 95", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WindowName.Location = new System.Drawing.Point(50, 47);
            this.WindowName.Name = "WindowName";
            this.WindowName.Size = new System.Drawing.Size(583, 38);
            this.WindowName.TabIndex = 2;
            this.WindowName.Text = "Редактирование профиля";
            this.WindowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bioField
            // 
            this.bioField.AccessibleDescription = "";
            this.bioField.Location = new System.Drawing.Point(353, 97);
            this.bioField.Name = "bioField";
            this.bioField.Size = new System.Drawing.Size(312, 199);
            this.bioField.TabIndex = 5;
            this.bioField.Text = "";
            this.bioField.Enter += new System.EventHandler(this.bioField_Enter);
            this.bioField.Leave += new System.EventHandler(this.bioField_Leave);
            // 
            // label6
            // 
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(4, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 41);
            this.label6.TabIndex = 2;
            this.label6.Text = "Повтор пароля";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(3, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "Новый пароль";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(6, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 27);
            this.label7.TabIndex = 2;
            this.label7.Text = "Дата рождения";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(5, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 30);
            this.label4.TabIndex = 2;
            this.label4.Text = "Телефон";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Metropol 95", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Логин";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RepPassField
            // 
            this.RepPassField.Font = new System.Drawing.Font("Bebas Neue Pro SemiExp", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepPassField.Location = new System.Drawing.Point(105, 186);
            this.RepPassField.Name = "RepPassField";
            this.RepPassField.PasswordChar = '*';
            this.RepPassField.Size = new System.Drawing.Size(242, 38);
            this.RepPassField.TabIndex = 1;
            this.RepPassField.UseSystemPasswordChar = true;
            // 
            // PasswordField
            // 
            this.PasswordField.Font = new System.Drawing.Font("Bebas Neue Pro SemiExp", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordField.Location = new System.Drawing.Point(105, 141);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(242, 38);
            this.PasswordField.TabIndex = 1;
            this.PasswordField.UseSystemPasswordChar = true;
            // 
            // PhoneField
            // 
            this.PhoneField.Font = new System.Drawing.Font("Bebas Neue Pro SemiExp", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneField.Location = new System.Drawing.Point(105, 230);
            this.PhoneField.Name = "PhoneField";
            this.PhoneField.Size = new System.Drawing.Size(242, 38);
            this.PhoneField.TabIndex = 1;
            // 
            // LoginField
            // 
            this.LoginField.Font = new System.Drawing.Font("Bebas Neue Pro SemiExp", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginField.Location = new System.Drawing.Point(105, 97);
            this.LoginField.Name = "LoginField";
            this.LoginField.ReadOnly = true;
            this.LoginField.Size = new System.Drawing.Size(242, 38);
            this.LoginField.TabIndex = 1;
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.DarkCyan;
            this.RegButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegButton.FlatAppearance.BorderSize = 0;
            this.RegButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.RegButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.RegButton.Location = new System.Drawing.Point(12, 302);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(203, 50);
            this.RegButton.TabIndex = 3;
            this.RegButton.Text = "Сохранить";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // ChangeUserInfoForm
            // 
            this.ClientSize = new System.Drawing.Size(676, 362);
            this.Controls.Add(this.LoginWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeUserInfoForm";
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
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label IdeaPitLogo;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DateTimePicker bDateField;
        private System.Windows.Forms.Panel LoginWindow;
        private System.Windows.Forms.RichTextBox bioField;
        private System.Windows.Forms.Label WindowName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RepPassField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.TextBox PhoneField;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.Button RegButton;
    }
}