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
    public partial class Form2 : Form
    {
        Question[] QuestionForm2;
        int index;
        public Form2(Question[] QuestionForm, int Num)
        {
            InitializeComponent();
            QuestionForm2 = QuestionForm;
            index = Num;
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            labelDoctor.Text = QuestionForm2[index].GetDoctor().Info();
            labelPatient.Text = QuestionForm2[index].GetPatient().Info();
            if (QuestionForm2[index].GetQuestions(0) != "")
            {
                this.groupBox1.Visible = true;
                this.label1.Visible = true;
                this.label1.Text = QuestionForm2[index].GetQuestions(0);
            }
            if (QuestionForm2[index].GetQuestions(1) != "")
            {
                this.groupBox2.Visible = true;
                this.label2.Visible = true;
                this.label2.Text = QuestionForm2[index].GetQuestions(1);
            }
            if (QuestionForm2[index].GetQuestions(2) != "")
            {
                this.groupBox3.Visible = true;
                this.label3.Visible = true;
                this.label3.Text = QuestionForm2[index].GetQuestions(2);
            }
            if (QuestionForm2[index].GetQuestions(3) != "")
            {
                this.groupBox4.Visible = true;
                this.label4.Visible = true;
                this.label4.Text = QuestionForm2[index].GetQuestions(3);
            }
            if (QuestionForm2[index].GetQuestions(4) != "")
            {
                this.groupBox5.Visible = true;
                this.label5.Visible = true;
                this.label5.Text = QuestionForm2[index].GetQuestions(4);
            }
            if (QuestionForm2[index].GetQuestions(5) != "")
            {
                this.groupBox6.Visible = true;
                this.label6.Visible = true;
                this.label6.Text = QuestionForm2[index].GetQuestions(5);
            }
            if (QuestionForm2[index].GetQuestions(6) != "")
            {
                this.groupBox7.Visible = true;
                this.label7.Visible = true;
                this.label7.Text = QuestionForm2[index].GetQuestions(6);
            }
            if (QuestionForm2[index].GetQuestions(7) != "")
            {
                this.groupBox8.Visible = true;
                this.label8.Visible = true;
                this.label8.Text = QuestionForm2[index].GetQuestions(7);
            }
            if (QuestionForm2[index].GetQuestions(8) != "")
            {
                this.groupBox9.Visible = true;
                this.label9.Visible = true;
                this.label9.Text = QuestionForm2[index].GetQuestions(8);
            }
            if (QuestionForm2[index].GetQuestions(9) != "")
            {
                this.groupBox10.Visible = true;
                this.label10.Visible = true;
                this.label10.Text = QuestionForm2[index].GetQuestions(9);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Flag = 1;
            if (this.groupBox1.Visible == true)
            {
                if (this.radioButton1.Checked == false && this.radioButton2.Checked == false)
                    Flag = 0;
            }
            if (this.groupBox2.Visible == true)
            {
                if (this.radioButton3.Checked == false && this.radioButton4.Checked == false)
                    Flag = 0;
            }
            if (this.groupBox3.Visible == true)
            {
                if (this.radioButton5.Checked == false && this.radioButton6.Checked == false)
                    Flag = 0;
            }
            if (this.groupBox4.Visible == true)
            {
                if (this.radioButton7.Checked == false && this.radioButton8.Checked == false)
                    Flag = 0;
            }
            if (this.groupBox5.Visible == true)
            {
                if (this.radioButton9.Checked == false && this.radioButton10.Checked == false)
                    Flag = 0;
            }
            if (this.groupBox6.Visible == true)
            {
                if (this.radioButton11.Checked == false && this.radioButton12.Checked == false)
                    Flag = 0;
            }
            if (this.groupBox7.Visible == true)
            {
                if (this.radioButton13.Checked == false && this.radioButton14.Checked == false)
                    Flag = 0;
            }
            if (this.groupBox8.Visible == true)
            {
                if (this.radioButton15.Checked == false && this.radioButton16.Checked == false)
                    Flag = 0;
            }
            if (this.groupBox9.Visible == true)
            {
                if (this.radioButton17.Checked == false && this.radioButton18.Checked == false)
                    Flag = 0;
            }
            if (this.groupBox10.Visible == true)
            {
                if (this.radioButton19.Checked == false && this.radioButton20.Checked == false)
                    Flag = 0;
            }
            if (Flag == 0)
            {
                MessageBox.Show("Вы не полностью заполнили опрос!", "Error");
            }
            else
            {
                int[] MasForAnswers = new int[10];
                int length = 0;
                if (this.groupBox1.Visible == true)
                {
                    if (this.radioButton2.Checked == true)
                        MasForAnswers[0] = 1;
                    if (this.radioButton1.Checked == true)
                        MasForAnswers[0] = 0;
                    length++;
                }
                if (this.groupBox2.Visible == true)
                {
                    if (this.radioButton4.Checked == true)
                        MasForAnswers[1] = 1;
                    if (this.radioButton3.Checked == true)
                        MasForAnswers[1] = 0;
                    length++;
                }
                if (this.groupBox3.Visible == true)
                {
                    if (this.radioButton6.Checked == true)
                        MasForAnswers[2] = 1;
                    if (this.radioButton5.Checked == true)
                        MasForAnswers[2] = 0;
                    length++;
                }
                if (this.groupBox4.Visible == true)
                {
                    if (this.radioButton8.Checked == true)
                        MasForAnswers[3] = 1;
                    if (this.radioButton7.Checked == true)
                        MasForAnswers[3] = 0;
                    length++;
                }
                if (this.groupBox5.Visible == true)
                {
                    if (this.radioButton10.Checked == true)
                        MasForAnswers[4] = 1;
                    if (this.radioButton9.Checked == true)
                        MasForAnswers[4] = 0;
                    length++;
                }
                if (this.groupBox6.Visible == true)
                {
                    if (this.radioButton12.Checked == true)
                        MasForAnswers[5] = 1;
                    if (this.radioButton11.Checked == true)
                        MasForAnswers[5] = 0;
                    length++;
                }
                if (this.groupBox7.Visible == true)
                {
                    if (this.radioButton14.Checked == true)
                        MasForAnswers[6] = 1;
                    if (this.radioButton13.Checked == true)
                        MasForAnswers[6] = 0;
                    length++;
                }
                if (this.groupBox8.Visible == true)
                {
                    if (this.radioButton16.Checked == true)
                        MasForAnswers[7] = 1;
                    if (this.radioButton15.Checked == true)
                        MasForAnswers[7] = 0;
                    length++;
                }
                if (this.groupBox9.Visible == true)
                {
                    if (this.radioButton18.Checked == true)
                        MasForAnswers[8] = 1;
                    if (this.radioButton17.Checked == true)
                        MasForAnswers[8] = 0;
                    length++;
                }
                if (this.groupBox10.Visible == true)
                {
                    if (this.radioButton20.Checked == true)
                        MasForAnswers[9] = 1;
                    if (this.radioButton19.Checked == true)
                        MasForAnswers[9] = 0;
                    length++;
                }
                QuestionForm2[index].SetAnswers(MasForAnswers, length);
                string FilePath = "";
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    FilePath = folderBrowserDialog1.SelectedPath;
                }
                QuestionForm2[index].SaveQuestion(FilePath);
                this.Visible = false;
            }
        }
    }
}
