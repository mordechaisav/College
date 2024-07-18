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

namespace College.DAL.views
{
    internal partial class AddSubject : Form
    {
        private CategoryRepository _categoryRepository;
        private string _lecturerName;
        public AddSubject(CategoryRepository categoryRepository,string lecturerName)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            _lecturerName = lecturerName;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            list.Add(textBox_Name.Text);
            list.Add(_lecturerName);
           
            bool result = _categoryRepository.InsertCours(list);
        }
    }
}
