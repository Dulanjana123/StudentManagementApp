using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationClass
{
    public class MasterFileController
    {
        private static MasterFileController instance;

        public static MasterFileController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MasterFileController();
                }

                return instance;
            }
        }

        public DataTable GetUserDataTable()
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("User_GetList", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

         

                    conn.Close();

                    return dt;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        /*
        public List<User> GetUserList()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("User_GetList", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    List<User> users = new List<User>();
                    foreach (DataRow dr in dt.Rows)
                    {
                        users.Add(new User()
                        {
                            UserName = dr["UserName"].ToString(),
                            FirstName = dr["FirstName"].ToString(),
                            LastName = dr["LastName"].ToString(),
                            Id = int.Parse(dr["Id"].ToString()),
                            IsActive = bool.Parse(dr["IsActive"].ToString())
                        });
                    }

                    conn.Close();

                    return users;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        */


        public DataTable GetStudentDataTable()
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Student_GetList", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);



                    conn.Close();

                    return dt;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public DataTable GetCourseDataTable()
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("Course_GetList", conn);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);



                    conn.Close();

                    return dt;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
