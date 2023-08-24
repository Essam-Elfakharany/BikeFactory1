using BikeFactory1.Models;
using BikeFactory1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Dapper;



namespace BikeFactory1.Data
{
    public static class BikeData
    {
        public static Bike SearchById(int bikeId, string cnString)
        {
            Bike result = null;
            using (var cn = new SqlConnection(cnString))
            {
                using (var cmd = new SqlCommand("SELECT * FROM Bikes WHERE Id=@Id", cn))
                {
                    cmd.Parameters.Add(new SqlParameter("Id", System.Data.SqlDbType.Int) { Value = bikeId });
                    cn.Open();
                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            dr.Read();
                            result = new Bike()
                            {
                                Id = Convert.ToInt32(dr["Id"]),
                                Name = Convert.ToString(dr["Name"]),
                                SuspensionType = (ESuspensionType)dr["SuspensionType"],
                                TireType = (ETireType)dr["TireType"]
                            };
                        }
                    }
                }
                cn.Close();
            }
            return result;
        }

        public static List<Bike> GetList( string cnString)
        {
            var result = new List<Bike>();

            using (var cn = new SqlConnection(cnString))
            {
                result = cn.Query<Bike>(
                    sql: "SELECT * FROM Bikes"
                   // param: new { }
                    ).AsList() ;
               
            }
            return result;
        }

        public static void Insert(Bike bike, string cnString)
        {
            using (var cn = new SqlConnection(cnString))
            {
                cn.Execute(
                    sql: "INSERT INTO Bikes (Name, SuspensionType, TireType) VALUES (@Name, @SuspensionType, @TireType)",
                    param: new
                    {
                        Name = bike.Name,
                        SuspensionType = bike.SuspensionType,
                        TireType = bike.TireType,
              
                    }
                );
            }
        }

        public static void Update(Bike bike, string cnString)
        {
            using (var cn = new SqlConnection(cnString))
            {
                cn.Execute(
                    sql: "UPDATE Bikes SET Name=@Name, SuspensionType =@SuspensionType, TireType = @TireType WHERE Id=@Id",
                    param: new
                    {
                        Id =bike.Id,
                        Name = bike.Name,
                        SuspensionType = bike.SuspensionType,
                        TireType = bike.TireType,

                    }
                );
            }
        }

        public static void Delete(int bikeId, string cnString)
        {
            using (var cn = new SqlConnection(cnString))
            {
                cn.Execute(
                    sql: "DELETE Bikes WHERE Id=@Id",
                    param: new { Id = bikeId }
                );
            }
        }

    }
}