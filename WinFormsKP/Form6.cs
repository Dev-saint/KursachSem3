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
    public partial class Form6 : Form
    {
        Question[] QuestionForm2;
        int index;
        public Form6()
        {
            InitializeComponent();
        }

        public Form6(Question[] QuestionForm, int Num)
        {
            InitializeComponent();
            QuestionForm2 = QuestionForm;
            index = Num;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            LabelDoctor.Text = QuestionForm2[index].GetDoctor().Info();
            if (QuestionForm2[index].GetQuestions(0) != "")
            {
                this.label1.Visible = true;
                this.textBox1.Visible = true;
                this.label1.Text = QuestionForm2[index].GetQuestions(0);
            }
            if (QuestionForm2[index].GetQuestions(1) != "")
            {
                this.label2.Visible = true;
                this.textBox2.Visible = true;
                this.label2.Text = QuestionForm2[index].GetQuestions(1);
            }
            if (QuestionForm2[index].GetQuestions(2) != "")
            {
                this.label3.Visible = true;
                this.textBox3.Visible = true;
                this.label3.Text = QuestionForm2[index].GetQuestions(2);
            }
            if (QuestionForm2[index].GetQuestions(3) != "")
            {
                this.label4.Visible = true;
                this.textBox4.Visible = true;
                this.label4.Text = QuestionForm2[index].GetQuestions(3);
            }
            if (QuestionForm2[index].GetQuestions(4) != "")
            {
                this.label5.Visible = true;
                this.textBox5.Visible = true;
                this.label5.Text = QuestionForm2[index].GetQuestions(4);
            }
            if (QuestionForm2[index].GetQuestions(5) != "")
            {
                this.buttonNext.Visible = true;
                this.label6.Text = QuestionForm2[index].GetQuestions(5);
            }
            if (QuestionForm2[index].GetQuestions(6) != "")
            {
                this.label7.Text = QuestionForm2[index].GetQuestions(6);
            }
            if (QuestionForm2[index].GetQuestions(7) != "")
            {
                this.label8.Text = QuestionForm2[index].GetQuestions(7);
            }
            if (QuestionForm2[index].GetQuestions(8) != "")
            {
                this.label9.Text = QuestionForm2[index].GetQuestions(8);
            }
            if (QuestionForm2[index].GetQuestions(9) != "")
            {
                this.label10.Text = QuestionForm2[index].GetQuestions(9);
            }
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form4 main = this.Owner as Form4;
            main.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.buttonNext.Visible = false;
            this.buttonPrev.Visible = true;
            this.label1.Visible = false;
            this.label2.Visible = false;
            this.label3.Visible = false;
            this.label4.Visible = false;
            this.label5.Visible = false;
            this.textBox1.Visible = false;
            this.textBox2.Visible = false;
            this.textBox3.Visible = false;
            this.textBox4.Visible = false;
            this.textBox5.Visible = false;
            if (QuestionForm2[index].GetQuestions(5) != "")
            {
                this.label6.Visible = true;
                this.textBox6.Visible = true;
            }
            if (QuestionForm2[index].GetQuestions(6) != "")
            {
                this.label7.Visible = true;
                this.textBox7.Visible = true;
            }
            if (QuestionForm2[index].GetQuestions(7) != "")
            {
                this.label8.Visible = true;
                this.textBox8.Visible = true;
            }
            if (QuestionForm2[index].GetQuestions(8) != "")
            {
                this.label9.Visible = true;
                this.textBox9.Visible = true;
            }
            if (QuestionForm2[index].GetQuestions(9) != "")
            {
                this.label10.Visible = true;
                this.textBox10.Visible = true;
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            this.buttonPrev.Visible = false;
            this.buttonNext.Visible = true;
            this.label1.Visible = true;
            this.label2.Visible = true;
            this.label3.Visible = true;
            this.label4.Visible = true;
            this.label5.Visible = true;
            this.label6.Visible = false;
            this.label7.Visible = false;
            this.label8.Visible = false;
            this.label9.Visible = false;
            this.label10.Visible = false;
            this.textBox6.Visible = false;
            this.textBox7.Visible = false;
            this.textBox8.Visible = false;
            this.textBox9.Visible = false;
            this.textBox10.Visible = false;
            this.textBox1.Visible = true;
            this.textBox2.Visible = true;
            this.textBox3.Visible = true;
            this.textBox4.Visible = true;
            this.textBox5.Visible = true;
        }

        private void buttonComplete_Click(object sender, EventArgs e)
        {
            string[] quest = new string[10];
            int i = 0;
            if (textBox1.Text != "")
            {
                quest[i] = textBox1.Text;
                i++;
            }
            if (textBox2.Text != "")
            {
                quest[i] = textBox2.Text;
                i++;
            }
            if (textBox3.Text != "")
            {
                quest[i] = textBox3.Text;
                i++;
            }
            if (textBox4.Text != "")
            {
                quest[i] = textBox4.Text;
                i++;
            }
            if (textBox5.Text != "")
            {
                quest[i] = textBox5.Text;
                i++;
            }
            if (textBox6.Text != "")
            {
                quest[i] = textBox6.Text;
                i++;
            }
            if (textBox7.Text != "")
            {
                quest[i] = textBox7.Text;
                i++;
            }
            if (textBox8.Text != "")
            {
                quest[i] = textBox8.Text;
                i++;
            }
            if (textBox9.Text != "")
            {
                quest[i] = textBox9.Text;
                i++;
            }
            if (textBox10.Text != "")
            {
                quest[i] = textBox10.Text;
                i++;
            }

            QuestionForm2[index].SetQuestions(quest, i);

            string FilePath = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                FilePath = folderBrowserDialog1.SelectedPath;
            }

            QuestionForm2[index].SaveQuiz(FilePath, i);
        }
    }
}
