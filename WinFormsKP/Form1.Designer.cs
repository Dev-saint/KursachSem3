
namespace WinFormsKP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxSurnamePatient = new System.Windows.Forms.TextBox();
            this.LabelSurnamePatient = new System.Windows.Forms.Label();
            this.LabelNamePatient = new System.Windows.Forms.Label();
            this.LabelPatronymicPatient = new System.Windows.Forms.Label();
            this.TextBoxNamePatient = new System.Windows.Forms.TextBox();
            this.TextBoxPatronymicPatient = new System.Windows.Forms.TextBox();
            this.LabelPatient = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ComboBoxSelectDoctor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TextBoxSurnamePatient
            // 
            this.TextBoxSurnamePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxSurnamePatient.Location = new System.Drawing.Point(172, 56);
            this.TextBoxSurnamePatient.Name = "TextBoxSurnamePatient";
            this.TextBoxSurnamePatient.Size = new System.Drawing.Size(147, 22);
            this.TextBoxSurnamePatient.TabIndex = 0;
            // 
            // LabelSurnamePatient
            // 
            this.LabelSurnamePatient.AutoSize = true;
            this.LabelSurnamePatient.BackColor = System.Drawing.SystemColors.Window;
            this.LabelSurnamePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelSurnamePatient.Location = new System.Drawing.Point(8, 56);
            this.LabelSurnamePatient.Name = "LabelSurnamePatient";
            this.LabelSurnamePatient.Size = new System.Drawing.Size(158, 18);
            this.LabelSurnamePatient.TabIndex = 1;
            this.LabelSurnamePatient.Text = "Введите фамилию:";
            // 
            // LabelNamePatient
            // 
            this.LabelNamePatient.AutoSize = true;
            this.LabelNamePatient.BackColor = System.Drawing.SystemColors.Window;
            this.LabelNamePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelNamePatient.Location = new System.Drawing.Point(8, 83);
            this.LabelNamePatient.Name = "LabelNamePatient";
            this.LabelNamePatient.Size = new System.Drawing.Size(113, 18);
            this.LabelNamePatient.TabIndex = 2;
            this.LabelNamePatient.Text = "Введите имя:";
            // 
            // LabelPatronymicPatient
            // 
            this.LabelPatronymicPatient.AutoSize = true;
            this.LabelPatronymicPatient.BackColor = System.Drawing.SystemColors.Window;
            this.LabelPatronymicPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPatronymicPatient.Location = new System.Drawing.Point(11, 111);
            this.LabelPatronymicPatient.Name = "LabelPatronymicPatient";
            this.LabelPatronymicPatient.Size = new System.Drawing.Size(155, 18);
            this.LabelPatronymicPatient.TabIndex = 3;
            this.LabelPatronymicPatient.Text = "Введите отчество:";
            // 
            // TextBoxNamePatient
            // 
            this.TextBoxNamePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxNamePatient.Location = new System.Drawing.Point(172, 83);
            this.TextBoxNamePatient.Name = "TextBoxNamePatient";
            this.TextBoxNamePatient.Size = new System.Drawing.Size(147, 22);
            this.TextBoxNamePatient.TabIndex = 4;
            // 
            // TextBoxPatronymicPatient
            // 
            this.TextBoxPatronymicPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxPatronymicPatient.Location = new System.Drawing.Point(172, 111);
            this.TextBoxPatronymicPatient.Name = "TextBoxPatronymicPatient";
            this.TextBoxPatronymicPatient.Size = new System.Drawing.Size(147, 22);
            this.TextBoxPatronymicPatient.TabIndex = 5;
            // 
            // LabelPatient
            // 
            this.LabelPatient.AutoSize = true;
            this.LabelPatient.BackColor = System.Drawing.SystemColors.Window;
            this.LabelPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPatient.Location = new System.Drawing.Point(7, 9);
            this.LabelPatient.Name = "LabelPatient";
            this.LabelPatient.Size = new System.Drawing.Size(185, 24);
            this.LabelPatient.TabIndex = 6;
            this.LabelPatient.Text = "Данные пациента";
            // 
            // ButtonStart
            // 
            this.ButtonStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ButtonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStart.Location = new System.Drawing.Point(81, 325);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(238, 72);
            this.ButtonStart.TabIndex = 7;
            this.ButtonStart.Text = "НАЧАТЬ ОПРОС";
            this.ButtonStart.UseVisualStyleBackColor = false;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ComboBoxSelectDoctor
            // 
            this.ComboBoxSelectDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxSelectDoctor.FormattingEnabled = true;
            this.ComboBoxSelectDoctor.Location = new System.Drawing.Point(11, 246);
            this.ComboBoxSelectDoctor.Name = "ComboBoxSelectDoctor";
            this.ComboBoxSelectDoctor.Size = new System.Drawing.Size(386, 28);
            this.ComboBoxSelectDoctor.TabIndex = 8;
            this.ComboBoxSelectDoctor.Text = "Выберите доктора...";
            this.ComboBoxSelectDoctor.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSelectDoctor_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 430);
            this.Controls.Add(this.ComboBoxSelectDoctor);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelPatient);
            this.Controls.Add(this.TextBoxPatronymicPatient);
            this.Controls.Add(this.TextBoxNamePatient);
            this.Controls.Add(this.LabelPatronymicPatient);
            this.Controls.Add(this.LabelNamePatient);
            this.Controls.Add(this.LabelSurnamePatient);
            this.Controls.Add(this.TextBoxSurnamePatient);
            this.Name = "Form1";
            this.Text = "Медицинский опрос";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxSurnamePatient;
        private System.Windows.Forms.Label LabelSurnamePatient;
        private System.Windows.Forms.Label LabelNamePatient;
        private System.Windows.Forms.Label LabelPatronymicPatient;
        private System.Windows.Forms.TextBox TextBoxNamePatient;
        private System.Windows.Forms.TextBox TextBoxPatronymicPatient;
        private System.Windows.Forms.Label LabelPatient;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.ComboBox ComboBoxSelectDoctor;
    }
}

