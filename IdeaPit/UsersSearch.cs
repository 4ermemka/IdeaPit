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
    public partial class UsersSearch : Form
    {
        bool isModer;
        private int user;
        public UsersSearch()
        {
            InitializeComponent();
            PrUserName.Text = "Ноунейм";
        }

        UserContext db = new UserContext();
        public UsersSearch(int user_id, bool ismoder)
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
            string ask = "SELECT distinct * From Users";

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
            if (SearchName.Text != "")
            {
                string search = SearchName.Text;

                string ask = "SELECT distinct * " +
                    "From Users where " +
                    "UserName Like '%" + search + "%';";

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
            dGVUserPosts.Columns[1].HeaderText = "Ник"; dGVUserPosts.Columns[1].Width = 150; dGVUserPosts.Columns[1].ReadOnly = true;
            dGVUserPosts.Columns[2].HeaderText = "Дата рождения"; dGVUserPosts.Columns[2].Width = 80; dGVUserPosts.Columns[2].ReadOnly = true;
            dGVUserPosts.Columns[3].HeaderText = "О себе"; dGVUserPosts.Columns[3].Width = 450; dGVUserPosts.Columns[3].ReadOnly = true;
            dGVUserPosts.Columns[4].HeaderText = "Количество публикаций"; dGVUserPosts.Columns[4].Width = 100; dGVUserPosts.Columns[4].ReadOnly = true;
            dGVUserPosts.Columns[5].HeaderText = "Рейтинг"; dGVUserPosts.Columns[5].Width = 60; dGVUserPosts.Columns[5].ReadOnly = true;
            dGVUserPosts.Columns[6].HeaderText = "Админ"; dGVUserPosts.Columns[6].Width = 60; dGVUserPosts.Columns[6].ReadOnly = true;
            dGVUserPosts.Columns[7].HeaderText = "Телефон"; dGVUserPosts.Columns[7].Width = 120; dGVUserPosts.Columns[7].ReadOnly = true;
            dGVUserPosts.Columns[8].Visible = false;
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
            dGVUserPosts.Columns[1].HeaderText = "Ник"; dGVUserPosts.Columns[1].Width = 150; dGVUserPosts.Columns[1].ReadOnly = true;
            dGVUserPosts.Columns[2].HeaderText = "Дата рождения"; dGVUserPosts.Columns[2].Width = 80; dGVUserPosts.Columns[2].ReadOnly = true;
            dGVUserPosts.Columns[3].HeaderText = "О себе"; dGVUserPosts.Columns[3].Width = 450; dGVUserPosts.Columns[3].ReadOnly = true;
            dGVUserPosts.Columns[4].HeaderText = "Количество публикаций"; dGVUserPosts.Columns[4].Width = 100; dGVUserPosts.Columns[4].ReadOnly = true;
            dGVUserPosts.Columns[5].HeaderText = "Рейтинг"; dGVUserPosts.Columns[5].Width = 60; dGVUserPosts.Columns[5].ReadOnly = true;
            dGVUserPosts.Columns[6].HeaderText = "Админ"; dGVUserPosts.Columns[6].Width = 60; dGVUserPosts.Columns[6].ReadOnly = true;
            dGVUserPosts.Columns[7].HeaderText = "Телефон"; dGVUserPosts.Columns[7].Width = 120; dGVUserPosts.Columns[7].ReadOnly = true;
            dGVUserPosts.Columns[8].Visible = false;

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
    }
}
