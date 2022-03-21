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
    public partial class Form1 : Form
    {
        static int ID = 0;
        Patient Patient1 = new Patient();
        Doctor[] DoctorMas = new Doctor[10];
        Doctor DoctorSelect = new Doctor();
        static Question[] Question1 = new Question[10];
        Question quest = new Question();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DirectoryInfo x = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] files = x.GetFiles("Опрос_*.txt");
 
            for (int j = 0; j < files.Length; j++)
            {
                DoctorMas[j] = new Doctor();
                DoctorMas[j].ReadDoctor(files[j].FullName);
                this.ComboBoxSelectDoctor.Items.AddRange(new string[] { DoctorMas[j].GetSpecialization() + ": " + DoctorMas[j].GetSurname() 
                    + " " + DoctorMas[j].GetName() + " " + DoctorMas[j].GetPatronymic() });
            }
        }

        private void ComboBoxSelectDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = ComboBoxSelectDoctor.SelectedItem.ToString();
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

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (TextBoxSurnamePatient.TextLength == 0 || TextBoxNamePatient.TextLength == 0 || TextBoxPatronymicPatient.TextLength == 0 || DoctorSelect.GetSpecialization() == "")
            {
                MessageBox.Show("Вы ввели не все данные!", "Error");
            }
            else
            {
                Patient1.Set(TextBoxSurnamePatient.Text, TextBoxNamePatient.Text, TextBoxPatronymicPatient.Text);
                QuestionPool();
                Question1[ID].SetDoctor(DoctorSelect);
                Question1[ID].SetPatient(Patient1);
                Form2 form2 = new Form2(Question1, ID);
                form2.Owner = this;
                Visible = false;
                form2.Show(); 
            }
        }
        public void QuestionPool()
        {
            DirectoryInfo x = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] files = x.GetFiles("Опрос_*.txt");

            for (int j = 0; j < 10 && j < files.Length; j++) 
            {
                Question1[j] = new Question();
                Question1[j].ReadQuiz(files[j].FullName);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 main = this.Owner as Form3;
            main.Visible = true;
        }
    }
}
