using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSU
{
    public partial class Title : Form
    {
        public Title()
        {
            InitializeComponent();
        }
        Menu form2;
        int flag = 0;
        private readonly string[] _passwords = new string[]
        {
            "superAdmin","admin1234","qwerty1234"
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.button1, "INPUT PASSWORD");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if (_passwords.Contains(str))
            {
                string _root = "root";
                string _admin = "admin";    
                textBox1.Clear();
                flag = 1;
                int lenth = str.Length;
                if (str.Contains(_admin)) flag = 2;
                if (str.Contains(_root)) flag = 3;
                form2 = new Menu(flag);
                form2.Show();

            }
            else
            {
                MessageBox.Show("Invalid password", "Authenthefication");
                textBox1.Clear();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
