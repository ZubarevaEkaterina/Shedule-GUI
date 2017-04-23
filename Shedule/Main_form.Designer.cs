namespace Schedule
{
    partial class Main_form
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
            this.admin_button = new System.Windows.Forms.Button();
            this.teacher_button = new System.Windows.Forms.Button();
            this.student_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_button
            // 
            this.admin_button.Location = new System.Drawing.Point(75, 81);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(125, 39);
            this.admin_button.TabIndex = 0;
            this.admin_button.Text = "Адинистратор";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // teacher_button
            // 
            this.teacher_button.Location = new System.Drawing.Point(75, 126);
            this.teacher_button.Name = "teacher_button";
            this.teacher_button.Size = new System.Drawing.Size(125, 40);
            this.teacher_button.TabIndex = 1;
            this.teacher_button.Text = "Учитель";
            this.teacher_button.UseVisualStyleBackColor = true;
            this.teacher_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // student_button
            // 
            this.student_button.Location = new System.Drawing.Point(75, 172);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(125, 37);
            this.student_button.TabIndex = 2;
            this.student_button.Text = "Студент";
            this.student_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Войти как:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.student_button);
            this.Controls.Add(this.teacher_button);
            this.Controls.Add(this.admin_button);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Shedule";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button admin_button;
        private System.Windows.Forms.Button teacher_button;
        private System.Windows.Forms.Button student_button;
        private System.Windows.Forms.Label label1;
    }
}

