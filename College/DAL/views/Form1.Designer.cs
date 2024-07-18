namespace College.DAL.views
{
    partial class Form1
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
            button_Student = new Button();
            button_meneg = new Button();
            SuspendLayout();
            // 
            // button_Student
            // 
            button_Student.BackColor = Color.FromArgb(192, 192, 0);
            button_Student.Location = new Point(286, 78);
            button_Student.Name = "button_Student";
            button_Student.Size = new Size(241, 126);
            button_Student.TabIndex = 0;
            button_Student.Text = "students";
            button_Student.UseVisualStyleBackColor = false;
            button_Student.Click += button_Student_Click;
            // 
            // button_meneg
            // 
            button_meneg.BackColor = Color.FromArgb(192, 192, 0);
            button_meneg.Location = new Point(286, 237);
            button_meneg.Name = "button_meneg";
            button_meneg.Size = new Size(241, 126);
            button_meneg.TabIndex = 1;
            button_meneg.Text = "Administrators";
            button_meneg.UseVisualStyleBackColor = false;
            button_meneg.Click += button_meneg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_meneg);
            Controls.Add(button_Student);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Student;
        private Button button_meneg;
    }
}