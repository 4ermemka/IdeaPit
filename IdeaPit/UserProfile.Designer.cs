
namespace IdeaPit
{
    partial class UserProfile
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dGVUserPosts = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.WindowName = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChangeUserBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.UserInfoChangeBtn = new System.Windows.Forms.Button();
            this.IdeaFindBtn = new System.Windows.Forms.Button();
            this.UserFindBtn = new System.Windows.Forms.Button();
            this.AdminIndicatorUser = new System.Windows.Forms.CheckBox();
            this.CheckCommentaryBtn = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.NewPostBtn = new System.Windows.Forms.Button();
            this.PhoneDisp = new System.Windows.Forms.Label();
            this.PrUserName = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.IdeaPitLogo = new System.Windows.Forms.Label();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.serviceController2 = new System.ServiceProcess.ServiceController();
            this.ideaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUserPosts)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ideaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(218, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1150, 661);
            this.panel5.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Thistle;
            this.panel8.Controls.Add(this.dGVUserPosts);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 36);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1150, 564);
            this.panel8.TabIndex = 8;
            // 
            // dGVUserPosts
            // 
            this.dGVUserPosts.AllowUserToAddRows = false;
            this.dGVUserPosts.AllowUserToDeleteRows = false;
            this.dGVUserPosts.AllowUserToResizeColumns = false;
            this.dGVUserPosts.AllowUserToResizeRows = false;
            this.dGVUserPosts.BackgroundColor = System.Drawing.Color.Thistle;
            this.dGVUserPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUserPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVUserPosts.Location = new System.Drawing.Point(0, 0);
            this.dGVUserPosts.MultiSelect = false;
            this.dGVUserPosts.Name = "dGVUserPosts";
            this.dGVUserPosts.RowTemplate.Height = 24;
            this.dGVUserPosts.Size = new System.Drawing.Size(1150, 564);
            this.dGVUserPosts.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.WindowName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1150, 36);
            this.panel4.TabIndex = 7;
            // 
            // WindowName
            // 
            this.WindowName.AutoSize = true;
            this.WindowName.BackColor = System.Drawing.Color.Transparent;
            this.WindowName.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowName.Font = new System.Drawing.Font("Metropol 95", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WindowName.Location = new System.Drawing.Point(0, 0);
            this.WindowName.Name = "WindowName";
            this.WindowName.Size = new System.Drawing.Size(204, 29);
            this.WindowName.TabIndex = 2;
            this.WindowName.Text = "Мой профиль";
            this.WindowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 600);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1150, 61);
            this.panel6.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.SearchType);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.ChangeUserBtn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.SearchName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1150, 61);
            this.panel3.TabIndex = 5;
            // 
            // SearchType
            // 
            this.SearchType.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchType.Location = new System.Drawing.Point(603, 15);
            this.SearchType.Multiline = true;
            this.SearchType.Name = "SearchType";
            this.SearchType.Size = new System.Drawing.Size(359, 34);
            this.SearchType.TabIndex = 9;
            this.SearchType.TextChanged += new System.EventHandler(this.SearchType_TextChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Metropol 95", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(538, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Тип";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Metropol 95", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(97, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 34);
            this.label1.TabIndex = 8;
            this.label1.Text = "Назв.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChangeUserBtn
            // 
            this.ChangeUserBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.ChangeUserBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ChangeUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangeUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChangeUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.ChangeUserBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeUserBtn.ForeColor = System.Drawing.Color.Black;
            this.ChangeUserBtn.Location = new System.Drawing.Point(968, 0);
            this.ChangeUserBtn.Name = "ChangeUserBtn";
            this.ChangeUserBtn.Size = new System.Drawing.Size(182, 61);
            this.ChangeUserBtn.TabIndex = 7;
            this.ChangeUserBtn.Text = "Выход";
            this.ChangeUserBtn.UseVisualStyleBackColor = false;
            this.ChangeUserBtn.Click += new System.EventHandler(this.ChangeUserBtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Metropol 95", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(6, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поиск";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SearchName
            // 
            this.SearchName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchName.Location = new System.Drawing.Point(173, 15);
            this.SearchName.Multiline = true;
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(359, 34);
            this.SearchName.TabIndex = 0;
            this.SearchName.TextChanged += new System.EventHandler(this.SearchName_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel2.Controls.Add(this.UserInfoChangeBtn);
            this.panel2.Controls.Add(this.IdeaFindBtn);
            this.panel2.Controls.Add(this.UserFindBtn);
            this.panel2.Controls.Add(this.AdminIndicatorUser);
            this.panel2.Controls.Add(this.CheckCommentaryBtn);
            this.panel2.Controls.Add(this.RefreshBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.ChangeBtn);
            this.panel2.Controls.Add(this.NewPostBtn);
            this.panel2.Controls.Add(this.PhoneDisp);
            this.panel2.Controls.Add(this.PrUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 661);
            this.panel2.TabIndex = 3;
            // 
            // UserInfoChangeBtn
            // 
            this.UserInfoChangeBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.UserInfoChangeBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.UserInfoChangeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UserInfoChangeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserInfoChangeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.UserInfoChangeBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserInfoChangeBtn.ForeColor = System.Drawing.Color.Black;
            this.UserInfoChangeBtn.Location = new System.Drawing.Point(0, 561);
            this.UserInfoChangeBtn.Name = "UserInfoChangeBtn";
            this.UserInfoChangeBtn.Size = new System.Drawing.Size(218, 39);
            this.UserInfoChangeBtn.TabIndex = 15;
            this.UserInfoChangeBtn.Text = "Редактировать профиль";
            this.UserInfoChangeBtn.UseVisualStyleBackColor = false;
            this.UserInfoChangeBtn.Click += new System.EventHandler(this.UserInfoChangeBtn_Click);
            // 
            // IdeaFindBtn
            // 
            this.IdeaFindBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.IdeaFindBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdeaFindBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.IdeaFindBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.IdeaFindBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.IdeaFindBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IdeaFindBtn.ForeColor = System.Drawing.Color.Black;
            this.IdeaFindBtn.Location = new System.Drawing.Point(0, 251);
            this.IdeaFindBtn.Name = "IdeaFindBtn";
            this.IdeaFindBtn.Size = new System.Drawing.Size(218, 39);
            this.IdeaFindBtn.TabIndex = 14;
            this.IdeaFindBtn.Text = "Поиск по идеям";
            this.IdeaFindBtn.UseVisualStyleBackColor = false;
            this.IdeaFindBtn.Click += new System.EventHandler(this.IdeaFindBtn_Click);
            // 
            // UserFindBtn
            // 
            this.UserFindBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.UserFindBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserFindBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.UserFindBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserFindBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.UserFindBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserFindBtn.ForeColor = System.Drawing.Color.Black;
            this.UserFindBtn.Location = new System.Drawing.Point(0, 212);
            this.UserFindBtn.Name = "UserFindBtn";
            this.UserFindBtn.Size = new System.Drawing.Size(218, 39);
            this.UserFindBtn.TabIndex = 13;
            this.UserFindBtn.Text = "Поиск по пользователям";
            this.UserFindBtn.UseVisualStyleBackColor = false;
            this.UserFindBtn.Click += new System.EventHandler(this.UserFindBtn_Click);
            // 
            // AdminIndicatorUser
            // 
            this.AdminIndicatorUser.AutoCheck = false;
            this.AdminIndicatorUser.AutoSize = true;
            this.AdminIndicatorUser.Location = new System.Drawing.Point(197, 13);
            this.AdminIndicatorUser.Name = "AdminIndicatorUser";
            this.AdminIndicatorUser.Size = new System.Drawing.Size(15, 14);
            this.AdminIndicatorUser.TabIndex = 12;
            this.AdminIndicatorUser.TabStop = false;
            this.AdminIndicatorUser.UseVisualStyleBackColor = true;
            // 
            // CheckCommentaryBtn
            // 
            this.CheckCommentaryBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.CheckCommentaryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckCommentaryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckCommentaryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CheckCommentaryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.CheckCommentaryBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckCommentaryBtn.ForeColor = System.Drawing.Color.Black;
            this.CheckCommentaryBtn.Location = new System.Drawing.Point(0, 173);
            this.CheckCommentaryBtn.Name = "CheckCommentaryBtn";
            this.CheckCommentaryBtn.Size = new System.Drawing.Size(218, 39);
            this.CheckCommentaryBtn.TabIndex = 8;
            this.CheckCommentaryBtn.Text = "Открыть пост";
            this.CheckCommentaryBtn.UseVisualStyleBackColor = false;
            this.CheckCommentaryBtn.Click += new System.EventHandler(this.CheckCommentaryBtn_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.RefreshBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RefreshBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RefreshBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RefreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.RefreshBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.Location = new System.Drawing.Point(0, 600);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(218, 61);
            this.RefreshBtn.TabIndex = 7;
            this.RefreshBtn.Text = "Обновить форму";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.DeleteBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.Location = new System.Drawing.Point(0, 134);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(218, 39);
            this.DeleteBtn.TabIndex = 6;
            this.DeleteBtn.Text = "Удалить пост";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.ChangeBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChangeBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ChangeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.ChangeBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBtn.ForeColor = System.Drawing.Color.Black;
            this.ChangeBtn.Location = new System.Drawing.Point(0, 95);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(218, 39);
            this.ChangeBtn.TabIndex = 5;
            this.ChangeBtn.Text = "Изменить пост";
            this.ChangeBtn.UseVisualStyleBackColor = false;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // NewPostBtn
            // 
            this.NewPostBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.NewPostBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.NewPostBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NewPostBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewPostBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.NewPostBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPostBtn.ForeColor = System.Drawing.Color.Black;
            this.NewPostBtn.Location = new System.Drawing.Point(0, 56);
            this.NewPostBtn.Name = "NewPostBtn";
            this.NewPostBtn.Size = new System.Drawing.Size(218, 39);
            this.NewPostBtn.TabIndex = 4;
            this.NewPostBtn.Text = "Новый Пост";
            this.NewPostBtn.UseVisualStyleBackColor = false;
            this.NewPostBtn.Click += new System.EventHandler(this.NewPostBtn_Click);
            // 
            // PhoneDisp
            // 
            this.PhoneDisp.BackColor = System.Drawing.Color.LightCyan;
            this.PhoneDisp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhoneDisp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhoneDisp.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneDisp.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PhoneDisp.Location = new System.Drawing.Point(0, 36);
            this.PhoneDisp.Name = "PhoneDisp";
            this.PhoneDisp.Size = new System.Drawing.Size(218, 20);
            this.PhoneDisp.TabIndex = 3;
            this.PhoneDisp.Text = "Телефон:";
            // 
            // PrUserName
            // 
            this.PrUserName.BackColor = System.Drawing.Color.LightCyan;
            this.PrUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrUserName.Dock = System.Windows.Forms.DockStyle.Top;
            this.PrUserName.Font = new System.Drawing.Font("Metropol 95", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrUserName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.PrUserName.Location = new System.Drawing.Point(0, 0);
            this.PrUserName.Name = "PrUserName";
            this.PrUserName.Size = new System.Drawing.Size(218, 36);
            this.PrUserName.TabIndex = 2;
            this.PrUserName.Text = "Имя";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
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
            this.IdeaPitLogo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.IdeaPitLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdeaPitLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.IdeaPitLogo.Font = new System.Drawing.Font("Regular Brush", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaPitLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.IdeaPitLogo.Location = new System.Drawing.Point(0, 27);
            this.IdeaPitLogo.Name = "IdeaPitLogo";
            this.IdeaPitLogo.Size = new System.Drawing.Size(1368, 51);
            this.IdeaPitLogo.TabIndex = 1;
            this.IdeaPitLogo.Text = "Idea Pit";
            this.IdeaPitLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.UpperPanel.Controls.Add(this.panel7);
            this.UpperPanel.Controls.Add(this.CloseButton);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1368, 27);
            this.UpperPanel.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1338, 27);
            this.panel7.TabIndex = 7;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1368, 739);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.IdeaPitLogo);
            this.Controls.Add(this.UpperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserProfile";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVUserPosts)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.UpperPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ideaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WindowName;
        private System.Windows.Forms.Label PrUserName;
        private System.Windows.Forms.Label IdeaPitLogo;
        private System.Windows.Forms.Panel panel2;
        //private IdeasDataSet ideasDataSet;
        private System.Windows.Forms.BindingSource ideaBindingSource;
        //private IdeasDataSetTableAdapters.IdeaTableAdapter ideaTableAdapter;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label PhoneDisp;
        private System.Windows.Forms.Button NewPostBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ChangeBtn;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.DataGridView dGVUserPosts;
        private System.ServiceProcess.ServiceController serviceController2;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Button ChangeUserBtn;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button CheckCommentaryBtn;
        private System.Windows.Forms.CheckBox AdminIndicatorUser;
        private System.Windows.Forms.Button IdeaFindBtn;
        private System.Windows.Forms.Button UserFindBtn;
        private System.Windows.Forms.Button UserInfoChangeBtn;
        private System.Windows.Forms.TextBox SearchType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}