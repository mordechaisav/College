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
    public partial class Form1 : Form
    {
        private bool isNavigating = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Student_Click(object sender, EventArgs e)
        {
            NavigationService.ShowForm("collegeHome", ref isNavigating);
        }

        private void button_meneg_Click(object sender, EventArgs e)
        {
            NavigationService.ShowForm("administrators", ref isNavigating);
        }
    }
}
