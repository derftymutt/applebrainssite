using AppleBrainsSite.Domain;
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

        public List<Fruit> GetAll()
        {
            List<Fruit> list = null;

            string connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.CommandText = "dbo.Fruits_SelectAll";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conn;
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            reader.Read();

                            Fruit fruit = new Fruit();
                            int startingIndex = 0;

                            if (list == null)
                            {
                                list = new List<Fruit>();
                            }

                           // while (reader.Read())
                       //     {
                            fruit.Id = reader.GetInt32(startingIndex++);
                            fruit.Name = reader.GetString(startingIndex++);
                            fruit.Image = reader.GetString(startingIndex++);
                            fruit.UserId = reader.GetString(startingIndex++);
                            fruit.DateCreated = reader.GetDateTime(startingIndex++);
                            fruit.DateModfied = reader.GetDateTime(startingIndex++);
                          //  }
                            

                            list.Add(fruit);

                            

                        }

                    }
                 
                    
                }
            }
           

            return list;
        }
    }
}