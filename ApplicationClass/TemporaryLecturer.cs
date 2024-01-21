using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationClass
{
    public class TemporaryLecturer : Lecturer
    {
        public DateTime AgreementStartDate { get; set; }

        public DateTime AgreementEndDate { get; set; }

        public double Cost  { get; set; }



        public override void Save()
        {
            try
            {
                base.Save();

                using (SqlConnection conn = new SqlConnection(MainController.Instance.GetConnectionString()))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("TemporaryLecturer_Save", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = base.Id;
                    cmd.Parameters.Add("@Cost", System.Data.SqlDbType.VarChar).Value = this.Cost;
                    cmd.Parameters.Add("@AgreementStartDate", System.Data.SqlDbType.Date).Value = this.AgreementStartDate;
                    cmd.Parameters.Add("@AgreementEndDate", System.Data.SqlDbType.Date).Value = this.AgreementEndDate;


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
                    SqlCommand cmd = new SqlCommand("TemporaryLecturer_Save", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = base.Id;
                    cmd.Parameters.Add("@Cost", System.Data.SqlDbType.VarChar).Value = this.Cost;
                    cmd.Parameters.Add("@AgreementStartDate", System.Data.SqlDbType.Date).Value = this.AgreementStartDate;
                    cmd.Parameters.Add("@AgreementEndDate", System.Data.SqlDbType.Date).Value = this.AgreementEndDate;


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
