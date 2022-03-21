using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsKP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void ButtonPatient_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Owner = this;
            Visible = false;
            form1.Show();
        }

        private void ButtonAdmin_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "biba")
            {
                Form4 form4 = new Form4();
                form4.Owner = this;
                Visible = false;
                form4.Show();
            }
            else
            {
                MessageBox.Show("Вы ввели неверный пароль!", "Доступ запрещен");
            }
        }
    }
}
