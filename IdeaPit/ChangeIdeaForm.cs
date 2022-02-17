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
    public partial class ChangeIdeaForm : Form
    {
        private int user;
        private int idea;
        public ChangeIdeaForm()
        {
            InitializeComponent();
            ControlBox = false; // отключаются кнопки на заголовке
        }

        public ChangeIdeaForm(int id_user, int id_idea)
        {
            InitializeComponent();
            this.user = id_user;
            this.idea = id_idea;
            ControlBox = false; // отключаются кнопки на заголовке
        }
        public ChangeIdeaForm(int id_idea,int id_user,string newName, string newType, string newDescr, bool isfree)
        {
            InitializeComponent();
            this.user = id_user;
            this.idea = id_idea;
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

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            PostsDB pdb = new PostsDB(this.user);
            pdb.UpdateIdea(this.idea, NameField.Text, DescriptionField.Text, TypeField.Text, CheckFreeBox.Checked);
            this.Hide();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
