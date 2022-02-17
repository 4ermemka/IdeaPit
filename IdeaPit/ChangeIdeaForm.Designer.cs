
namespace IdeaPit
{
    partial class ChangeIdeaForm
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
            this.DescriptionField = new System.Windows.Forms.RichTextBox();
            this.WindowName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NameField = new System.Windows.Forms.TextBox();
            this.LoginWindow = new System.Windows.Forms.Panel();
            this.CheckFreeBox = new System.Windows.Forms.CheckBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.IdeaPitLogo = new System.Windows.Forms.Label();
            this.SaveChangesBtn = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.Label();
            this.TypeField = new System.Windows.Forms.TextBox();
            this.LoginWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // DescriptionField
            // 
            this.DescriptionField.AccessibleDescription = "";
            this.DescriptionField.Location = new System.Drawing.Point(9, 124);
            this.DescriptionField.Name = "DescriptionField";
            this.DescriptionField.Size = new System.Drawing.Size(656, 230);
            this.DescriptionField.TabIndex = 5;
            this.DescriptionField.Text = "";
            // 
            // WindowName
            // 
            this.WindowName.BackColor = System.Drawing.Color.Transparent;
            this.WindowName.Cursor = System.Windows.Forms.Cursors.Default;
            this.WindowName.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WindowName.Location = new System.Drawing.Point(12, 50);
            this.WindowName.Name = "WindowName";
            this.WindowName.Size = new System.Drawing.Size(244, 27);
            this.WindowName.TabIndex = 2;
            this.WindowName.Text = "Редактирование поста";
            this.WindowName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameField
            // 
            this.NameField.Font = new System.Drawing.Font("Bebas Neue Pro SemiExp", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameField.Location = new System.Drawing.Point(114, 80);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(338, 38);
            this.NameField.TabIndex = 1;
            // 
            // LoginWindow
            // 
            this.LoginWindow.BackColor = System.Drawing.Color.PeachPuff;
            this.LoginWindow.Controls.Add(this.CheckFreeBox);
            this.LoginWindow.Controls.Add(this.DescriptionField);
            this.LoginWindow.Controls.Add(this.CloseButton);
            this.LoginWindow.Controls.Add(this.CancelBtn);
            this.LoginWindow.Controls.Add(this.IdeaPitLogo);
            this.LoginWindow.Controls.Add(this.SaveChangesBtn);
            this.LoginWindow.Controls.Add(this.WindowName);
            this.LoginWindow.Controls.Add(this.Type);
            this.LoginWindow.Controls.Add(this.label3);
            this.LoginWindow.Controls.Add(this.TypeField);
            this.LoginWindow.Controls.Add(this.NameField);
            this.LoginWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginWindow.Location = new System.Drawing.Point(0, 0);
            this.LoginWindow.Name = "LoginWindow";
            this.LoginWindow.Size = new System.Drawing.Size(674, 420);
            this.LoginWindow.TabIndex = 1;
            this.LoginWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseDown);
            this.LoginWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseMove);
            // 
            // CheckFreeBox
            // 
            this.CheckFreeBox.AutoSize = true;
            this.CheckFreeBox.BackColor = System.Drawing.Color.Transparent;
            this.CheckFreeBox.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckFreeBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CheckFreeBox.Location = new System.Drawing.Point(247, 374);
            this.CheckFreeBox.Name = "CheckFreeBox";
            this.CheckFreeBox.Size = new System.Drawing.Size(181, 25);
            this.CheckFreeBox.TabIndex = 6;
            this.CheckFreeBox.Text = "Бесплатная идея";
            this.CheckFreeBox.UseVisualStyleBackColor = false;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Peru;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CloseButton.Location = new System.Drawing.Point(642, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 27);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.Peru;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.CancelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CancelBtn.Location = new System.Drawing.Point(462, 360);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(203, 50);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Отмена";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // IdeaPitLogo
            // 
            this.IdeaPitLogo.BackColor = System.Drawing.Color.Peru;
            this.IdeaPitLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdeaPitLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdeaPitLogo.Font = new System.Drawing.Font("Regular Brush", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaPitLogo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.IdeaPitLogo.Location = new System.Drawing.Point(0, 0);
            this.IdeaPitLogo.Name = "IdeaPitLogo";
            this.IdeaPitLogo.Size = new System.Drawing.Size(674, 47);
            this.IdeaPitLogo.TabIndex = 0;
            this.IdeaPitLogo.Text = "Idea Pit";
            this.IdeaPitLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IdeaPitLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseDown);
            this.IdeaPitLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseMove);
            // 
            // SaveChangesBtn
            // 
            this.SaveChangesBtn.BackColor = System.Drawing.Color.Peru;
            this.SaveChangesBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveChangesBtn.FlatAppearance.BorderSize = 0;
            this.SaveChangesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.SaveChangesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.SaveChangesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveChangesBtn.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveChangesBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaveChangesBtn.Location = new System.Drawing.Point(9, 360);
            this.SaveChangesBtn.Name = "SaveChangesBtn";
            this.SaveChangesBtn.Size = new System.Drawing.Size(203, 50);
            this.SaveChangesBtn.TabIndex = 3;
            this.SaveChangesBtn.Text = "Сохранить";
            this.SaveChangesBtn.UseVisualStyleBackColor = false;
            this.SaveChangesBtn.Click += new System.EventHandler(this.SaveChangesBtn_Click);
            // 
            // Type
            // 
            this.Type.BackColor = System.Drawing.Color.Transparent;
            this.Type.Cursor = System.Windows.Forms.Cursors.Default;
            this.Type.Font = new System.Drawing.Font("Metropol 95", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Type.Location = new System.Drawing.Point(458, 77);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(42, 42);
            this.Type.TabIndex = 2;
            this.Type.Text = "Тип";
            this.Type.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TypeField
            // 
            this.TypeField.Font = new System.Drawing.Font("Bebas Neue Pro SemiExp", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeField.Location = new System.Drawing.Point(507, 80);
            this.TypeField.Name = "TypeField";
            this.TypeField.Size = new System.Drawing.Size(158, 38);
            this.TypeField.TabIndex = 1;
            // 
            // ChangeIdeaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 420);
            this.Controls.Add(this.LoginWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeIdeaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeIdea";
            this.LoginWindow.ResumeLayout(false);
            this.LoginWindow.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label WindowName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel LoginWindow;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Label IdeaPitLogo;
        private System.Windows.Forms.Button SaveChangesBtn;
        private System.Windows.Forms.Label Type;
        public System.Windows.Forms.RichTextBox DescriptionField;
        public System.Windows.Forms.TextBox NameField;
        public System.Windows.Forms.TextBox TypeField;
        public System.Windows.Forms.CheckBox CheckFreeBox;
    }
}