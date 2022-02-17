
namespace IdeaPit
{
    partial class AnotherUserProfile
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
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.panel7 = new System.Windows.Forms.Panel();
            this.IdeaPitLogo = new System.Windows.Forms.Label();
            this.UpperPanel = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.serviceController2 = new System.ServiceProcess.ServiceController();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.ChangeUserBtn = new System.Windows.Forms.Button();
            this.AdminIndicatorUser = new System.Windows.Forms.CheckBox();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.CheckCommentaryBtn = new System.Windows.Forms.Button();
            this.PhoneDisp = new System.Windows.Forms.Label();
            this.PrUserName = new System.Windows.Forms.Label();
            this.SearchName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.WindowName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PrKeeperName = new System.Windows.Forms.Label();
            this.dGVUserPosts = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.AdminIndicatorKeeper = new System.Windows.Forms.CheckBox();
            this.TakeAdmin = new System.Windows.Forms.Button();
            this.MakeAdmin = new System.Windows.Forms.Button();
            this.KeeperPhoneLabel = new System.Windows.Forms.Label();
            this.KeeperNameLabel = new System.Windows.Forms.Label();
            this.ideaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel7.SuspendLayout();
            this.UpperPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUserPosts)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ideaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panel7.Controls.Add(this.IdeaPitLogo);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 27);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1368, 48);
            this.panel7.TabIndex = 7;
            // 
            // IdeaPitLogo
            // 
            this.IdeaPitLogo.BackColor = System.Drawing.Color.Teal;
            this.IdeaPitLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.IdeaPitLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IdeaPitLogo.Font = new System.Drawing.Font("Regular Brush", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdeaPitLogo.ForeColor = System.Drawing.Color.Aquamarine;
            this.IdeaPitLogo.Location = new System.Drawing.Point(0, 0);
            this.IdeaPitLogo.Name = "IdeaPitLogo";
            this.IdeaPitLogo.Size = new System.Drawing.Size(1368, 48);
            this.IdeaPitLogo.TabIndex = 8;
            this.IdeaPitLogo.Text = "Idea Pit";
            this.IdeaPitLogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UpperPanel
            // 
            this.UpperPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UpperPanel.Controls.Add(this.CloseButton);
            this.UpperPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UpperPanel.Location = new System.Drawing.Point(0, 0);
            this.UpperPanel.Name = "UpperPanel";
            this.UpperPanel.Size = new System.Drawing.Size(1368, 27);
            this.UpperPanel.TabIndex = 9;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.RefreshBtn);
            this.panel2.Controls.Add(this.ChangeUserBtn);
            this.panel2.Controls.Add(this.AdminIndicatorUser);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.CheckCommentaryBtn);
            this.panel2.Controls.Add(this.PhoneDisp);
            this.panel2.Controls.Add(this.PrUserName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 664);
            this.panel2.TabIndex = 3;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.RefreshBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RefreshBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.RefreshBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.RefreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.RefreshBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RefreshBtn.Location = new System.Drawing.Point(0, 542);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(218, 61);
            this.RefreshBtn.TabIndex = 11;
            this.RefreshBtn.Text = "Обновить";
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // ChangeUserBtn
            // 
            this.ChangeUserBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.ChangeUserBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ChangeUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ChangeUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.ChangeUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.ChangeUserBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeUserBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ChangeUserBtn.Location = new System.Drawing.Point(0, 603);
            this.ChangeUserBtn.Name = "ChangeUserBtn";
            this.ChangeUserBtn.Size = new System.Drawing.Size(218, 61);
            this.ChangeUserBtn.TabIndex = 7;
            this.ChangeUserBtn.Text = "Назад";
            this.ChangeUserBtn.UseVisualStyleBackColor = false;
            this.ChangeUserBtn.Click += new System.EventHandler(this.ChangeUserBtn_Click);
            // 
            // AdminIndicatorUser
            // 
            this.AdminIndicatorUser.AutoCheck = false;
            this.AdminIndicatorUser.AutoSize = true;
            this.AdminIndicatorUser.Location = new System.Drawing.Point(192, 12);
            this.AdminIndicatorUser.Name = "AdminIndicatorUser";
            this.AdminIndicatorUser.Size = new System.Drawing.Size(15, 14);
            this.AdminIndicatorUser.TabIndex = 10;
            this.AdminIndicatorUser.TabStop = false;
            this.AdminIndicatorUser.UseVisualStyleBackColor = true;
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.DeleteBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.DeleteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.DeleteBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.DeleteBtn.Location = new System.Drawing.Point(0, 95);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(218, 39);
            this.DeleteBtn.TabIndex = 9;
            this.DeleteBtn.Text = "Удалить пост";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // CheckCommentaryBtn
            // 
            this.CheckCommentaryBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.CheckCommentaryBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckCommentaryBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CheckCommentaryBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.CheckCommentaryBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.CheckCommentaryBtn.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CheckCommentaryBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CheckCommentaryBtn.Location = new System.Drawing.Point(0, 56);
            this.CheckCommentaryBtn.Name = "CheckCommentaryBtn";
            this.CheckCommentaryBtn.Size = new System.Drawing.Size(218, 39);
            this.CheckCommentaryBtn.TabIndex = 8;
            this.CheckCommentaryBtn.Text = "Открыть пост";
            this.CheckCommentaryBtn.UseVisualStyleBackColor = false;
            this.CheckCommentaryBtn.Click += new System.EventHandler(this.CheckCommentaryBtn_Click);
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
            // SearchName
            // 
            this.SearchName.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchName.Location = new System.Drawing.Point(102, 6);
            this.SearchName.Multiline = true;
            this.SearchName.Name = "SearchName";
            this.SearchName.Size = new System.Drawing.Size(824, 43);
            this.SearchName.TabIndex = 0;
            this.SearchName.TextChanged += new System.EventHandler(this.SearchName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCyan;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.SearchName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(932, 61);
            this.panel3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Metropol 95", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 43);
            this.label2.TabIndex = 7;
            this.label2.Text = "Поиск";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 603);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(932, 61);
            this.panel6.TabIndex = 7;
            // 
            // WindowName
            // 
            this.WindowName.AutoSize = true;
            this.WindowName.BackColor = System.Drawing.Color.Transparent;
            this.WindowName.Dock = System.Windows.Forms.DockStyle.Left;
            this.WindowName.Font = new System.Drawing.Font("Metropol 95", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.WindowName.Location = new System.Drawing.Point(0, 0);
            this.WindowName.Name = "WindowName";
            this.WindowName.Size = new System.Drawing.Size(105, 23);
            this.WindowName.TabIndex = 2;
            this.WindowName.Text = "Профиль";
            this.WindowName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightCyan;
            this.panel4.Controls.Add(this.PrKeeperName);
            this.panel4.Controls.Add(this.WindowName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(932, 36);
            this.panel4.TabIndex = 7;
            // 
            // PrKeeperName
            // 
            this.PrKeeperName.AutoSize = true;
            this.PrKeeperName.BackColor = System.Drawing.Color.Transparent;
            this.PrKeeperName.Dock = System.Windows.Forms.DockStyle.Left;
            this.PrKeeperName.Font = new System.Drawing.Font("Metropol 95", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PrKeeperName.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PrKeeperName.Location = new System.Drawing.Point(105, 0);
            this.PrKeeperName.Name = "PrKeeperName";
            this.PrKeeperName.Size = new System.Drawing.Size(156, 23);
            this.PrKeeperName.TabIndex = 3;
            this.PrKeeperName.Text = "Имя Профиля";
            this.PrKeeperName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dGVUserPosts
            // 
            this.dGVUserPosts.AllowUserToAddRows = false;
            this.dGVUserPosts.AllowUserToDeleteRows = false;
            this.dGVUserPosts.AllowUserToResizeColumns = false;
            this.dGVUserPosts.AllowUserToResizeRows = false;
            this.dGVUserPosts.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.dGVUserPosts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVUserPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGVUserPosts.Location = new System.Drawing.Point(0, 0);
            this.dGVUserPosts.MultiSelect = false;
            this.dGVUserPosts.Name = "dGVUserPosts";
            this.dGVUserPosts.RowTemplate.Height = 24;
            this.dGVUserPosts.Size = new System.Drawing.Size(932, 567);
            this.dGVUserPosts.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Thistle;
            this.panel8.Controls.Add(this.dGVUserPosts);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 36);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(932, 567);
            this.panel8.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Crimson;
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(932, 664);
            this.panel5.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1368, 664);
            this.panel1.TabIndex = 7;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.BlueViolet;
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(218, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(932, 664);
            this.panel10.TabIndex = 9;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel9.Controls.Add(this.AdminIndicatorKeeper);
            this.panel9.Controls.Add(this.TakeAdmin);
            this.panel9.Controls.Add(this.MakeAdmin);
            this.panel9.Controls.Add(this.KeeperPhoneLabel);
            this.panel9.Controls.Add(this.KeeperNameLabel);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel9.Location = new System.Drawing.Point(1150, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(218, 664);
            this.panel9.TabIndex = 3;
            // 
            // AdminIndicatorKeeper
            // 
            this.AdminIndicatorKeeper.AutoCheck = false;
            this.AdminIndicatorKeeper.AutoSize = true;
            this.AdminIndicatorKeeper.Location = new System.Drawing.Point(191, 12);
            this.AdminIndicatorKeeper.Name = "AdminIndicatorKeeper";
            this.AdminIndicatorKeeper.Size = new System.Drawing.Size(15, 14);
            this.AdminIndicatorKeeper.TabIndex = 10;
            this.AdminIndicatorKeeper.TabStop = false;
            this.AdminIndicatorKeeper.UseVisualStyleBackColor = true;
            // 
            // TakeAdmin
            // 
            this.TakeAdmin.BackColor = System.Drawing.Color.DarkCyan;
            this.TakeAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.TakeAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TakeAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.TakeAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.TakeAdmin.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TakeAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TakeAdmin.Location = new System.Drawing.Point(0, 109);
            this.TakeAdmin.Name = "TakeAdmin";
            this.TakeAdmin.Size = new System.Drawing.Size(218, 53);
            this.TakeAdmin.TabIndex = 10;
            this.TakeAdmin.Text = "Забрать права администратора";
            this.TakeAdmin.UseVisualStyleBackColor = false;
            this.TakeAdmin.Click += new System.EventHandler(this.TakeAdmin_Click);
            // 
            // MakeAdmin
            // 
            this.MakeAdmin.BackColor = System.Drawing.Color.DarkCyan;
            this.MakeAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.MakeAdmin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.MakeAdmin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.MakeAdmin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumAquamarine;
            this.MakeAdmin.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MakeAdmin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MakeAdmin.Location = new System.Drawing.Point(0, 56);
            this.MakeAdmin.Name = "MakeAdmin";
            this.MakeAdmin.Size = new System.Drawing.Size(218, 53);
            this.MakeAdmin.TabIndex = 9;
            this.MakeAdmin.Text = "Назначить администратором";
            this.MakeAdmin.UseVisualStyleBackColor = false;
            this.MakeAdmin.Click += new System.EventHandler(this.MakeAdmin_Click);
            // 
            // KeeperPhoneLabel
            // 
            this.KeeperPhoneLabel.BackColor = System.Drawing.Color.LightCyan;
            this.KeeperPhoneLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeeperPhoneLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeeperPhoneLabel.Font = new System.Drawing.Font("Metropol 95", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeeperPhoneLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.KeeperPhoneLabel.Location = new System.Drawing.Point(0, 36);
            this.KeeperPhoneLabel.Name = "KeeperPhoneLabel";
            this.KeeperPhoneLabel.Size = new System.Drawing.Size(218, 20);
            this.KeeperPhoneLabel.TabIndex = 3;
            this.KeeperPhoneLabel.Text = "Телефон:";
            // 
            // KeeperNameLabel
            // 
            this.KeeperNameLabel.BackColor = System.Drawing.Color.LightCyan;
            this.KeeperNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.KeeperNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.KeeperNameLabel.Font = new System.Drawing.Font("Metropol 95", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KeeperNameLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.KeeperNameLabel.Location = new System.Drawing.Point(0, 0);
            this.KeeperNameLabel.Name = "KeeperNameLabel";
            this.KeeperNameLabel.Size = new System.Drawing.Size(218, 36);
            this.KeeperNameLabel.TabIndex = 2;
            this.KeeperNameLabel.Text = "Имя";
            // 
            // AnotherUserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 739);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.UpperPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AnotherUserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnotherUserProfile";
            this.panel7.ResumeLayout(false);
            this.UpperPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUserPosts)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ideaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource ideaBindingSource;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label IdeaPitLogo;
        private System.Windows.Forms.Panel UpperPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.ServiceProcess.ServiceController serviceController2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CheckCommentaryBtn;
        private System.Windows.Forms.Label PhoneDisp;
        private System.Windows.Forms.Label PrUserName;
        private System.Windows.Forms.TextBox SearchName;
        private System.Windows.Forms.Button ChangeUserBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label WindowName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label PrKeeperName;
        private System.Windows.Forms.DataGridView dGVUserPosts;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.CheckBox AdminIndicatorUser;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.CheckBox AdminIndicatorKeeper;
        private System.Windows.Forms.Button TakeAdmin;
        private System.Windows.Forms.Button MakeAdmin;
        private System.Windows.Forms.Label KeeperPhoneLabel;
        private System.Windows.Forms.Label KeeperNameLabel;
        private System.Windows.Forms.Button RefreshBtn;
    }
}