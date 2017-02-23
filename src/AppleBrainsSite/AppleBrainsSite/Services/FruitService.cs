using AppleBrainsSite.Models.Requests;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AppleBrainsSite.Services
{
    public class FruitService : IFruitService
    {
        public int Create(FruitCreateRequest model)
        {
            int createId = -1;

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "dbo.Fruits_Insert";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Name", model.Name);
                    cmd.Parameters.AddWithValue("@Image", model.Image);
                    cmd.Parameters.AddWithValue("@UserId", model.UserId);

                    SqlParameter outputIdParam = new SqlParameter("@Id", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };

                    cmd.Parameters.Add(outputIdParam);

                    cmd.Connection = conn;

                    conn.Open();
                    cmd.ExecuteNonQuery();

                    createId = int.Parse(outputIdParam.Value.ToString());

                }
            }

            return createId;

        }
    }
}