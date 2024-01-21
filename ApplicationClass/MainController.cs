using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationClass
{
    public class MainController
    {
        private static MainController instance;

        public static MainController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new MainController();
                }

                return instance;
            }
        }

        public User LoggedUser { get; private set; }

        public bool DoLogin(string username, string password)
        {
            try
            {
                //check username and password. if username and password correct then return true.
                using (SqlConnection conn = new SqlConnection(this.GetConnectionString()))
                {
                    conn.Open();

                    SqlCommand cmd = new SqlCommand("User_CheckAuthentication", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = username;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    conn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        this.LoggedUser = new User(username);
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetConnectionString()
        {
            //return "Data Source = .; Initial Catalog = StudentManagement; Asynchronous Processing=true;";
            //return "Data Source=.;Database=StudentManagement;Trusted_Connection=True;";
            //return "Server=.;Database=StudentManagement;Trusted_Connection=True;  Asynchronous Processing=true;";
            return "Server=.;Initial Catalog=StudentManagement;Trusted_Connection=True;";

        }
    }
}
