namespace College.DAL.views
{
    partial class AddSubject
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
            textBox_Name = new TextBox();
            textBox_Lecturer = new TextBox();
            textBox_Hours = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button_Add = new Button();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(487, 156);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(125, 27);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_Lecturer
            // 
            textBox_Lecturer.Location = new Point(487, 224);
            textBox_Lecturer.Name = "textBox_Lecturer";
            textBox_Lecturer.Size = new Size(125, 27);
            textBox_Lecturer.TabIndex = 1;
            // 
            // textBox_Hours
            // 
            textBox_Hours.Location = new Point(487, 289);
            textBox_Hours.Name = "textBox_Hours";
            textBox_Hours.Size = new Size(125, 27);
            textBox_Hours.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(361, 231);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 3;
            label1.Text = "lecturer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(361, 163);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "subject";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(361, 296);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 5;
            label3.Text = "hours";
            // 
            // button_Add
            // 
            button_Add.Location = new Point(422, 344);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(94, 29);
            button_Add.TabIndex = 6;
            button_Add.TabStop = false;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // AddSubject
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Add);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Hours);
            Controls.Add(textBox_Lecturer);
            Controls.Add(textBox_Name);
            Name = "AddSubject";
            Text = "AddSubject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private TextBox textBox_Lecturer;
        private TextBox textBox_Hours;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button_Add;
    }
}