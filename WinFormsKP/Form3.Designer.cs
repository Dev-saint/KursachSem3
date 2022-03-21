
namespace WinFormsKP
{
    partial class Form3
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
            this.LabelChooseMode = new System.Windows.Forms.Label();
            this.ButtonPatient = new System.Windows.Forms.Button();
            this.ButtonAdmin = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelChooseMode
            // 
            this.LabelChooseMode.AutoSize = true;
            this.LabelChooseMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelChooseMode.Location = new System.Drawing.Point(326, 30);
            this.LabelChooseMode.Name = "LabelChooseMode";
            this.LabelChooseMode.Size = new System.Drawing.Size(242, 31);
            this.LabelChooseMode.TabIndex = 0;
            this.LabelChooseMode.Text = "Выберите режим";
            // 
            // ButtonPatient
            // 
            this.ButtonPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPatient.Location = new System.Drawing.Point(332, 110);
            this.ButtonPatient.Name = "ButtonPatient";
            this.ButtonPatient.Size = new System.Drawing.Size(236, 65);
            this.ButtonPatient.TabIndex = 1;
            this.ButtonPatient.Text = "Пациент";
            this.ButtonPatient.UseVisualStyleBackColor = true;
            this.ButtonPatient.Click += new System.EventHandler(this.ButtonPatient_Click);
            // 
            // ButtonAdmin
            // 
            this.ButtonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonAdmin.Location = new System.Drawing.Point(332, 274);
            this.ButtonAdmin.Name = "ButtonAdmin";
            this.ButtonAdmin.Size = new System.Drawing.Size(236, 75);
            this.ButtonAdmin.TabIndex = 2;
            this.ButtonAdmin.Text = "Администратор";
            this.ButtonAdmin.UseVisualStyleBackColor = true;
            this.ButtonAdmin.Click += new System.EventHandler(this.ButtonAdmin_Click);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelPassword.Location = new System.Drawing.Point(12, 206);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(911, 29);
            this.LabelPassword.TabIndex = 3;
            this.LabelPassword.Text = "Для запуска режима \"Администратор\" введите пароль администратора";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Location = new System.Drawing.Point(332, 374);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.PasswordChar = '*';
            this.TextBoxPassword.Size = new System.Drawing.Size(236, 21);
            this.TextBoxPassword.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.ButtonAdmin);
            this.Controls.Add(this.ButtonPatient);
            this.Controls.Add(this.LabelChooseMode);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form3";
            this.Text = "Вход в систему";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelChooseMode;
        private System.Windows.Forms.Button ButtonPatient;
        private System.Windows.Forms.Button ButtonAdmin;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.TextBox TextBoxPassword;
    }
}