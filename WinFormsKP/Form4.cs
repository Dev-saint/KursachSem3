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
        static int ID = 0;
        Doctor[] DoctorMas = new Doctor[10];
        Doctor DoctorSelect = new Doctor();
        Doctor DoctorSelectDel = new Doctor();
        Question[] Question2 = new Question[10];

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

        private void ComboBoxSelectQuizEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = ComboBoxSelectQuizEdit.SelectedItem.ToString();
            int i = 0;
            while (DoctorMas[i] != null && i < 10)
            {
                if (DoctorMas[i].GetSpecialization() + ": " + DoctorMas[i].GetSurname() + " " + DoctorMas[i].GetName() + " " + DoctorMas[i].GetPatronymic() == selectedState)
                {
                    DoctorSelect = DoctorMas[i];
                    ID = i;
                }
                i++;
            }
        }

        public void QuestionPoolEdit()
        {
            DirectoryInfo x = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] files = x.GetFiles("Опрос_*.txt");

            //string[] QuestionMas1 = new string[10];
            for (int j = 0; j < 10 && j < files.Length; j++)
            {
                Question2[j] = new Question();
                Question2[j].ReadQuiz(files[j].FullName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DoctorSelect.GetSpecialization() == "")
            {
                MessageBox.Show("Вы ввели не все данные!", "Error");
            }
            else
            {
                QuestionPoolEdit();
                Question2[ID].SetDoctor(DoctorSelect);
                Form6 form6 = new Form6(Question2, ID);
                form6.Owner = this;
                Visible = false;
                form6.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DoctorSelectDel.GetSpecialization() == "")
            {
                MessageBox.Show("Вы ввели не все данные!", "Error");
            }
            else
            {
                string Surname;
                Surname = DoctorMas[ID].GetSurname();
                DirectoryInfo x = new DirectoryInfo(Directory.GetCurrentDirectory());
                FileInfo file = x.GetFiles($"Опрос_{Surname}.txt").Single();
                File.Delete(file.FullName);
            }
        }

        private void ComboBoxSelectQuizDelete_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = ComboBoxSelectQuizDelete.SelectedItem.ToString();
            int i = 0;
            while (DoctorMas[i] != null && i < 10)
            {
                if (DoctorMas[i].GetSpecialization() + ": " + DoctorMas[i].GetSurname() + " " + DoctorMas[i].GetName() + " " + DoctorMas[i].GetPatronymic() == selectedState)
                {
                    DoctorSelectDel = DoctorMas[i];
                    ID = i;
                }
                i++;
            }
        }
    }
}
