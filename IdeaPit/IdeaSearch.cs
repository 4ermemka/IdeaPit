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
    public partial class IdeaSearch : Form
    {
        bool isModer;
        private int user;
        public IdeaSearch()
        {
            InitializeComponent();
            PrUserName.Text = "Ноунейм";
        }

        UserContext db = new UserContext();
        public IdeaSearch(int user_id, bool ismoder)
        {
            InitializeComponent();

            this.user = user_id;
            this.isModer = ismoder;

            string ask = "SELECT * FROM Users WHERE ID_user = \'" + this.user + "\'";

            DataTable ds = new DataTable();

            ds = GetData(ask);

            int num = ds.Rows[0].Field<int>("ID_user");
            String UserName = ds.Rows[0].Field<String>("UserName");
            String PhoneNum = ds.Rows[0].Field<String>("PhoneNumber");

            PrUserName.Text = UserName;
            PhoneDisp.Text = "Телефон: " + PhoneNum;

            dGVUserPosts.DataSource = GetPosts();

            refreshTable(dGVUserPosts);
        }

        private DataTable GetPosts()
        {
            string ask = "select Idea.*, " +
                "Users.ID_User, Users.UserName " +
                "from Idea, Users, Post " +
                "where Idea.ID_Idea = Post.ID_Idea AND Post.ID_User = Users.ID_User";

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

        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            if (SearchName.Text != "" || SearchType.Text != "" || SearchAuthor.Text!= "")
            {
                string searchName = SearchName.Text;
                string searchType = SearchType.Text;
                string searchAuthor = SearchAuthor.Text;

                string ask = "select Idea.*, " +
                "Users.ID_User, Users.UserName " +
                "from Idea, Users, Post " +
                "where Idea.ID_Idea = Post.ID_Idea AND Post.ID_User = Users.ID_User AND "+
                "Idea.Name Like '%" + searchName + "%' AND Idea.Type Like '%" + searchType + "%' AND Users.UserName Like '%"+ searchAuthor + "%';";

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

        private void SearchType_TextChanged(object sender, EventArgs e)
        {
            if (SearchName.Text != "" || SearchType.Text != "" || SearchAuthor.Text != "")
            {
                string searchName = SearchName.Text;
                string searchType = SearchType.Text;
                string searchAuthor = SearchAuthor.Text;

                string ask = "select Idea.*, " +
                "Users.ID_User, Users.UserName " +
                "from Idea, Users, Post " +
                "where Idea.ID_Idea = Post.ID_Idea AND Post.ID_User = Users.ID_User AND " +
                "Idea.Name Like '%" + searchName + "%' AND Idea.Type Like '%" + searchType + "%' AND Users.UserName Like '%" + searchAuthor + "%';";

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

        private void SearchAuthor_TextChanged(object sender, EventArgs e)
        {
            if (SearchName.Text != "" || SearchType.Text != "" || SearchAuthor.Text != "")
            {
                string searchName = SearchName.Text;
                string searchType = SearchType.Text;
                string searchAuthor = SearchAuthor.Text;

                string ask = "select Idea.*, " +
                "Users.ID_User, Users.UserName " +
                "from Idea, Users, Post " +
                "where Idea.ID_Idea = Post.ID_Idea AND Post.ID_User = Users.ID_User AND " +
                "Idea.Name Like '%" + searchName + "%' AND Idea.Type Like '%" + searchType + "%' AND Users.UserName Like '%" + searchAuthor + "%';";

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

        public void refreshSearch(DataGridView dGVUserPosts)
        {
            dGVUserPosts.Columns[0].Visible = false;
            dGVUserPosts.Columns[1].HeaderText = "Название"; dGVUserPosts.Columns[1].Width = 150; dGVUserPosts.Columns[1].ReadOnly = true;
            dGVUserPosts.Columns[2].HeaderText = "Описание"; dGVUserPosts.Columns[2].Width = 450; dGVUserPosts.Columns[2].ReadOnly = true;
            dGVUserPosts.Columns[3].HeaderText = "Тип"; dGVUserPosts.Columns[3].Width = 140; dGVUserPosts.Columns[3].ReadOnly = true;
            dGVUserPosts.Columns[4].HeaderText = "Дата публикации"; dGVUserPosts.Columns[4].Width = 140; dGVUserPosts.Columns[4].ReadOnly = true;
            dGVUserPosts.Columns[5].Visible = false;
            dGVUserPosts.Columns[6].HeaderText = "Бесплатно"; dGVUserPosts.Columns[6].Width = 140; dGVUserPosts.Columns[6].ReadOnly = true;
            dGVUserPosts.Columns[7].Visible = false;
            dGVUserPosts.Columns[8].HeaderText = "Автор"; dGVUserPosts.Columns[8].Width = 80; dGVUserPosts.Columns[8].ReadOnly = true;
            
            if (this.isModer)
            {
                AdminIndicatorUser.Checked = true;
            }
        }

        public void refreshTable(DataGridView dGVUserPosts)
        {
            dGVUserPosts.Columns.Clear();
            dGVUserPosts.DataSource = GetPosts();

            dGVUserPosts.Columns[0].Visible = false;
            dGVUserPosts.Columns[1].HeaderText = "Название"; dGVUserPosts.Columns[1].Width = 150; dGVUserPosts.Columns[1].ReadOnly = true;
            dGVUserPosts.Columns[2].HeaderText = "Описание"; dGVUserPosts.Columns[2].Width = 450; dGVUserPosts.Columns[2].ReadOnly = true;
            dGVUserPosts.Columns[3].HeaderText = "Тип"; dGVUserPosts.Columns[3].Width = 140; dGVUserPosts.Columns[3].ReadOnly = true;
            dGVUserPosts.Columns[4].HeaderText = "Дата публикации"; dGVUserPosts.Columns[4].Width = 140; dGVUserPosts.Columns[4].ReadOnly = true;
            dGVUserPosts.Columns[5].Visible = false;
            dGVUserPosts.Columns[6].HeaderText = "Бесплатно"; dGVUserPosts.Columns[6].Width = 140; dGVUserPosts.Columns[6].ReadOnly = true;
            dGVUserPosts.Columns[7].Visible = false;
            dGVUserPosts.Columns[8].HeaderText = "Автор"; dGVUserPosts.Columns[8].Width = 80; dGVUserPosts.Columns[8].ReadOnly = true;

            if (this.isModer)
            {
                AdminIndicatorUser.Checked = true;
            }
        }
        private void ChangeUserBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm log = new LoginForm();
            log.Show();
            refreshTable(dGVUserPosts);
        }

        private void CheckCommentaryBtn_Click(object sender, EventArgs e)
        {
            if (dGVUserPosts.CurrentCell != null)
            {
                int id_keeper = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_user"].Value);
                if (this.user != id_keeper)
                {
                    int id = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_idea"].Value);
                    Idea idea = db.Idea.Find(id);

                    string newName = idea.Name;
                    string newType = idea.Type;
                    string newDescr = idea.Description;
                    bool isfree = idea.IsFree.Value;

                    OpenIdeaForm openIdea = new OpenIdeaForm(id, this.user, id_keeper, this.isModer, newName, newType, newDescr, isfree);

                    openIdea.Show();
                    this.Close();
                }
                else 
                {
                    int id = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_idea"].Value);
                    Idea idea = db.Idea.Find(id);

                    string newName = idea.Name;
                    string newType = idea.Type;
                    string newDescr = idea.Description;
                    bool isfree = idea.IsFree.Value;

                    OpenIdeaForm openIdea = new OpenIdeaForm(id, this.user, this.user, this.isModer, newName, newType, newDescr, isfree);

                    openIdea.Show();
                    this.Close();
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            UserProfile upr = new UserProfile(this.user, this.isModer);
            upr.Show();
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            UserProfile upr = new UserProfile(this.user, this.isModer);
            upr.Show();
            this.Close();
        }

        PostsDB posts = new PostsDB();

        private void NewIdeaBtn_Click(object sender, EventArgs e)
        {
            NewIdeaForm changeIdea = new NewIdeaForm(this.user);
            changeIdea.Show();
            refreshTable(dGVUserPosts);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dGVUserPosts.CurrentCell != null)
            {
                int keeper_id = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_user"].Value);
                int id = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_idea"].Value);
                if (keeper_id == this.user || this.isModer)
                {
                    if (posts.DeleteIdea(id, keeper_id))
                    {
                        Users us = db.Users.Find(keeper_id);
                        us.PubCount--;
                        db.SaveChanges();
                        MessageBox.Show("Пост удален!");
                    }
                    else MessageBox.Show("Пост не найден!");
                }
                else
                {
                    MessageBox.Show("Недостаточно прав для удаления чужих публикаций!");
                }
            }
            refreshTable(dGVUserPosts);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refreshTable(dGVUserPosts);
        }
    }
}
