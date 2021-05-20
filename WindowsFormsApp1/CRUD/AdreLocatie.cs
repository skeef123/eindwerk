using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace WindowsFormsApp1.CRUD
{
    class AdreLocatie
    {
        //voorbeeld van hoe te gebruiken CRUD
        //moet worden ingevuld met correcte variablen ect....
        private static string _connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=TestDb1.mdf;Integrated Security=True;Connect Timeout=30";
        public static void Update(AdreLocatie adresLocatie)
        {
            var conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                string sql = $"UPDATE CartLine SET ProductId = " ;
                var updateCommand = new SqlCommand(sql, conn);
                updateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }
        public static int Insert(List<AdreLocatie> adresLocatie)
        {
            Int32 id = 0;
            string sql = "INSERT INTO adresLocatie ( data ) OUTPUT INSERTED.ID VALUES ( @data )";
            using (SqlConnection conn = new SqlConnection(_connStr))
            {
                var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@Name", SqlDbType.NVarChar);
                try
                {
                    conn.Open();
                    foreach (var category in adresLocatie)
                    {
                        //cmd.Parameters["@data"].Value = category.Name;
                        //id = (Int32)cmd.ExecuteScalar();
                        //category.CategoryId = id;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return id;
        }

        public static void Delete(AdreLocatie adreLocatie)
        {
            var conn = new SqlConnection(_connStr);
            try
            {
                //conn.Open();
                //string sql = $"DELETE FROM Category WHERE CategoryId = " + category.CategoryId;
                //var updateCommand = new SqlCommand(sql, conn);
                //updateCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        public static bool Exists(AdreLocatie adreLocatie)
        {
            if (category.CategoryId <= 0 && string.IsNullOrEmpty(category.Name)) return false;

            int count = 0;
            var conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                string sql = "SELECT CategoryId FROM Category WHERE ";
                if (category.CategoryId != 0)
                    sql += " CategoryId = " + category.CategoryId;
                else if (!string.IsNullOrEmpty(category.Name))
                    sql += " Name = '" + category.Name + "'";
                var command = new SqlCommand(sql, conn);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        category.CategoryId = (int)dataReader[0];
                        ++count;
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return false;
        }

        public static bool Select(AdreLocatie adreLocatie)
        {
            int count = 0;
            var conn = new SqlConnection(_connStr);
            try
            {
                conn.Open();
                string sql = "SELECT CategoryId, Name FROM Category WHERE ";
                if (category.CategoryId != 0)
                    sql += " CategoryId = " + category.CategoryId;
                else if (!string.IsNullOrEmpty(category.Name))
                    sql += " Name = '" + category.Name + "'";
                var command = new SqlCommand(sql, conn);
                SqlDataReader dataReader = command.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        category.CategoryId = (int)dataReader["CategoryId"];
                        category.Name = (string)dataReader["Name"];
                        ++count;
                    }
                    return true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return false;
        }

    }
}
