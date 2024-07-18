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
    internal partial class CreateCourse : Form
    {
        private CategoryRepository _categoryRepository;
        
        public CreateCourse(CategoryRepository categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(textBox_Name.Text);
            list.Add(textBox_Date.Text);
            list.Add(textBox_Days.Text);
            list.Add(textBox_BeginnTime.Text);
            list.Add(textBox_EndTime.Text);
            list.Add(textBox_Price.Text);
            bool result = _categoryRepository.InsertCours(list);


        }
    }
}
