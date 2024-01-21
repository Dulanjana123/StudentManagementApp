using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationClass
{
    public class Course
    {
        public int Id { get; set; }

        public string CourseName { get; set; }

        public string CourseHours { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; }

        public Course()
        {

        }

        public Course(int id)
        {
            using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Course_Get_ById", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Close();

                da.Fill(dt);

                this.CourseName = dt.Rows[0]["CourseName"].ToString();
                this.CourseHours = dt.Rows[0]["CourseHours"].ToString();
                this.Description = dt.Rows[0]["Description"].ToString();
                this.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                this.IsActive = bool.Parse(dt.Rows[0]["IsActive"].ToString());

            }
        }

        public Course(string courseName)
        {
            using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Course_Get_ByCourseName", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = courseName;

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
                this.CourseName = dt.Rows[0]["CourseName"].ToString();
                this.CourseHours = dt.Rows[0]["CourseHours"].ToString();
                this.Description = dt.Rows[0]["Description"].ToString();
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
                    SqlCommand cmd = new SqlCommand("Course_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = this.CourseName;
                    cmd.Parameters.Add("@CourseHours", SqlDbType.VarChar).Value = this.CourseHours;
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = this.Description;
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = this.IsActive;
                    cmd.Parameters.Add("@LastUpdatedUser", SqlDbType.Int).Value = MainController.Instance.LoggedUser.Id;

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
                    SqlCommand cmd = new SqlCommand("Course_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = this.Id;
                    cmd.Parameters.Add("@CourseName", SqlDbType.VarChar).Value = this.CourseName;
                    cmd.Parameters.Add("@CourseHours", SqlDbType.VarChar).Value = this.CourseHours;
                    cmd.Parameters.Add("@Description", SqlDbType.VarChar).Value = this.Description;
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
