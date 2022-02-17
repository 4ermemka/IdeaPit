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
    public partial class TestForm : Form
    {
        public int a;
        public int num;
        void identy(object sender, EventArgs e)
        {
            num = Convert.ToInt32((sender as Button).Tag);
            string num1 = Convert.ToString(num);
            MessageBox.Show(num1);
        }
        public TestForm()
        {
            InitializeComponent();
        }

        int index;

        private void button1_Click(object sender, EventArgs e)
        {
            CommentPanel.Visible = false;
            CommentPanel.Controls.Clear();
            Panel panel = new Panel();
            for (int i = 0; i < 6; i++)
            {
                panel = CreateMyPanel("Text " + i);
                //panel.Location = new Point((120+15)*i+25, 15);
                panel.Dock = DockStyle.Top;
                panel.AutoSize = true;
                panel.BackColor = Color.DarkCyan;
                // Set the Borderstyle for the Panel to three-dimensional.
                panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

                CommentPanel.Controls.Add(panel);
                CommentPanel.AutoScroll = true;
            }
            CommentPanel.Visible = true;
        }
        public Panel CreateMyPanel(string text)
        {
            Panel panel1 = new Panel();
            TextBox textBox1 = new TextBox();
            Label label1 = new Label();

            // Initialize the Label and TextBox controls.
            label1.Location = new Point(16, 16);
            label1.Text = text;
            label1.Size = new Size(104, 16);
            label1.BackColor = Color.White;
            label1.Dock = DockStyle.Top;
            textBox1.Location = new Point(16, 32);
            textBox1.Text = "";
            textBox1.Size = new Size(152, 20);
            textBox1.Dock = DockStyle.Top;

            // Add the Panel control to the form.
            this.Controls.Add(panel1);
            // Add the Label and TextBox controls to the Panel.
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);

            return panel1;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
    
}
