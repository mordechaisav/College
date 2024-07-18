namespace College.DAL.views
{
    partial class CreateCourse
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
            textBox_Date = new TextBox();
            textBox_Days = new TextBox();
            textBox_BeginnTime = new TextBox();
            textBox_EndTime = new TextBox();
            textBox_Price = new TextBox();
            name = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button_Add = new Button();
            SuspendLayout();
            // 
            // textBox_Name
            // 
            textBox_Name.Location = new Point(510, 94);
            textBox_Name.Name = "textBox_Name";
            textBox_Name.Size = new Size(125, 27);
            textBox_Name.TabIndex = 0;
            // 
            // textBox_Date
            // 
            textBox_Date.Location = new Point(510, 146);
            textBox_Date.Name = "textBox_Date";
            textBox_Date.Size = new Size(125, 27);
            textBox_Date.TabIndex = 1;
            // 
            // textBox_Days
            // 
            textBox_Days.Location = new Point(510, 193);
            textBox_Days.Name = "textBox_Days";
            textBox_Days.Size = new Size(125, 27);
            textBox_Days.TabIndex = 2;
            // 
            // textBox_BeginnTime
            // 
            textBox_BeginnTime.Location = new Point(510, 238);
            textBox_BeginnTime.Name = "textBox_BeginnTime";
            textBox_BeginnTime.Size = new Size(125, 27);
            textBox_BeginnTime.TabIndex = 3;
            // 
            // textBox_EndTime
            // 
            textBox_EndTime.Location = new Point(510, 282);
            textBox_EndTime.Name = "textBox_EndTime";
            textBox_EndTime.Size = new Size(125, 27);
            textBox_EndTime.TabIndex = 4;
            // 
            // textBox_Price
            // 
            textBox_Price.Location = new Point(510, 323);
            textBox_Price.Name = "textBox_Price";
            textBox_Price.Size = new Size(125, 27);
            textBox_Price.TabIndex = 5;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(385, 97);
            name.Name = "name";
            name.Size = new Size(46, 20);
            name.TabIndex = 6;
            name.Text = "name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(385, 153);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "start date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(385, 200);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 8;
            label3.Text = "days of the week";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(385, 245);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 9;
            label4.Text = "Beginning time";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(385, 289);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 10;
            label5.Text = "End time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 330);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 11;
            label6.Text = "cost";
            // 
            // button_Add
            // 
            button_Add.Location = new Point(497, 388);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(94, 29);
            button_Add.TabIndex = 12;
            button_Add.Text = "add";
            button_Add.UseVisualStyleBackColor = true;
            button_Add.Click += button_Add_Click;
            // 
            // CreateCourse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Add);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(name);
            Controls.Add(textBox_Price);
            Controls.Add(textBox_EndTime);
            Controls.Add(textBox_BeginnTime);
            Controls.Add(textBox_Days);
            Controls.Add(textBox_Date);
            Controls.Add(textBox_Name);
            Name = "CreateCourse";
            Text = "CreateCourse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_Name;
        private TextBox textBox_Date;
        private TextBox textBox_Days;
        private TextBox textBox_BeginnTime;
        private TextBox textBox_EndTime;
        private TextBox textBox_Price;
        private Label name;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button_Add;
    }
}