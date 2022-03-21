using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WinFormsKP
{
    public partial class Form4 : Form
    {
        Doctor[] DoctorMas = new Doctor[10];
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 main = this.Owner as Form3;
            main.Visible = true;
        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Owner = this;
            Visible = false;
            form5.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            DirectoryInfo x = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] files = x.GetFiles("Опрос_*.txt");

            for (int j = 0; j < files.Length; j++)
            {
                DoctorMas[j] = new Doctor();
                DoctorMas[j].ReadDoctor(files[j].FullName);
                this.ComboBoxSelectQuizEdit.Items.AddRange(new string[] { DoctorMas[j].GetSpecialization() + ": " + DoctorMas[j].GetSurname()
                    + " " + DoctorMas[j].GetName() + " " + DoctorMas[j].GetPatronymic() });
                this.ComboBoxSelectQuizDelete.Items.AddRange(new string[] { DoctorMas[j].GetSpecialization() + ": " + DoctorMas[j].GetSurname()
                    + " " + DoctorMas[j].GetName() + " " + DoctorMas[j].GetPatronymic() });
            }
        }
    }
}
