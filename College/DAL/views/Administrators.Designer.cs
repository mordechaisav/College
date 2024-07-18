namespace College.DAL.views
{
    partial class Administrators
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
            button_add_student = new Button();
            button_add_subjects = new Button();
            button_add_course = new Button();
            SuspendLayout();
            // 
            // button_add_student
            // 
            button_add_student.BackColor = Color.Fuchsia;
            button_add_student.Location = new Point(376, 56);
            button_add_student.Name = "button_add_student";
            button_add_student.Size = new Size(219, 113);
            button_add_student.TabIndex = 0;
            button_add_student.Text = "add student";
            button_add_student.UseVisualStyleBackColor = false;
            button_add_student.Click += button_add_student_Click;
            // 
            // button_add_subjects
            // 
            button_add_subjects.BackColor = Color.Fuchsia;
            button_add_subjects.Location = new Point(376, 294);
            button_add_subjects.Name = "button_add_subjects";
            button_add_subjects.Size = new Size(219, 113);
            button_add_subjects.TabIndex = 1;
            button_add_subjects.Text = "add subjects";
            button_add_subjects.UseVisualStyleBackColor = false;
            // 
            // button_add_course
            // 
            button_add_course.BackColor = Color.Fuchsia;
            button_add_course.Location = new Point(376, 175);
            button_add_course.Name = "button_add_course";
            button_add_course.Size = new Size(219, 113);
            button_add_course.TabIndex = 2;
            button_add_course.Text = "add courses";
            button_add_course.UseVisualStyleBackColor = false;
            button_add_course.Click += button_add_course_Click;
            // 
            // Administrators
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_add_course);
            Controls.Add(button_add_subjects);
            Controls.Add(button_add_student);
            Name = "Administrators";
            Text = "Administrators";
            ResumeLayout(false);
        }

        #endregion

        private Button button_add_student;
        private Button button_add_subjects;
        private Button button_add_course;
    }
}