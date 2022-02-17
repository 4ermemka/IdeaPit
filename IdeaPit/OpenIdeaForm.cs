using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace IdeaPit
{
    public partial class OpenIdeaForm : Form
    {
        private bool isModer;
        private int user;
        private int author;
        private int idea;

        public OpenIdeaForm()
        {
            InitializeComponent();
            PostName.Text = "ИМЯ ПОСТА";
            PostType.Text = "ТИП ПОСТА";
        }
        public OpenIdeaForm(int id_idea, int id_user, int id_author, bool ismoder, string newName, string newType, string newDescr, bool isfree)
        {
            InitializeComponent();
            this.isModer = ismoder;
            this.user = id_user;
            this.author = id_author;
            this.idea = id_idea;

            string ask = "SELECT * FROM Users WHERE ID_user = \'" + this.user + "\'";

            DataTable ds = new DataTable();

            ds = GetData(ask);

            int num = ds.Rows[0].Field<int>("ID_user");
            String UserName = ds.Rows[0].Field<String>("UserName");
            String PhoneNum = ds.Rows[0].Field<String>("PhoneNumber");

            PrUserName.Text = UserName;
            PhoneDisp.Text = PhoneNum;

            ask = "SELECT * FROM Users WHERE ID_user = \'" + this.author + "\'";

            ds = new DataTable();

            ds = GetData(ask);

            //int num = ds.Rows[0].Field<int>("ID_user");
            String AuthorName = ds.Rows[0].Field<String>("UserName");
            String AuthorPhone = ds.Rows[0].Field<String>("PhoneNumber");

            AuthorNameLabel.Text = AuthorName;

            ask = "SELECT * FROM Idea WHERE ID_idea = \'" + this.idea + "\'";

            ds = GetData(ask);
            String IdeaName = ds.Rows[0].Field<String>("Name");
            String IdeaType = ds.Rows[0].Field<String>("Type");
            String IdeaDescription = ds.Rows[0].Field<String>("Description");
            bool isFree = ds.Rows[0].Field<bool>("IsFree");

            PostName.Text = IdeaName;
            PostType.Text = IdeaType;
            PostDescription.Text = IdeaDescription;
        }

        private void OpenIdeaForm_Load(object sender, EventArgs e)
        {
            refreshComments(CommentPanel);
        }

        public void refreshComments(Panel CommentPanel)
        {
            DataTable ds = new DataTable();

            ds = GetComments();

            CommentPanel.Controls.Clear();

            CommentPanel.Visible = false;

            Panel subUp = new Panel();
            Panel subDown = new Panel();

            subUp.Size = new Size(5, 15);
            subUp.Dock = DockStyle.Top;
            subUp.AutoSize = true;
            subUp.BackColor = Color.LightGray;

            subDown.Size = new Size(5, 5);
            subDown.Dock = DockStyle.Bottom;
            subDown.AutoSize = true;
            subDown.BackColor = Color.LightGray;

            Panel panel = new Panel();
            for (int i = ds.Rows.Count - 1; i >= 0; i--)
            {
                String Text = ds.Rows[i].Field<string>("Text");
                String UserName = ds.Rows[i].Field<string>("UserName");
                int id_comm = ds.Rows[i].Field<int>("ID_comment");
                int id_user = ds.Rows[i].Field<int>("ID_user");
                DateTime pubDate = ds.Rows[i].Field<DateTime>("PostTime");

                panel = CreateMyPanel(Text, UserName, pubDate, id_user);

                if (ds.Rows[i].Field<int>("ID_user") == this.user || this.isModer)
                {
                    Button bt = new Button();
                    bt.Text = "Удалить";
                    bt.Name = "bt" + i;
                    bt.Dock = DockStyle.Right;
                    panel.Controls.Add(bt);
                    bt.Click += (o, args) =>
                    {
                        Commentary comm = db.Commentary.Where(p => p.ID_comment == id_comm).FirstOrDefault();
                        if (comm!=null)
                        {
                            db.Commentary.Remove(comm);
                            db.SaveChanges(); // сохраняем в БД
                            refreshComments(CommentPanel);
                        }
                    };
                }

                panel.Dock = DockStyle.Top;
                panel.AutoSize = true;
                panel.BackColor = Color.White;

                panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                CommentPanel.Controls.Add(subUp);
                CommentPanel.Controls.Add(panel);
                CommentPanel.Controls.Add(subDown);
            }
            CommentPanel.AutoScroll = true;
            CommentPanel.Visible = true;

            if (this.isModer)
            {
                AdminIndicatorUser.Checked = true;
            }
        }

        public Panel CreateMyPanel(string text, string userName, DateTime commPub, int id_keeper)
        {
            Panel currPanel = new Panel();
            
            TextBox commentText = new TextBox();
            Label usernameLabel = new Label();
            Label pubDate = new Label();

            commPub.ToShortDateString();

            pubDate.Location = new Point(16, 16);
            pubDate.Text = commPub.ToString();
            pubDate.AutoSize = true;
            pubDate.ForeColor = Color.Gray;
            pubDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pubDate.Dock = DockStyle.Bottom;

            // Initialize the Label and TextBox controls.
            usernameLabel.Location = new Point(16, 16);
            usernameLabel.Text = userName;
            usernameLabel.Size = new Size(104, 16);
            usernameLabel.ForeColor = Color.DarkCyan;
            usernameLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            usernameLabel.Dock = DockStyle.Top;
            usernameLabel.Cursor = Cursors.Hand;
            usernameLabel.Click += (o, args) =>
            {
                if (this.user != id_keeper)
                {
                    AnotherUserProfile keeperProfile = new AnotherUserProfile(this.user, id_keeper);
                    keeperProfile.Show();
                    this.Close();
                }
                else
                {
                    UserProfile upr = new UserProfile(this.user, this.isModer);
                    upr.Show();
                    this.Close();
                }
            };

            commentText.Location = new Point(16, 32);
            commentText.Text = "     " + text;
            commentText.ForeColor = Color.Black;
            commentText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            commentText.Size = new Size(152, 20);
            commentText.Dock = DockStyle.Top;

            // Add the Panel control to the form.
            this.Controls.Add(currPanel);
            // Add the Label and TextBox controls to the Panel.
            currPanel.BackColor = Color.White;
            currPanel.Controls.Add(commentText);
            currPanel.Controls.Add(usernameLabel);
            currPanel.Controls.Add(pubDate);

            return currPanel;
        }

        private DataTable GetComments()
        {
            string ask= "select COM.*,UserName from dbo.Users US, dbo.Commentary COM where " + 
                "US.ID_user = COM.ID_user AND COM.ID_idea = " + this.idea;

            DataTable table = new DataTable();

            table = GetData(ask);

            return table;
        }

        private static DataTable GetData(string sqlCommand)
        {
            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Ideas; Integrated Security=True";
            SqlConnection cardConnection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(sqlCommand, cardConnection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            return table;
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            UserProfile upr = new UserProfile(this.user, this.isModer);
            upr.Show();
            this.Close();
        }

        private void ChangeUserBtn_Click(object sender, EventArgs e)
        {
            UserProfile upr = new UserProfile(this.user, this.isModer);
            upr.Show();
            this.Close();
        }

        UserContext db = new UserContext();
        private void NewPostBtn_Click(object sender, EventArgs e)
        {
            if (NewCommentText.Text != "")
            {
                Commentary comm = new Commentary();

                string ask = "Select * from Commentary";
                DataTable table = new DataTable();
                table = GetData(ask);

                int id_comm;

                if (table.Rows.Count > 0) id_comm = table.Rows[table.Rows.Count - 1].Field<int>("ID_comment") + 1;
                else id_comm = 0;

                comm.Text = NewCommentText.Text;
                comm.ComRating = 0;
                comm.PostTime = DateTime.Now;
                comm.ID_comment = id_comm;
                comm.ID_user = this.user;
                comm.ID_idea = this.idea;

                db.Commentary.Add(comm);
                db.SaveChanges();

                refreshComments(CommentPanel);

                NewCommentText.Text = "";
            }
        }

        private void BackToTitle_Click(object sender, EventArgs e)
        {
            UserProfile upr = new UserProfile(this.user, this.isModer);
            upr.Show();
            this.Close();
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (this.user == this.author)
            {
                UserProfile upr = new UserProfile(this.user, this.isModer);
                upr.Show();
                this.Close();
            }
            else 
            {
                AnotherUserProfile pr = new AnotherUserProfile(this.user, this.author);
                pr.Show();
                this.Close();
            }
        }
    }
}
