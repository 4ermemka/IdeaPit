using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdeaPit
{
    public partial class NewIdeaForm : Form
    {
        private int user;
        public NewIdeaForm()
        {
            InitializeComponent();
            ControlBox = false; // отключаются кнопки на заголовке
        }

        public NewIdeaForm(int id_user)
        {
            InitializeComponent();
            this.user = id_user;
            ControlBox = false; // отключаются кнопки на заголовке
        }
        public NewIdeaForm(string newName, string newType, string newDescr, bool isfree)
        {
            InitializeComponent();
            NameField.Text = newName;
            TypeField.Text = newType;
            DescriptionField.Text = newDescr;
            CheckFreeBox.Checked = isfree;
            ControlBox = false;
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
        UserContext db = new UserContext();
        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            PostsDB pdb = new PostsDB(this.user);
            pdb.newIdea(NameField.Text,DescriptionField.Text,TypeField.Text,CheckFreeBox.Checked);
            Users us = db.Users.Find(this.user);
            us.PubCount++;
            db.SaveChanges();
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

