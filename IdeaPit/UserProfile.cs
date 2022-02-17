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
    public partial class UserProfile : Form
    {
        bool isModer;
        private int user;
        public UserProfile()
        {
            InitializeComponent();
            PrUserName.Text = "Ноунейм";
        }

        UserContext db = new UserContext();
        public UserProfile(int user_id, bool ismoder)
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
            string ask = "SELECT distinct * " +
                "From Idea,Users Where ID_idea in " +
                "(SELECT Idea.ID_idea From(Post Inner Join Idea On Post.ID_idea = Idea.ID_idea) Where Post.ID_user = \'" + this.user.ToString() + "\' AND Users.ID_user =\'" + this.user.ToString() + "\');";

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
            Application.Exit();
        }

        PostsDB posts = new PostsDB();

        private void NewPostBtn_Click(object sender, EventArgs e)
        {
            NewIdeaForm changeIdea = new NewIdeaForm(this.user);
            changeIdea.Show();
            refreshTable(dGVUserPosts);
        }

        private void SearchName_TextChanged(object sender, EventArgs e)
        {
            if (SearchName.Text != "" || SearchType.Text != "")
            {
                string searchName = SearchName.Text;
                string searchType = SearchType.Text;

                string ask = "SELECT distinct * " +
                    "From Idea, Users Where ID_idea in" +
                    " (SELECT Idea.ID_idea From " +
                    "(Post Inner Join Idea On Post.ID_idea = Idea.ID_idea) " +
                    "Where Post.ID_user = " + this.user + " " +
                    "AND " +
                    "Users.ID_user = " + this.user + ") " +
                    "AND " +
                    "Idea.Name Like '%" + searchName + "%' AND Idea.Type Like '%" + searchType + "%';";

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
            if (SearchName.Text != "" || SearchType.Text != "")
            {
                string searchName = SearchName.Text;
                string searchType = SearchType.Text;

                string ask = "SELECT distinct * " +
                    "From Idea, Users Where ID_idea in" +
                    " (SELECT Idea.ID_idea From " +
                    "(Post Inner Join Idea On Post.ID_idea = Idea.ID_idea) " +
                    "Where Post.ID_user = " + this.user + " " +
                    "AND " +
                    "Users.ID_user = " + this.user + ") " +
                    "AND " +
                    "Idea.Name Like '%" + searchName + "%' AND Idea.Type Like '%" + searchType + "%';";

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

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (dGVUserPosts.CurrentCell != null)
            {
                int id = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_idea"].Value);

                if (posts.DeleteIdea(id, this.user))
                {
                    Users us = db.Users.Find(this.user);
                    us.PubCount--;
                    db.SaveChanges();
                    MessageBox.Show("Пост удален!");
                }
                else MessageBox.Show("Пост не найден!");
            }
            refreshTable(dGVUserPosts);
        }

        private void ChangeBtn_Click(object sender, EventArgs e)
        {
            if (dGVUserPosts.CurrentCell != null)
            {
                int id = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_idea"].Value);
                Idea idea = db.Idea.Find(id);
                //int id_user = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_user"].Value);
                string newName = idea.Name;
                string newType = idea.Type;
                string newDescr = idea.Description;
                bool isfree = idea.IsFree.Value;

                ChangeIdeaForm changeIdea = new ChangeIdeaForm(id,this.user,newName, newType, newDescr, isfree);
                changeIdea.Show();
                refreshTable(dGVUserPosts);
            }
        }

        public void refreshSearch(DataGridView dGVUserPosts)
        {
            dGVUserPosts.Columns[0].Visible = false;
            dGVUserPosts.Columns[1].HeaderText = "Название"; dGVUserPosts.Columns[1].Width = 150; dGVUserPosts.Columns[1].ReadOnly = true;
            dGVUserPosts.Columns[2].HeaderText = "Описание"; dGVUserPosts.Columns[2].Width = 450; dGVUserPosts.Columns[2].ReadOnly = true;
            dGVUserPosts.Columns[3].HeaderText = "Тип"; dGVUserPosts.Columns[3].Width = 150; dGVUserPosts.Columns[3].ReadOnly = true;
            dGVUserPosts.Columns[4].HeaderText = "Дата публикации"; dGVUserPosts.Columns[4].Width = 150; dGVUserPosts.Columns[4].ReadOnly = true;
            dGVUserPosts.Columns[5].Visible = false;
            dGVUserPosts.Columns[6].HeaderText = "Бесплатно"; dGVUserPosts.Columns[6].Width = 150; dGVUserPosts.Columns[6].ReadOnly = true;
            for (int i = 7; i < dGVUserPosts.Columns.Count; i++)
            {
                dGVUserPosts.Columns[i].Visible = false;
            }
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
            dGVUserPosts.Columns[3].HeaderText = "Тип"; dGVUserPosts.Columns[3].Width = 150; dGVUserPosts.Columns[3].ReadOnly = true;
            dGVUserPosts.Columns[4].HeaderText = "Дата публикации"; dGVUserPosts.Columns[4].Width = 150; dGVUserPosts.Columns[4].ReadOnly = true;
            dGVUserPosts.Columns[5].Visible = false;
            dGVUserPosts.Columns[6].HeaderText = "Бесплатно"; dGVUserPosts.Columns[6].Width = 150; dGVUserPosts.Columns[6].ReadOnly = true;
            for (int i = 7; i < dGVUserPosts.Columns.Count; i++)
            {
                dGVUserPosts.Columns[i].Visible = false;
            }
            if (this.isModer)
            {
                AdminIndicatorUser.Checked = true;
            }
            string ask = "SELECT * FROM Users WHERE ID_user = \'" + this.user + "\'";

            DataTable ds = new DataTable();

            ds = GetData(ask);

            String UserName = ds.Rows[0].Field<String>("UserName");
            String PhoneNum = ds.Rows[0].Field<String>("PhoneNumber");

            PrUserName.Text = UserName;
            PhoneDisp.Text = "Телефон: " + PhoneNum;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            refreshTable(dGVUserPosts);
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
                int id = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_idea"].Value);
                Idea idea = db.Idea.Find(id);
                //int id_user = Convert.ToInt32(dGVUserPosts.CurrentRow.Cells["ID_user"].Value);
                string newName = idea.Name;
                string newType = idea.Type;
                string newDescr = idea.Description;
                bool isfree = idea.IsFree.Value;

                OpenIdeaForm openIdea = new OpenIdeaForm(id, this.user,this.user, this.isModer, newName, newType, newDescr, isfree);
                //TestForm f = new TestForm();
                openIdea.Show();
                this.Close();
                //changeIdea.Show();
                refreshTable(dGVUserPosts);
            }
        }

        private void UserFindBtn_Click(object sender, EventArgs e)
        {
            UsersSearch usr = new UsersSearch(this.user,this.isModer);
            usr.Show();
            this.Close();
        }

        private void IdeaFindBtn_Click(object sender, EventArgs e)
        {
            IdeaSearch usr = new IdeaSearch(this.user, this.isModer);
            usr.Show();
            this.Close();
        }

        private void UserInfoChangeBtn_Click(object sender, EventArgs e)
        {
            ChangeUserInfoForm infch = new ChangeUserInfoForm(this.user, this.isModer);
            infch.Show();
            //this.Close();
        }
    }
}
