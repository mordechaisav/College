using College.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace College.DAL.views
{
    internal partial class AddStudent : Form
        
    {
        private CategoryRepository _categoryRepository;
        public AddStudent(CategoryRepository categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            DataTable dt = _categoryRepository.FindAllWaiting();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string cellValue = row.Cells[0].Value.ToString();
                textBox_add.Text = cellValue;
            }
        }

        private int studentID;
        private int courseID;
        private void button_add_Click(object sender, EventArgs e)
        {
            string Name = textBox_add.Text;
            studentID = _categoryRepository.InsertStudent(Name);
            courseID = _categoryRepository.FindWaitingByName(Name);
            
            MessageBox.Show("insert sucsses");
            DataTable dt = _categoryRepository.FindAllsubjct(courseID);
            dataGridView2.DataSource = dt;
        }

        private void button_subject_Click(object sender, EventArgs e)
        {
            int subjectID = int.Parse(textBox_subject.Text);
            bool result = _categoryRepository.InsertStudentCourse(studentID, subjectID);
            if (result) { MessageBox.Show("insert sucsses"); }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
                string cellValue = row.Cells[0].Value.ToString();
                textBox_subject.Text = cellValue;

            }
        }
    }
}
