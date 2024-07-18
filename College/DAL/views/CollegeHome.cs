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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace College.DAL.views
{
    internal partial class CollegeHome : Form
    {
        private CategoryRepository _categoryRepository;
        public CollegeHome(CategoryRepository categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            DataTable dt = _categoryRepository.FindAllCourse();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string cellValue = row.Cells[0].Value.ToString();
                textBox_course.Text = cellValue;
            }
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string courseName = textBox_course.Text;
            int CourseID = _categoryRepository.FindCorseByName(courseName);
            string courseID = CourseID.ToString();
            List<string> list = new List<string>();
            list.Add(courseID);
            list.Add(textBox_name.Text);
            bool result = _categoryRepository.InsertWaiting(list);
            if (result)
            {
                MessageBox.Show("insert sucsses");
            }
        }
    }
}
