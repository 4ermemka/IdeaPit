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
    public partial class ChangeUserInfoForm : Form
    {
        public int user;
        public bool ismoder;
        public bool checkNum(string num)
        {
            for (int i = 0; i < num.Length; i++) if (num[i] < '0' || num[i] > '9') return false;
            return true;
        }
        public ChangeUserInfoForm()
        {
            InitializeComponent();

            bioField.Text = "О себе";
            bioField.ForeColor = Color.Gray;

        }

        public ChangeUserInfoForm(int id_user, bool moder)
        {
            InitializeComponent();

            this.user = id_user;
            this.ismoder = moder;

            string ask = "SELECT * FROM Users WHERE ID_user = \'" + this.user + "\'";

            DataTable ds = new DataTable();

            ds = GetData(ask);

            int num = ds.Rows[0].Field<int>("ID_user");
            String UserName = ds.Rows[0].Field<String>("UserName");
            DateTime birthdate = ds.Rows[0].Field<DateTime>("BirthDate");
            String PhoneNum = ds.Rows[0].Field<String>("PhoneNumber");
            String BIO = ds.Rows[0].Field<String>("UserBio");

            LoginField.Text = UserName;
            PhoneField.Text = PhoneNum;
            bDateField.Value = birthdate;

            bioField.Text = BIO;
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

        private void EnterButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        UserContext db = new UserContext();

        private void RegButton_Click(object sender, EventArgs e)
        {
            String passwordUser = PasswordField.Text;
            String passwordRepUser = RepPassField.Text;
            String Phone = PhoneField.Text;
            DateTime bDate = bDateField.Value;
            String bio = bioField.Text;

            Users usr = db.Users.Find(this.user);
            if (usr != null)
            { 
                if (bDate < DateTime.Today.Date)
                {
                    if (passwordUser != "")
                    {
                        if (passwordUser == passwordRepUser)
                        {
                            if (checkNum(Phone))
                            {
                                usr.Password = passwordUser;
                                usr.PhoneNumber = Phone;
                                usr.BirthDate = bDate;
                                usr.UserBIO = bio;
                                db.SaveChanges();
                                MessageBox.Show("Пароль обновлен, данные о пользователе обновлены!");
                            }
                            else MessageBox.Show("Телефон содержит недопустимые символы!");
                        }
                        else MessageBox.Show("Пароли не совпадают, данные не сохранены!!");
                    }
                    else
                    {
                        if (checkNum(Phone))
                        {
                            usr.PhoneNumber = Phone;
                            usr.BirthDate = bDate;
                            usr.UserBIO = bio;
                            db.SaveChanges();
                            MessageBox.Show("Данные о профиле изменены!");
                        }
                        else MessageBox.Show("Телефон содержит недопустимые символы!");
                    }
                }
                else MessageBox.Show("Ошибка! Вы еще не родились! Отказано в редактировании!");
            }
            else MessageBox.Show("Пользователь не найден!");
            this.Close();
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
