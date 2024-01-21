using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationClass
{
    public class PermanentLecturer : Lecturer
    {
        public double CostForMonth { get; set; }

        public DateTime RecruitDate { get; set; }

        public override void Save()
        {
            try
            {
                base.Save();

                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("PermanentLecturer_Save", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = base.Id;
                    cmd.Parameters.Add("@CostForMonth", System.Data.SqlDbType.VarChar).Value = this.CostForMonth;
                    cmd.Parameters.Add("@RecruitDate", System.Data.SqlDbType.Date).Value = this.RecruitDate;


                    cmd.ExecuteNonQuery();

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
                base.Update();

                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("PermanentLecturer_Update", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = base.Id;
                    cmd.Parameters.Add("@CostForMonth", System.Data.SqlDbType.VarChar).Value = this.CostForMonth;
                    cmd.Parameters.Add("@RecruitDate", System.Data.SqlDbType.Date).Value = this.RecruitDate;


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
