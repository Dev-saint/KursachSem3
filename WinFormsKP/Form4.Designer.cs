
namespace WinFormsKP
{
    partial class Form4
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
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ComboBoxSelectQuizEdit = new System.Windows.Forms.ComboBox();
            this.ComboBoxSelectQuizDelete = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonCreate.Location = new System.Drawing.Point(25, 12);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(177, 64);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "Создать опрос";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(25, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 64);
            this.button2.TabIndex = 1;
            this.button2.Text = "Редактировать опрос";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(25, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 64);
            this.button3.TabIndex = 2;
            this.button3.Text = "Удалить опрос";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // ComboBoxSelectQuizEdit
            // 
            this.ComboBoxSelectQuizEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxSelectQuizEdit.FormattingEnabled = true;
            this.ComboBoxSelectQuizEdit.Location = new System.Drawing.Point(239, 110);
            this.ComboBoxSelectQuizEdit.Name = "ComboBoxSelectQuizEdit";
            this.ComboBoxSelectQuizEdit.Size = new System.Drawing.Size(500, 32);
            this.ComboBoxSelectQuizEdit.TabIndex = 3;
            this.ComboBoxSelectQuizEdit.Text = "Выберите опрос...";
            // 
            // ComboBoxSelectQuizDelete
            // 
            this.ComboBoxSelectQuizDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ComboBoxSelectQuizDelete.FormattingEnabled = true;
            this.ComboBoxSelectQuizDelete.Location = new System.Drawing.Point(239, 194);
            this.ComboBoxSelectQuizDelete.Name = "ComboBoxSelectQuizDelete";
            this.ComboBoxSelectQuizDelete.Size = new System.Drawing.Size(500, 32);
            this.ComboBoxSelectQuizDelete.TabIndex = 4;
            this.ComboBoxSelectQuizDelete.Text = "Выберите опрос...";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 368);
            this.Controls.Add(this.ComboBoxSelectQuizDelete);
            this.Controls.Add(this.ComboBoxSelectQuizEdit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ButtonCreate);
            this.Name = "Form4";
            this.Text = "Редактор запросов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox ComboBoxSelectQuizEdit;
        private System.Windows.Forms.ComboBox ComboBoxSelectQuizDelete;
    }
}