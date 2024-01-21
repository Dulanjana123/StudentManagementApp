using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationClass
{
    public class Lecturer : AbstractLecturer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Course { get; set; }

        public bool IsActive { get; set; }

        

        public override void Save()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Lecturer_Save", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Name", System.Data.SqlDbType.VarChar).Value = this.Name;
                    cmd.Parameters.Add("@Course", System.Data.SqlDbType.VarChar).Value = this.Course;
                    cmd.Parameters.Add("@IsActive", System.Data.SqlDbType.Bit).Value = this.IsActive;
                    cmd.Parameters.Add("@LastUpdatedUser", System.Data.SqlDbType.Int).Value = MainController.Instance.LoggedUser.Id;

                    this.Id = int.Parse(cmd.ExecuteScalar().ToString());

                    conn.Close();
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override void Update()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Lecturer_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Name", System.Data.SqlDbType.VarChar).Value = this.Name;
                    cmd.Parameters.Add("@Course", System.Data.SqlDbType.VarChar).Value = this.Course;
                    cmd.Parameters.Add("@IsActive", System.Data.SqlDbType.Bit).Value = this.IsActive;
                    cmd.Parameters.Add("@LastUpdatedUser", System.Data.SqlDbType.Int).Value = MainController.Instance.LoggedUser.Id;

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
