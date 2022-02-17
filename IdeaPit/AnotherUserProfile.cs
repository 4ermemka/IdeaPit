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
    public partial class AnotherUserProfile : Form
    {
        public int user;
        public int keeper;
        public bool userIsModer;
        public bool keeperIsModer;

        UserContext db = new UserContext();

        public AnotherUserProfile()
        {
            InitializeComponent();
        }
        public AnotherUserProfile(int id_user, int id_keeper)
        {
            InitializeComponent();
            this.user = id_user;
            this.keeper = id_keeper;

            string ask = "SELECT * FROM Users WHERE ID_user = \'" + this.user + "\'";

            DataTable ds = new DataTable();

            ds = GetData(ask);

            String UserName = ds.Rows[0].Field<String>("UserName");
            String PhoneNum = ds.Rows[0].Field<String>("PhoneNumber");
            this.userIsModer = ds.Rows[0].Field<bool>("IsModer");

            PrUserName.Text = UserName;
            PhoneDisp.Text = "Телефон: " + PhoneNum;

            ask = "SELECT * FROM Users WHERE ID_user = \'" + this.keeper + "\'";

            ds = new DataTable();

            ds = GetData(ask);

            String KeeperName = ds.Rows[0].Field<String>("UserName");
            String KeeperPhone = ds.Rows[0].Field<String>("PhoneNumber");
            this.keeperIsModer = ds.Rows[0].Field<bool>("IsModer");

            PrKeeperName.Text = KeeperName;
            KeeperNameLabel.Text = KeeperName;
            KeeperPhoneLabel.Text = "Телефон: " + KeeperPhone;

            refreshTable(dGVUserPosts);
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

        private DataTable GetPosts()
        {
            string ask = "SELECT distinct * " +
                "From Idea,Users Where ID_idea in " +
                "(SELECT Idea.ID_idea From(Post Inner Join Idea On Post.ID_idea = Idea.ID_idea) Where Post.ID_user = \'" + this.keeper.ToString() + "\' AND Users.ID_user =\'" + this.keeper.ToString() + "\');";

            DataTable table = new DataTable();

            table = GetData(ask);

            return table;
        }
        public void refreshTable(DataGridView dGVUserPosts)
        {
            dGVUserPosts.Columns.Clear();
            dGVUserPosts.DataSource = GetPosts();

            dGVUserPosts.Columns[0].Visible = false;
            dGVUserPosts.Columns[1].HeaderText = "Название"; dGVUserPosts.Columns[1].Width = 150; dGVUserPosts.Columns[1].ReadOnly = true;
            dGVUserPosts.Columns[2].HeaderText = "Описание"; dGVUserPosts.Columns[2].Width = 250; dGVUserPosts.Columns[2].ReadOnly = true;
            dGVUserPosts.Columns[3].HeaderText = "Тип"; dGVUserPosts.Columns[3].Width = 150; dGVUserPosts.Columns[3].ReadOnly = true;
            dGVUserPosts.Columns[4].HeaderText = "Дата публикации"; dGVUserPosts.Columns[4].Width = 150; dGVUserPosts.Columns[4].ReadOnly = true;
            dGVUserPosts.Columns[5].Visible = false;
            dGVUserPosts.Columns[6].HeaderText = "Бесплатно"; dGVUserPosts.Columns[6].Width = 150; dGVUserPosts.Columns[6].ReadOnly = true;
            for (int i = 7; i < dGVUserPosts.Columns.Count; i++)
            {
                dGVUserPosts.Columns[i].Visible = false;
            }

            if (this.userIsModer)
            {
                MakeAdmin.Enabled = true;
                TakeAdmin.Enabled = true;
                AdminIndicatorUser.Checked = true;
            }
            else 
            {
                MakeAdmin.Enabled = false;
                TakeAdmin.Enabled = false;
                AdminIndicatorUser.Checked = false;
            }

            if (this.keeperIsModer)
            {
                AdminIndicatorKeeper.Checked = true;
            }
            else 
            {
                AdminIndicatorKeeper.Checked = false;
            }
        }

        public void refreshSearch(DataGridView dGVUserPosts)
        {
            dGVUserPosts.Columns[0].Visible = false;
            dGVUserPosts.Columns[1].HeaderText = "Название"; dGVUserPosts.Columns[1].Width = 150; dGVUserPosts.Columns[1].ReadOnly = true;
            dGVUserPosts.Columns[2].HeaderText = "Описание"; dGVUserPosts.Columns[2].Width = 250; dGVUserPosts.Columns[2].ReadOnly = true;
            dGVUserPosts.Columns[3].HeaderText = "Тип"; dGVUserPosts.Columns[3].Width = 150; dGVUserPosts.Columns[3].ReadOnly = true;
            dGVUserPosts.Columns[4].HeaderText = "Дата публикации"; dGVUserPosts.Columns[4].Width = 150; dGVUserPosts.Columns[4].ReadOnly = true;
            dGVUserPosts.Columns[5].Visible = false;
            dGVUserPosts.Columns[6].HeaderText = "Бесплатно"; dGVUserPosts.Columns[6].Width = 150; dGVUserPosts.Columns[6].ReadOnly = true;
            for (int i = 7; i < dGVUserPosts.Columns.Count; i++)
            {
                dGVUserPosts.Columns[i].Visible = false;
            }

            if (this.userIsModer)
            {
                MakeAdmin.Enabled = true;
                TakeAdmin.Enabled = true;
                AdminIndicatorUser.Checked = true;
            }
            else
            {
                MakeAdmin.Enabled = false;
                TakeAdmin.Enabled = false;
                AdminIndicatorUser.Checked = false;
            }

            if (this.keeperIsModer)
            {
                AdminIndicatorKeeper.Checked = true;
            }
            else
            {
                AdminIndicatorKeeper.Checked = false;
            }
        }

        PostsDB posts = new PostsDB();

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dGVUserPosts.CurrentCell != null)
            {
                if(this.userIsModer && !this.keeperIsModer)
                {
                    int id = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_idea"].Value);

                    if (posts.DeleteIdea(id, this.keeper))
                    {
                        MessageBox.Show("Пост удален!");
                    }
                    else MessageBox.Show("Пост не найден!");
                }
                else MessageBox.Show("Недостаточно прав!");
            }
            refreshTable(dGVUserPosts);
        }

        private void MakeAdmin_Click(object sender, EventArgs e)
        {
            if (this.userIsModer && !this.keeperIsModer)
            {
                Users user = db.Users.Find(this.keeper);
                if (user != null)
                {
                    user.IsModer = true;
                    this.keeperIsModer = true;
                    db.SaveChanges();
                    MessageBox.Show("Пользователю выданы права администратора!");
                    refreshTable(dGVUserPosts);
                }
                else MessageBox.Show("Пользователь не найден!");
            }
            else MessageBox.Show("Недостаточно прав или пользователь уже имеет права админисстратора!");
            
            refreshTable(dGVUserPosts);
        }

        private void TakeAdmin_Click(object sender, EventArgs e)
        {
            if (this.userIsModer && this.keeperIsModer)
            {
                Users user = db.Users.Find(this.keeper);
                if (user != null)
                {
                    user.IsModer = false;
                    this.keeperIsModer = false;
                    db.SaveChanges();
                    MessageBox.Show("Пользователь больше не администратор!");
                    refreshTable(dGVUserPosts);
                }
                else MessageBox.Show("Пользователь не найден!");
            }
            else MessageBox.Show("Пользователь не админ или у вас недостаточно прав!");
            refreshTable(dGVUserPosts);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            UserProfile upr = new UserProfile(this.user, this.userIsModer);
            upr.Show();
            this.Close();
        }

        private void ChangeUserBtn_Click(object sender, EventArgs e)
        {
            UserProfile upr = new UserProfile(this.user, this.userIsModer);
            upr.Show();
            this.Close();
        }

        private void CheckCommentaryBtn_Click(object sender, EventArgs e)
        {
            if (dGVUserPosts.CurrentCell != null)
            {
                int id = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_idea"].Value);
                Idea idea = db.Idea.Find(id);
                string newName = idea.Name;
                string newType = idea.Type;
                string newDescr = idea.Description;
                bool isfree = idea.IsFree.Value;

                OpenIdeaForm openIdea = new OpenIdeaForm(id, this.user, this.keeper, this.userIsModer, newName, newType, newDescr, isfree);
                this.Close();
                openIdea.Show();
                refreshTable(dGVUserPosts);
            }
        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            if (SearchName.Text != "")
            {
                string search = SearchName.Text;

                string ask = "SELECT distinct * " +
                    "From Idea, Users Where ID_idea in" +
                    " (SELECT Idea.ID_idea From " +
                    "(Post Inner Join Idea On Post.ID_idea = Idea.ID_idea) " +
                    "Where Post.ID_user = " + this.keeper + " " +
                    "AND " +
                    "Users.ID_user = " + this.keeper + ") " +
                    "AND " +
                    "Idea.Name Like '%" + search + "%';";

                DataTable table = new DataTable();

                table = GetData(ask);

                dGVUserPosts.DataSource = table;
                refreshSearch(dGVUserPosts);
            }
            else
            {
                dGVUserPosts.DataSource = GetPosts();
                refreshTable(dGVUserPosts);
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refreshTable(dGVUserPosts);
        }
    }
}
