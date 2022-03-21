
namespace WinFormsKP
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelSurnameDoctor = new System.Windows.Forms.Label();
            this.LabelNameDoctor = new System.Windows.Forms.Label();
            this.LabelPatronymicDoctor = new System.Windows.Forms.Label();
            this.TextBoxSurnameDoctor = new System.Windows.Forms.TextBox();
            this.TextBoxNameDoctor = new System.Windows.Forms.TextBox();
            this.TextBoxPatronymicDoctor = new System.Windows.Forms.TextBox();
            this.TextBoxQuestion = new System.Windows.Forms.TextBox();
            this.LabelFIODoctor = new System.Windows.Forms.Label();
            this.LabelInputQuestion = new System.Windows.Forms.Label();
            this.ButtonInputQuestions = new System.Windows.Forms.Button();
            this.TextBoxSpecialization = new System.Windows.Forms.TextBox();
            this.LabelSpecialization = new System.Windows.Forms.Label();
            this.ButtonNextQuestion = new System.Windows.Forms.Button();
            this.ButtonComplete = new System.Windows.Forms.Button();
            this.LabelQuestCount = new System.Windows.Forms.Label();
            this.TextBoxQuestCount = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // LabelSurnameDoctor
            // 
            this.LabelSurnameDoctor.AutoSize = true;
            this.LabelSurnameDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSurnameDoctor.Location = new System.Drawing.Point(11, 47);
            this.LabelSurnameDoctor.Name = "LabelSurnameDoctor";
            this.LabelSurnameDoctor.Size = new System.Drawing.Size(175, 20);
            this.LabelSurnameDoctor.TabIndex = 0;
            this.LabelSurnameDoctor.Text = "Введите фамилию:";
            // 
            // LabelNameDoctor
            // 
            this.LabelNameDoctor.AutoSize = true;
            this.LabelNameDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNameDoctor.Location = new System.Drawing.Point(12, 76);
            this.LabelNameDoctor.Name = "LabelNameDoctor";
            this.LabelNameDoctor.Size = new System.Drawing.Size(125, 20);
            this.LabelNameDoctor.TabIndex = 1;
            this.LabelNameDoctor.Text = "Введите имя:";
            // 
            // LabelPatronymicDoctor
            // 
            this.LabelPatronymicDoctor.AutoSize = true;
            this.LabelPatronymicDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPatronymicDoctor.Location = new System.Drawing.Point(12, 107);
            this.LabelPatronymicDoctor.Name = "LabelPatronymicDoctor";
            this.LabelPatronymicDoctor.Size = new System.Drawing.Size(172, 20);
            this.LabelPatronymicDoctor.TabIndex = 2;
            this.LabelPatronymicDoctor.Text = "Введите отчество:";
            // 
            // TextBoxSurnameDoctor
            // 
            this.TextBoxSurnameDoctor.Location = new System.Drawing.Point(192, 49);
            this.TextBoxSurnameDoctor.Name = "TextBoxSurnameDoctor";
            this.TextBoxSurnameDoctor.Size = new System.Drawing.Size(130, 20);
            this.TextBoxSurnameDoctor.TabIndex = 3;
            // 
            // TextBoxNameDoctor
            // 
            this.TextBoxNameDoctor.Location = new System.Drawing.Point(192, 78);
            this.TextBoxNameDoctor.Name = "TextBoxNameDoctor";
            this.TextBoxNameDoctor.Size = new System.Drawing.Size(130, 20);
            this.TextBoxNameDoctor.TabIndex = 4;
            // 
            // TextBoxPatronymicDoctor
            // 
            this.TextBoxPatronymicDoctor.Location = new System.Drawing.Point(192, 109);
            this.TextBoxPatronymicDoctor.Name = "TextBoxPatronymicDoctor";
            this.TextBoxPatronymicDoctor.Size = new System.Drawing.Size(130, 20);
            this.TextBoxPatronymicDoctor.TabIndex = 5;
            // 
            // TextBoxQuestion
            // 
            this.TextBoxQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxQuestion.Location = new System.Drawing.Point(12, 130);
            this.TextBoxQuestion.Name = "TextBoxQuestion";
            this.TextBoxQuestion.Size = new System.Drawing.Size(541, 26);
            this.TextBoxQuestion.TabIndex = 6;
            this.TextBoxQuestion.Visible = false;
            // 
            // LabelFIODoctor
            // 
            this.LabelFIODoctor.AutoSize = true;
            this.LabelFIODoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelFIODoctor.Location = new System.Drawing.Point(10, 9);
            this.LabelFIODoctor.Name = "LabelFIODoctor";
            this.LabelFIODoctor.Size = new System.Drawing.Size(238, 25);
            this.LabelFIODoctor.TabIndex = 7;
            this.LabelFIODoctor.Text = "Введите ФИО врача:";
            // 
            // LabelInputQuestion
            // 
            this.LabelInputQuestion.AutoSize = true;
            this.LabelInputQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelInputQuestion.Location = new System.Drawing.Point(188, 82);
            this.LabelInputQuestion.Name = "LabelInputQuestion";
            this.LabelInputQuestion.Size = new System.Drawing.Size(210, 24);
            this.LabelInputQuestion.TabIndex = 8;
            this.LabelInputQuestion.Text = "Введите вопрос №1";
            this.LabelInputQuestion.Visible = false;
            // 
            // ButtonInputQuestions
            // 
            this.ButtonInputQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInputQuestions.Location = new System.Drawing.Point(16, 262);
            this.ButtonInputQuestions.Name = "ButtonInputQuestions";
            this.ButtonInputQuestions.Size = new System.Drawing.Size(150, 59);
            this.ButtonInputQuestions.TabIndex = 9;
            this.ButtonInputQuestions.Text = "Начать ввод вопросов";
            this.ButtonInputQuestions.UseVisualStyleBackColor = true;
            this.ButtonInputQuestions.Click += new System.EventHandler(this.ButtonInputQuestions_Click);
            // 
            // TextBoxSpecialization
            // 
            this.TextBoxSpecialization.Location = new System.Drawing.Point(240, 144);
            this.TextBoxSpecialization.Name = "TextBoxSpecialization";
            this.TextBoxSpecialization.Size = new System.Drawing.Size(142, 20);
            this.TextBoxSpecialization.TabIndex = 10;
            // 
            // LabelSpecialization
            // 
            this.LabelSpecialization.AutoSize = true;
            this.LabelSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSpecialization.Location = new System.Drawing.Point(12, 142);
            this.LabelSpecialization.Name = "LabelSpecialization";
            this.LabelSpecialization.Size = new System.Drawing.Size(222, 20);
            this.LabelSpecialization.TabIndex = 11;
            this.LabelSpecialization.Text = "Введите специальность:";
            // 
            // ButtonNextQuestion
            // 
            this.ButtonNextQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonNextQuestion.Location = new System.Drawing.Point(371, 201);
            this.ButtonNextQuestion.Name = "ButtonNextQuestion";
            this.ButtonNextQuestion.Size = new System.Drawing.Size(167, 58);
            this.ButtonNextQuestion.TabIndex = 12;
            this.ButtonNextQuestion.Text = "Следующий вопрос";
            this.ButtonNextQuestion.UseVisualStyleBackColor = true;
            this.ButtonNextQuestion.Visible = false;
            this.ButtonNextQuestion.Click += new System.EventHandler(this.ButtonNextQuestion_Click);
            // 
            // ButtonComplete
            // 
            this.ButtonComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonComplete.Location = new System.Drawing.Point(184, 201);
            this.ButtonComplete.Name = "ButtonComplete";
            this.ButtonComplete.Size = new System.Drawing.Size(160, 59);
            this.ButtonComplete.TabIndex = 13;
            this.ButtonComplete.Text = "Завершить создание опроса";
            this.ButtonComplete.UseVisualStyleBackColor = true;
            this.ButtonComplete.Visible = false;
            this.ButtonComplete.Click += new System.EventHandler(this.ButtonComplete_Click);
            // 
            // LabelQuestCount
            // 
            this.LabelQuestCount.AutoSize = true;
            this.LabelQuestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelQuestCount.Location = new System.Drawing.Point(12, 178);
            this.LabelQuestCount.Name = "LabelQuestCount";
            this.LabelQuestCount.Size = new System.Drawing.Size(276, 20);
            this.LabelQuestCount.TabIndex = 14;
            this.LabelQuestCount.Text = "Введите количество вопросов:";
            // 
            // TextBoxQuestCount
            // 
            this.TextBoxQuestCount.Location = new System.Drawing.Point(294, 178);
            this.TextBoxQuestCount.Name = "TextBoxQuestCount";
            this.TextBoxQuestCount.Size = new System.Drawing.Size(50, 20);
            this.TextBoxQuestCount.TabIndex = 15;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "C:\\Users\\Administrator\\source\\repos\\Kurs_CherkasovSV_sem3_v_1.1\\WinFormsKP\\bin\\De" +
    "bug";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 333);
            this.Controls.Add(this.TextBoxQuestCount);
            this.Controls.Add(this.LabelQuestCount);
            this.Controls.Add(this.ButtonComplete);
            this.Controls.Add(this.ButtonNextQuestion);
            this.Controls.Add(this.LabelSpecialization);
            this.Controls.Add(this.TextBoxSpecialization);
            this.Controls.Add(this.ButtonInputQuestions);
            this.Controls.Add(this.LabelInputQuestion);
            this.Controls.Add(this.LabelFIODoctor);
            this.Controls.Add(this.TextBoxQuestion);
            this.Controls.Add(this.TextBoxPatronymicDoctor);
            this.Controls.Add(this.TextBoxNameDoctor);
            this.Controls.Add(this.TextBoxSurnameDoctor);
            this.Controls.Add(this.LabelPatronymicDoctor);
            this.Controls.Add(this.LabelNameDoctor);
            this.Controls.Add(this.LabelSurnameDoctor);
            this.Name = "Form5";
            this.Text = "Создание опроса";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form5_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelSurnameDoctor;
        private System.Windows.Forms.Label LabelNameDoctor;
        private System.Windows.Forms.Label LabelPatronymicDoctor;
        private System.Windows.Forms.TextBox TextBoxSurnameDoctor;
        private System.Windows.Forms.TextBox TextBoxNameDoctor;
        private System.Windows.Forms.TextBox TextBoxPatronymicDoctor;
        private System.Windows.Forms.TextBox TextBoxQuestion;
        private System.Windows.Forms.Label LabelFIODoctor;
        private System.Windows.Forms.Label LabelInputQuestion;
        private System.Windows.Forms.Button ButtonInputQuestions;
        private System.Windows.Forms.TextBox TextBoxSpecialization;
        private System.Windows.Forms.Label LabelSpecialization;
        private System.Windows.Forms.Button ButtonNextQuestion;
        private System.Windows.Forms.Button ButtonComplete;
        private System.Windows.Forms.Label LabelQuestCount;
        private System.Windows.Forms.TextBox TextBoxQuestCount;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}