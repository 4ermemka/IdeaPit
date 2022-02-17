using MySql.Data.MySqlClient;
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
    public partial class RegForm : Form
    {
        public bool checkNum(string num)//поправил
        {
            for (int i = 0; i < num.Length; i++) if (num[i] < '0' || num[i] > '9') return false;
            return true;
        }
        public RegForm()
        {
            InitializeComponent();

            bioField.Text = "О себе";
            bioField.ForeColor = Color.Gray;

        }

        private void IdeaPitLogo_Click(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Close();
            log.Show();
        }

        Point lastPoint;
        private void LoginWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginWindow_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void IdeaPitLogo_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void IdeaPitLogo_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        //UsersContext db = new UsersContext();

        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            LoginForm log = new LoginForm();
            log.Show();
            this.Close();
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            String loginUser = LoginField.Text;
            String passwordUser = PasswordField.Text;
            String passwordRepUser = RepPassField.Text;
            String Phone = PhoneField.Text;
            DateTime bDate = bDateField.Value;
            String bio = bioField.Text;

            if (checkNum(Phone))
            {
                if (bDate < DateTime.Today)
                {
                    if (passwordUser != "")
                    {
                        if (passwordUser == passwordRepUser)
                        {
                            string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Ideas; Integrated Security=True";

                            string ask = "";
                            ask += "SELECT * FROM Users WHERE UserName = \'" + loginUser + "\'";

                            DataTable ds = new DataTable();

                            ds = GetData(ask);

                            if (ds.Rows.Count == 0)
                            {
                                ask = "SELECT * FROM Users";

                                ds = GetData(ask);

                                bool reg = false;
                                using (SqlConnection connection = new SqlConnection(connectionString))
                                {
                                    var command = new SqlCommand("INSERT Into Users Values(@id, @Name, @bDate, @BIO, 0, 0, 0, @Phone, @pass)", connection);
                                    command.Parameters.AddWithValue("@id", ds.Rows.Count + 1);
                                    command.Parameters.AddWithValue("@Name", loginUser);
                                    command.Parameters.AddWithValue("@bDate", bDate);
                                    command.Parameters.AddWithValue("@BIO", bio);
                                    command.Parameters.AddWithValue("@Phone", Phone);
                                    command.Parameters.AddWithValue("@pass", passwordUser);
                                    connection.Open();

                                    command.ExecuteNonQuery();

                                    MessageBox.Show("Успешная регистрация!");
                                    this.Close();
                                    LoginForm login = new LoginForm();
                                    login.Show();
                                }
                            }
                            else MessageBox.Show("Пользователь уже зарегистрирован!");
                        }
                        else MessageBox.Show("Пароли не совпадают!");
                    }
                    else MessageBox.Show("Пароль не может быть пустым!");
                }
                else MessageBox.Show("Ошибка! Вы еще не родились!  Отказано в регистрации!");
            }
            else MessageBox.Show("Телефон содержит недопустимые символы!");
        }

        private void bioField_Enter(object sender, EventArgs e)
        {
            if (bioField.Text == "О себе")
            {
                bioField.Text = "";
                bioField.ForeColor = Color.Black;
            }
        }

        private void bioField_Leave(object sender, EventArgs e)
        {
            if (bioField.Text == "")
            {
                bioField.Text = "О себе";
                bioField.ForeColor = Color.Gray;
            }
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
    }
}
