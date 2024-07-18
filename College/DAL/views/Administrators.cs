using EmployeeCRM.Services;
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
    public partial class Administrators : Form
    {

        private bool isNavigating = false;
        public Administrators()
        {
            InitializeComponent();
        }

        private void button_add_student_Click(object sender, EventArgs e)
        {
            NavigationService.ShowForm("addstudent", ref isNavigating);
        }

        private void button_add_course_Click(object sender, EventArgs e)
        {
            NavigationService.ShowForm("createCourse", ref isNavigating);
        }
    }
}
