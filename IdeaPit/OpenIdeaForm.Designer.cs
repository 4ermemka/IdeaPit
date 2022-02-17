
namespace IdeaPit
{
    partial class OpenIdeaForm
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
            this.components = new System.ComponentModel.Container();
            this.serviceController2 = new System.ServiceProcess.ServiceController();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.IdeaPitLogo = new System.Windows.Forms.Label();
            this.PostNameLabel = new System.Windows.Forms.Label();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.LogoPartPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AuthorNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PostType = new System.Windows.Forms.Label();
            this.TypeTextLabel = new System.Windows.Forms.Label();
            this.PostName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainInfoPanel = new System.Windows.Forms.Panel();
            this.CommentPanel = new System.Windows.Forms.Panel();
            this.DescriptionPanel = new System.Windows.Forms.Panel();
            this.PostDescription = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewPostBtn = new System.Windows.Forms.Button();
            this.NewCommentText = new System.Windows.Forms.TextBox();
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.AdminIndicatorUser = new System.Windows.Forms.CheckBox();
            this.BackToTitle = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.PhoneDisp = new System.Windows.Forms.Label();
            this.PrUserName = new System.Windows.Forms.Label();
            this.ideaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UpperPanel.SuspendLayout();
            this.UpPanel.SuspendLayout();
            this.LogoPartPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.MainInfoPanel.SuspendLayout();
            this.DescriptionPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.LeftMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ideaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.Firebrick;
            this.UpperPanel.Controls.Add(this.CloseButton);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1368, 27);
            this.UpperPanel.TabIndex = 9;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Brown;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Broadway", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CloseButton.Location = new System.Drawing.Point(1338, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 27);
            this.CloseButton.TabIndex = 4;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // IdeaPitLogo
            // 
            this.IdeaPitLogo.BackColor = System.Drawing.Color.IndianRed;
            this.IdeaPitLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdeaPitLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdeaPitLogo.Font = new System.Drawing.Font("Regular Brush", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaPitLogo.ForeColor = System.Drawing.Color.MistyRose;
            this.IdeaPitLogo.Location = new System.Drawing.Point(0, 0);
            this.IdeaPitLogo.Name = "IdeaPitLogo";
            this.IdeaPitLogo.Size = new System.Drawing.Size(1368, 51);
            this.IdeaPitLogo.TabIndex = 8;
            this.IdeaPitLogo.Text = "Idea Pit";
            this.IdeaPitLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PostNameLabel
            // 
            this.PostNameLabel.AutoSize = true;
            this.PostNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.PostNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PostNameLabel.Font = new System.Drawing.Font("Metropol 95", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PostNameLabel.Location = new System.Drawing.Point(0, 0);
            this.PostNameLabel.Name = "PostNameLabel";
            this.PostNameLabel.Size = new System.Drawing.Size(64, 23);
            this.PostNameLabel.TabIndex = 2;
            this.PostNameLabel.Text = "Пост:";
            this.PostNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UpPanel
            // 
            this.UpPanel.BackColor = System.Drawing.Color.Crimson;
            this.UpPanel.Controls.Add(this.LogoPartPanel);
            this.UpPanel.Controls.Add(this.UpperPanel);
            this.UpPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpPanel.Location = new System.Drawing.Point(0, 0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(1368, 78);
            this.UpPanel.TabIndex = 8;
            // 
            // LogoPartPanel
            // 
            this.LogoPartPanel.Controls.Add(this.IdeaPitLogo);
            this.LogoPartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoPartPanel.Location = new System.Drawing.Point(0, 27);
            this.LogoPartPanel.Name = "LogoPartPanel";
            this.LogoPartPanel.Size = new System.Drawing.Size(1368, 51);
            this.LogoPartPanel.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SeaShell;
            this.panel4.Controls.Add(this.AuthorNameLabel);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.PostType);
            this.panel4.Controls.Add(this.TypeTextLabel);
            this.panel4.Controls.Add(this.PostName);
            this.panel4.Controls.Add(this.PostNameLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1152, 36);
            this.panel4.TabIndex = 7;
            // 
            // AuthorNameLabel
            // 
            this.AuthorNameLabel.AutoSize = true;
            this.AuthorNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.AuthorNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AuthorNameLabel.Font = new System.Drawing.Font("Metropol 95", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorNameLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.AuthorNameLabel.Location = new System.Drawing.Point(413, 0);
            this.AuthorNameLabel.Name = "AuthorNameLabel";
            this.AuthorNameLabel.Size = new System.Drawing.Size(109, 23);
            this.AuthorNameLabel.TabIndex = 7;
            this.AuthorNameLabel.Text = "Тип поста";
            this.AuthorNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Metropol 95", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(338, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Автор:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PostType
            // 
            this.PostType.AutoSize = true;
            this.PostType.BackColor = System.Drawing.Color.Transparent;
            this.PostType.Dock = System.Windows.Forms.DockStyle.Left;
            this.PostType.Font = new System.Drawing.Font("Metropol 95", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostType.ForeColor = System.Drawing.Color.Firebrick;
            this.PostType.Location = new System.Drawing.Point(229, 0);
            this.PostType.Name = "PostType";
            this.PostType.Size = new System.Drawing.Size(109, 23);
            this.PostType.TabIndex = 5;
            this.PostType.Text = "Тип поста";
            this.PostType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TypeTextLabel
            // 
            this.TypeTextLabel.AutoSize = true;
            this.TypeTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.TypeTextLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.TypeTextLabel.Font = new System.Drawing.Font("Metropol 95", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeTextLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TypeTextLabel.Location = new System.Drawing.Point(181, 0);
            this.TypeTextLabel.Name = "TypeTextLabel";
            this.TypeTextLabel.Size = new System.Drawing.Size(48, 23);
            this.TypeTextLabel.TabIndex = 4;
            this.TypeTextLabel.Text = "Тип:";
            this.TypeTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PostName
            // 
            this.PostName.AutoSize = true;
            this.PostName.BackColor = System.Drawing.Color.Transparent;
            this.PostName.Dock = System.Windows.Forms.DockStyle.Left;
            this.PostName.Font = new System.Drawing.Font("Metropol 95", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostName.ForeColor = System.Drawing.Color.Firebrick;
            this.PostName.Location = new System.Drawing.Point(64, 0);
            this.PostName.Name = "PostName";
            this.PostName.Size = new System.Drawing.Size(117, 23);
            this.PostName.TabIndex = 3;
            this.PostName.Text = "Имя поста";
            this.PostName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.MainPanel);
            this.panel1.Controls.Add(this.UpPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 739);
            this.panel1.TabIndex = 7;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Violet;
            this.MainPanel.Controls.Add(this.MainInfoPanel);
            this.MainPanel.Controls.Add(this.LeftMenu);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 78);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1368, 661);
            this.MainPanel.TabIndex = 9;
            // 
            // MainInfoPanel
            // 
            this.MainInfoPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.MainInfoPanel.Controls.Add(this.CommentPanel);
            this.MainInfoPanel.Controls.Add(this.DescriptionPanel);
            this.MainInfoPanel.Controls.Add(this.panel4);
            this.MainInfoPanel.Controls.Add(this.panel3);
            this.MainInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainInfoPanel.Location = new System.Drawing.Point(216, 0);
            this.MainInfoPanel.Name = "MainInfoPanel";
            this.MainInfoPanel.Size = new System.Drawing.Size(1152, 661);
            this.MainInfoPanel.TabIndex = 8;
            // 
            // CommentPanel
            // 
            this.CommentPanel.BackColor = System.Drawing.Color.DarkSalmon;
            this.CommentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommentPanel.Location = new System.Drawing.Point(0, 212);
            this.CommentPanel.Name = "CommentPanel";
            this.CommentPanel.Size = new System.Drawing.Size(1152, 388);
            this.CommentPanel.TabIndex = 9;
            // 
            // DescriptionPanel
            // 
            this.DescriptionPanel.BackColor = System.Drawing.Color.SlateBlue;
            this.DescriptionPanel.Controls.Add(this.PostDescription);
            this.DescriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DescriptionPanel.Location = new System.Drawing.Point(0, 36);
            this.DescriptionPanel.Name = "DescriptionPanel";
            this.DescriptionPanel.Size = new System.Drawing.Size(1152, 176);
            this.DescriptionPanel.TabIndex = 8;
            // 
            // PostDescription
            // 
            this.PostDescription.BackColor = System.Drawing.Color.MistyRose;
            this.PostDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PostDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PostDescription.Location = new System.Drawing.Point(0, 0);
            this.PostDescription.Name = "PostDescription";
            this.PostDescription.ReadOnly = true;
            this.PostDescription.Size = new System.Drawing.Size(1152, 176);
            this.PostDescription.TabIndex = 0;
            this.PostDescription.Text = "";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Controls.Add(this.NewPostBtn);
            this.panel3.Controls.Add(this.NewCommentText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 600);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1152, 61);
            this.panel3.TabIndex = 5;
            // 
            // NewPostBtn
            // 
            this.NewPostBtn.BackColor = System.Drawing.Color.Brown;
            this.NewPostBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.NewPostBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NewPostBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.NewPostBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.NewPostBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPostBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.NewPostBtn.Location = new System.Drawing.Point(936, 0);
            this.NewPostBtn.Name = "NewPostBtn";
            this.NewPostBtn.Size = new System.Drawing.Size(216, 61);
            this.NewPostBtn.TabIndex = 4;
            this.NewPostBtn.Text = "Добавить комментарий";
            this.NewPostBtn.UseVisualStyleBackColor = false;
            this.NewPostBtn.Click += new System.EventHandler(this.NewPostBtn_Click);
            // 
            // NewCommentText
            // 
            this.NewCommentText.BackColor = System.Drawing.Color.MistyRose;
            this.NewCommentText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewCommentText.Location = new System.Drawing.Point(6, 10);
            this.NewCommentText.Multiline = true;
            this.NewCommentText.Name = "NewCommentText";
            this.NewCommentText.Size = new System.Drawing.Size(924, 43);
            this.NewCommentText.TabIndex = 0;
            // 
            // LeftMenu
            // 
            this.LeftMenu.BackColor = System.Drawing.Color.MistyRose;
            this.LeftMenu.Controls.Add(this.AdminIndicatorUser);
            this.LeftMenu.Controls.Add(this.BackToTitle);
            this.LeftMenu.Controls.Add(this.ChangeBtn);
            this.LeftMenu.Controls.Add(this.PhoneDisp);
            this.LeftMenu.Controls.Add(this.PrUserName);
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LeftMenu.Location = new System.Drawing.Point(0, 0);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(216, 661);
            this.LeftMenu.TabIndex = 3;
            // 
            // AdminIndicatorUser
            // 
            this.AdminIndicatorUser.AutoCheck = false;
            this.AdminIndicatorUser.AutoSize = true;
            this.AdminIndicatorUser.Location = new System.Drawing.Point(195, 13);
            this.AdminIndicatorUser.Name = "AdminIndicatorUser";
            this.AdminIndicatorUser.Size = new System.Drawing.Size(15, 14);
            this.AdminIndicatorUser.TabIndex = 13;
            this.AdminIndicatorUser.TabStop = false;
            this.AdminIndicatorUser.UseVisualStyleBackColor = true;
            // 
            // BackToTitle
            // 
            this.BackToTitle.BackColor = System.Drawing.Color.Brown;
            this.BackToTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BackToTitle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackToTitle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BackToTitle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.BackToTitle.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackToTitle.ForeColor = System.Drawing.SystemColors.Window;
            this.BackToTitle.Location = new System.Drawing.Point(0, 600);
            this.BackToTitle.Name = "BackToTitle";
            this.BackToTitle.Size = new System.Drawing.Size(216, 61);
            this.BackToTitle.TabIndex = 7;
            this.BackToTitle.Text = "Назад";
            this.BackToTitle.UseVisualStyleBackColor = false;
            this.BackToTitle.Click += new System.EventHandler(this.BackToTitle_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.BackColor = System.Drawing.Color.Brown;
            this.ChangeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.ChangeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.ChangeBtn.Font = new System.Drawing.Font("Metropol 95", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBtn.ForeColor = System.Drawing.SystemColors.Window;
            this.ChangeBtn.Location = new System.Drawing.Point(0, 56);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(216, 62);
            this.ChangeBtn.TabIndex = 5;
            this.ChangeBtn.Text = "Перейти на страницу автора";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // PhoneDisp
            // 
            this.PhoneDisp.BackColor = System.Drawing.Color.SeaShell;
            this.PhoneDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneDisp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhoneDisp.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneDisp.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PhoneDisp.Location = new System.Drawing.Point(0, 36);
            this.PhoneDisp.Name = "PhoneDisp";
            this.PhoneDisp.Size = new System.Drawing.Size(216, 20);
            this.PhoneDisp.TabIndex = 3;
            this.PhoneDisp.Text = "Телефон:";
            // 
            // PrUserName
            // 
            this.PrUserName.BackColor = System.Drawing.Color.SeaShell;
            this.PrUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrUserName.Font = new System.Drawing.Font("Metropol 95", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrUserName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PrUserName.Location = new System.Drawing.Point(0, 0);
            this.PrUserName.Name = "PrUserName";
            this.PrUserName.Size = new System.Drawing.Size(216, 36);
            this.PrUserName.TabIndex = 2;
            this.PrUserName.Text = "Имя";
            // 
            // OpenIdeaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 739);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenIdeaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenIdeaForm";
            this.Load += new System.EventHandler(this.OpenIdeaForm_Load);
            this.UpperPanel.ResumeLayout(false);
            this.UpPanel.ResumeLayout(false);
            this.LogoPartPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainInfoPanel.ResumeLayout(false);
            this.DescriptionPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.LeftMenu.ResumeLayout(false);
            this.LeftMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ideaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ServiceProcess.ServiceController serviceController2;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.BindingSource ideaBindingSource;
        private System.Windows.Forms.Label IdeaPitLogo;
        private System.Windows.Forms.Label PostNameLabel;
        private System.Windows.Forms.Panel UpPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox NewCommentText;
        private System.Windows.Forms.Panel LeftMenu;
        private System.Windows.Forms.Button BackToTitle;
        private System.Windows.Forms.Button NewPostBtn;
        private System.Windows.Forms.Label PhoneDisp;
        private System.Windows.Forms.Label PrUserName;
        private System.Windows.Forms.Panel LogoPartPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel MainInfoPanel;
        private System.Windows.Forms.Label PostName;
        private System.Windows.Forms.Label TypeTextLabel;
        private System.Windows.Forms.Label PostType;
        private System.Windows.Forms.Panel CommentPanel;
        private System.Windows.Forms.Panel DescriptionPanel;
        private System.Windows.Forms.RichTextBox PostDescription;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.CheckBox AdminIndicatorUser;
        private System.Windows.Forms.Label AuthorNameLabel;
        private System.Windows.Forms.Label label1;
    }
}