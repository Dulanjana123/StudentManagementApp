using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationClass
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool IsActive { get; set; }

        public string Password { get; set; }

        public User()
        {

        }

        public User(int id)
        {
            
            using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("User_Get_ById", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = id;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

                conn.Close();

                if (dt.Rows.Count > 0)
                {
                    this.UserName = dt.Rows[0]["UserName"].ToString();
                    this.FirstName = dt.Rows[0]["FirstName"].ToString();
                    this.LastName = dt.Rows[0]["LastName"].ToString();
                    this.Password = dt.Rows[0]["Password"].ToString();
                    this.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                    this.IsActive = bool.Parse(dt.Rows[0]["IsActive"].ToString());
                }
            }

        }

        public User(string username)
        {
            using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("User_Get_ByUserName", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = username;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Populate(dt);

                conn.Close();
            }
        }

        private void Populate(DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                this.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                this.UserName = dt.Rows[0]["UserName"].ToString();
                this.FirstName = dt.Rows[0]["FirstName"].ToString();
                this.LastName = dt.Rows[0]["LastName"].ToString();
                this.Password = dt.Rows[0]["Password"].ToString();
                this.IsActive = dt.Rows[0]["IsActive"].ToString() == "" ? false : bool.Parse(dt.Rows[0]["IsActive"].ToString());
            }
        }

        public void save()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("User_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = this.UserName;
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = this.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = this.LastName;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = this.Password;
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = this.IsActive;
                    //cmd.Parameters.Add("@LastUpdatedUser", SqlDbType.Int).Value = 1;
                    cmd.Parameters.Add("@LastUpdatedUser", SqlDbType.Int).Value = MainController.Instance.LoggedUser.Id;

                    //cmd.ExecuteScalar().ToString();
                    this.Id = int.Parse(cmd.ExecuteScalar().ToString());

                    conn.Close();
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void update()
        {
            try 
            {
                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("User_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = this.Id;
                    cmd.Parameters.Add("@UName", SqlDbType.VarChar).Value = this.UserName;
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = this.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = this.LastName;
                    cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = this.Password;
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = this.IsActive;
                    cmd.Parameters.Add("@LastUpdatedUser", SqlDbType.Int).Value = MainController.Instance.LoggedUser.Id;

                    cmd.ExecuteNonQuery();
                    //cmd.ExecuteScalar().ToString();
                    //this.Id = int.Parse(cmd.ExecuteScalar().ToString());

                    conn.Close();
                };

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
