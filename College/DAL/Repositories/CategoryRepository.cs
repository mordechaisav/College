using Guest_Shabbat_Host_App.DAL.Models;
using College.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace College.DAL.Repositories
{
    internal class CategoryRepository : Form
    {
        private readonly DBContext _dbContext;
        

        public CategoryRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DataTable FindAllCourse()
        {
            string query = "SELECT CourseName FROM Course";
            DataTable result = _dbContext.ExecuteQuery(query, null);
            return result;
        }
        public DataTable FindAllWaiting()
        {
            string query = "select StudentName,CourseID from Waiting";
            DataTable result = _dbContext.ExecuteQuery(query, null);
            return result;  
        }
        public DataTable FindAllsubjct(int corse)
        {
            string query = "SELECT * FROM Subjects WHERE CourseID = @corse; ";
            SqlParameter[] parameters = { new SqlParameter("@corse", corse) };
            DataTable result = _dbContext.ExecuteQuery(query, null);
            return result;
        }

        public int FindPrice(int courseID)
        {
            string query = "Select price from Course where ID = @ID";
            SqlParameter[] parameters = { new SqlParameter("@ID", courseID) };
            object result = _dbContext.ExecuteScalar(query, parameters);
            int intValue = 0;
            if (result != null && result != DBNull.Value)
            {
                intValue = Convert.ToInt32(result);
            }
            return intValue;
        }

        public int FindCorseByName(string name)
        {
            string query = "select ID from Course where CourseName = @name";
            SqlParameter[] parameters = { new SqlParameter("@name", name) };
            object result = _dbContext.ExecuteScalar(query, parameters);
            int intValue = 0;   
            if (result != null && result != DBNull.Value)
            {
                intValue = Convert.ToInt32(result);
            }
            return intValue;
        }
        public bool InsertWaiting(List<string> parameter)
        {
            string query = "insert into Waiting(CourseID,StudentName) values (@CourseID,@StudentName)";
            SqlParameter[] parameters = {
            new SqlParameter("@CourseID", SqlDbType.Int) { Value = int.Parse(parameter[0]) },
            new SqlParameter("@StudentName", SqlDbType.VarChar) { Value = parameter[1] },
            };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;

        }

        public int FindWaitingByName(string name)
        {
            string query = "select CourseID from Waiting where StudentName = @name";
            SqlParameter[] parameters = { new SqlParameter("@name", name) };
            object result = _dbContext.ExecuteScalar(query, parameters);
            int intValue = 0;
            if (result != null && result != DBNull.Value)
            {
                intValue = Convert.ToInt32(result);
            }
            return intValue;
        }
        public int ID = 0;
        public int InsertStudent(string name)
        {
            string query = "insert into Students(StudentName) values (@name)";
            SqlParameter[] parameters = {
            new SqlParameter("@name", SqlDbType.VarChar) { Value = name },
            };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return ++ID;
        }
        public bool InsertStudentCourse(int studentID,int subjectID)
        {
            string query = "insert into Students_in_course(StudentID,SubjectID) values(@student,@subject)";
            SqlParameter[] parameters = {
            new SqlParameter("@student", SqlDbType.Int) { Value = studentID },
            new SqlParameter("@subject",SqlDbType.Int) {Value = subjectID},
            };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }



        
        public bool InsertCours(List<string> parameter)
        {
            string query = "insert into Course(CourseName,StartDate,DaysOfWeek,BeginTime,EndTime,price)\r\nvalues(@CourseName,@StartDate,@DaysOfWeek,@BeginTime,@EndTime,@price)";
            SqlParameter[] parameters = {
            new SqlParameter("@CourseName", SqlDbType.VarChar) { Value = parameter[0] },
            new SqlParameter("@StartDate", SqlDbType.DateTime) { Value = DateTime.Parse(parameter[1]) },
            new SqlParameter("@DaysOfWeek", SqlDbType.VarChar) { Value = parameter[2] },
            new SqlParameter("@BeginTime", SqlDbType.Time) { Value = TimeSpan.Parse(parameter[3]) },
            new SqlParameter("@EndTime", SqlDbType.Time) { Value = TimeSpan.Parse(parameter[4]) },
            new SqlParameter("@price", SqlDbType.Int) { Value = int.Parse(parameter[5]) }
            };
            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        


        
        
    }
}