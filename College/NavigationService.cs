using College.DAL.views;
using College.DAL;
using College.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeCRM.Services
{
    public enum FormNames
    {
        PasswordChangeForm,
        LoginForm,
        ShiftClockForm
    }

    internal static class NavigationService
    {
        public static void HandleCloseFormEvent(object sender, FormClosingEventArgs e, bool isNavigating)
        {
            if (!isNavigating && e.CloseReason == CloseReason.UserClosing)
            {
                string confirmExitQuestion = "האם ברצונך לצאת מהמערכת?";
                string confirmExitTitle = "אשר יציאה מהמערכת";
                DialogResult dialogResult = MessageBox.Show(confirmExitQuestion, confirmExitTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                    return;
                }
                e.Cancel = true;
            }
        }

        public static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            openForms.ForEach(f => f.Close());
        }

        public static void ShowForm(string form1, ref bool isNavigating)
        {
            DBContext dbCtx = new DBContext();
            isNavigating = true;
            CloseAllForms();
            Form form = form1 switch
            {
                "form1" => new Form1(),
                "createCourse" => new CreateCourse(new CategoryRepository(dbCtx)),
                "collegeHome" => new CollegeHome(new CategoryRepository(dbCtx)),
                "administrators" => new Administrators(),
                "addstudent" => new AddStudent(new CategoryRepository(dbCtx)),
                _ => throw new ArgumentException("Invalid form name.", nameof(form1))
            };
            form.Show();
            isNavigating = false;
        }
    }
}
