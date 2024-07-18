namespace College.DAL.views
{
    partial class AddStudent
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
            dataGridView1 = new DataGridView();
            textBox_add = new TextBox();
            button_add = new Button();
            dataGridView2 = new DataGridView();
            textBox_subject = new TextBox();
            button_subject = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(618, 33);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox_add
            // 
            textBox_add.Location = new Point(456, 118);
            textBox_add.Name = "textBox_add";
            textBox_add.Size = new Size(125, 27);
            textBox_add.TabIndex = 1;
            // 
            // button_add
            // 
            button_add.Location = new Point(319, 118);
            button_add.Name = "button_add";
            button_add.Size = new Size(94, 29);
            button_add.TabIndex = 2;
            button_add.Text = "button1";
            button_add.UseVisualStyleBackColor = true;
            button_add.Click += button_add_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(618, 306);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(300, 188);
            dataGridView2.TabIndex = 3;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // textBox_subject
            // 
            textBox_subject.Location = new Point(456, 364);
            textBox_subject.Name = "textBox_subject";
            textBox_subject.Size = new Size(125, 27);
            textBox_subject.TabIndex = 4;
            // 
            // button_subject
            // 
            button_subject.Location = new Point(319, 364);
            button_subject.Name = "button_subject";
            button_subject.Size = new Size(94, 29);
            button_subject.TabIndex = 5;
            button_subject.Text = "button1";
            button_subject.UseVisualStyleBackColor = true;
            button_subject.Click += button_subject_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 546);
            Controls.Add(button_subject);
            Controls.Add(textBox_subject);
            Controls.Add(dataGridView2);
            Controls.Add(button_add);
            Controls.Add(textBox_add);
            Controls.Add(dataGridView1);
            Name = "AddStudent";
            Text = "AddStudent";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox_add;
        private Button button_add;
        private DataGridView dataGridView2;
        private TextBox textBox_subject;
        private Button button_subject;
    }
}