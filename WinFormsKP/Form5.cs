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
    public partial class Form5 : Form
    {
        Question quest = new Question();
        Doctor doc = new Doctor();
        string[] QuestionMas = new string[10];
        int count = 0, i = 0;

        public Form5()
        {
            InitializeComponent();
        }

        private void ButtonInputQuestions_Click(object sender, EventArgs e)
        {
            if (TextBoxSurnameDoctor.TextLength == 0 || TextBoxNameDoctor.TextLength == 0 || TextBoxPatronymicDoctor.TextLength == 0 || TextBoxSpecialization.TextLength == 0 || TextBoxQuestCount.TextLength == 0)
            {
                MessageBox.Show("Вы ввели не все данные!", "Error");
            }
            else
            if (Convert.ToInt32(TextBoxQuestCount.Text) > 10)
            {
                MessageBox.Show("Количество вопросов не может превышать 10!", "Error");
            }
            else
            {
                LabelFIODoctor.Visible = false;
                LabelSurnameDoctor.Visible = false;
                LabelNameDoctor.Visible = false;
                LabelPatronymicDoctor.Visible = false;
                LabelSpecialization.Visible = false;
                LabelQuestCount.Visible = false;
                TextBoxSurnameDoctor.Visible = false;
                TextBoxNameDoctor.Visible = false;
                TextBoxPatronymicDoctor.Visible = false;
                TextBoxSpecialization.Visible = false;
                TextBoxQuestCount.Visible = false;
                ButtonInputQuestions.Visible = false;
                LabelInputQuestion.Visible = true;
                TextBoxQuestion.Visible = true;
                ButtonComplete.Visible = true;
                ButtonNextQuestion.Visible = true;
                doc.Set(TextBoxSurnameDoctor.Text, TextBoxNameDoctor.Text, TextBoxPatronymicDoctor.Text, TextBoxSpecialization.Text);
                count = Convert.ToInt32(TextBoxQuestCount.Text);
            }
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form4 main = this.Owner as Form4;
            main.Visible = true;
        }

        private void ButtonComplete_Click(object sender, EventArgs e)
        {
            if (TextBoxQuestion.TextLength != 0)
            {
                QuestionMas[i] = TextBoxQuestion.Text;
                i++;
            }

            quest.SetQuestions(QuestionMas, i);
            quest.SetDoctor(doc);
            string FilePath = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = folderBrowserDialog1.SelectedPath;
                ButtonComplete.Visible = false;
                TextBoxQuestion.Visible = false;
                LabelInputQuestion.Visible = false;
                LabelFIODoctor.Visible = true;
                LabelSurnameDoctor.Visible = true;
                LabelNameDoctor.Visible = true;
                LabelPatronymicDoctor.Visible = true;
                LabelSpecialization.Visible = true;
                LabelQuestCount.Visible = true;
                TextBoxSurnameDoctor.Visible = true;
                TextBoxNameDoctor.Visible = true;
                TextBoxPatronymicDoctor.Visible = true;
                TextBoxSpecialization.Visible = true;
                TextBoxQuestCount.Visible = true;
                ButtonInputQuestions.Visible = true;
                TextBoxSurnameDoctor.Text = "";
                TextBoxNameDoctor.Text = "";
                TextBoxPatronymicDoctor.Text = "";
                TextBoxSpecialization.Text = "";
                TextBoxQuestCount.Text = "";
            }
            quest.SaveQuiz(FilePath, i);
        }

        private void ButtonNextQuestion_Click(object sender, EventArgs e)
        {
            if (TextBoxQuestion.TextLength == 0)
            {
                MessageBox.Show("Пустое поле вопроса! Введите вопрос.", "Error");
            }
            else
            {
                QuestionMas[i] = TextBoxQuestion.Text;
                i++;
                if (i == (count - 1))
                {
                    ButtonNextQuestion.Visible = false;
                }
                LabelInputQuestion.Text = "Введите вопрос №" + (i + 1);
                TextBoxQuestion.Text = "";
            }
        }
    }
}
