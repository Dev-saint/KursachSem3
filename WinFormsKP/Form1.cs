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
            //DoctorMas[0] = new Doctor("Сергеев", "Юрий", "Владимирович", "Терапевт");
            //DoctorMas[1] = new Doctor("Буянов", "Виталий", "Юрьевич", "Психиатр");
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
                form2.Show(); 
            }
        }
        public void QuestionPool()
        {
            DirectoryInfo x = new DirectoryInfo(Directory.GetCurrentDirectory());
            FileInfo[] files = x.GetFiles("Опрос_*.txt");

            //string[] QuestionMas1 = new string[10];
            for (int j = 0; j < 10 && j < files.Length; j++) 
            {
                Question1[j] = new Question();
                Question1[j].ReadQuiz(files[j].FullName);
            }
            /*QuestionMas1[0] = "Вы пьете достаточное количество чистой воды?";
            QuestionMas1[1] = "Бывают ли у вас перепады настроения?";
            QuestionMas1[2] = "Вы можете отметить ухудшение самочувствия за последние месяцы/годы?";
            QuestionMas1[3] = "У вас есть режим питания?";
            QuestionMas1[4] = "Вы контролируете уровень потребляемого сахара?";
            QuestionMas1[5] = "Вы пренебрегаете питательными завтраками для себя?";
            QuestionMas1[6] = "Вы поддерживаете физическую активность?";
            QuestionMas1[7] = "Вы предпочитаете проводить время пассивно?";
            QuestionMas1[8] = "Вы сдаете анализы и следите за уровнем гормонов, витаминов, минералов и т.д.?";
            QuestionMas1[9] = "Вы спите в проветриваемом помещении?";

            string[] QuestionMas2 = new string[10];
            for (int i = 0; i < 10; i++)
            {
                QuestionMas2[i] = "";
            }

            QuestionMas2[0] = "Бывают ли у вас перепады настроения?";
            QuestionMas2[1] = "Вы испытываете чувство удовлетворенности собственной жизнью?";
            QuestionMas2[2] = "У вас есть нереализованные желания и амбиции, подавляющие вас?";
            QuestionMas2[3] = "У вас есть достижения и успехи, которыми вы можете гордиться?";
            QuestionMas2[4] = "Самочувствие мешает вам в достижении целей?";
            QuestionMas2[5] = "Вы часто испытываете неуверенность в себе при общении с другими людьми?";
            QuestionMas2[6] = "Чувствуете ли вы прилив сил после пробуждения?";
            QuestionMas2[7] = "У вас есть хобби или ритуалы, наполняющие вас энергией?";
            //QuestionMas2[8] = "9";
            //QuestionMas2[9] = "10";

            Question1[0] = new Question();
            Question1[1] = new Question();

            Question1[0].SetQuestions(QuestionMas1, 10);
            Question1[1].SetQuestions(QuestionMas2, 10);*/
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form3 main = this.Owner as Form3;
            main.Visible = true;
        }
    }
}
