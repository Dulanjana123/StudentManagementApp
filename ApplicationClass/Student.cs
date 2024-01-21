using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ApplicationClass
{
    public class Student
    {
        public int Id { get; set; }

        public string StudentName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public string Gender { get; set; }

        public bool IsActive { get; set; }

        public Student()
        {

        }

        public Student(int id)
        {
            using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Student_Get_ById", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                conn.Close();

                da.Fill(dt);

                this.Id = int.Parse(dt.Rows[0]["Id"].ToString());
                this.StudentName = dt.Rows[0]["StudentName"].ToString();
                this.FirstName = dt.Rows[0]["FirstName"].ToString();
                this.LastName = dt.Rows[0]["LastName"].ToString();
                this.Phone = dt.Rows[0]["Phone"].ToString();
                this.Address = dt.Rows[0]["Address"].ToString();
                this.Gender = dt.Rows[0]["Gender"].ToString();
                this.IsActive = bool.Parse(dt.Rows[0]["IsActive"].ToString());

            }

        }


        public Student(string studentName)
        {
            using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("Student_Get_ByStudentName", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@StudentName", SqlDbType.VarChar).Value = studentName;

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
                this.StudentName = dt.Rows[0]["StudentName"].ToString();
                this.FirstName = dt.Rows[0]["FirstName"].ToString();
                this.LastName = dt.Rows[0]["LastName"].ToString();
                this.Phone = dt.Rows[0]["Phone"].ToString();
                this.Address = dt.Rows[0]["Address"].ToString();
                this.Gender = dt.Rows[0]["Gender"].ToString();
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
                    SqlCommand cmd = new SqlCommand("Student_Insert", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@StudentName", SqlDbType.VarChar).Value = this.StudentName;
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = this.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = this.LastName;
                    cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = this.Phone;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = this.Address;
                    cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = this.Gender;
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
                    SqlCommand cmd = new SqlCommand("Student_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = this.Id;
                    cmd.Parameters.Add("@StudentName", SqlDbType.VarChar).Value = this.StudentName;
                    cmd.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = this.FirstName;
                    cmd.Parameters.Add("@LastName", SqlDbType.VarChar).Value = this.LastName;
                    cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = this.Phone;
                    cmd.Parameters.Add("@Address", SqlDbType.VarChar).Value = this.Address;
                    cmd.Parameters.Add("@Gender", SqlDbType.VarChar).Value = this.Gender;
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = this.IsActive;

                    cmd.Parameters.Add("@LastUpdatedUser", SqlDbType.Int).Value = MainController.Instance.LoggedUser.Id;


                    cmd.ExecuteNonQuery();

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
