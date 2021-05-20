using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
namespace Data
{
    public class Database
    {
        private string connectionString;
        public Database()
        {
          
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=TestDb1.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conn = new SqlConnection(connectionString);
        }
       


        public void ReadXML()
        {
            // First write something so that there is something to read ...  
            //var b = new readData { title = "Serialization Overview" };
            //var writer = new System.Xml.Serialization.XmlSerializer(typeof(readData));
            //var wfile = new System.IO.StreamWriter(@"C:\Users\tomcr\source\repos\projectRobby\Data\CrabAdr.gml");
            //writer.Serialize(wfile, b);
            //wfile.Close();

            //// Now we can read the serialized book ...  
            //System.Xml.Serialization.XmlSerializer reader =
            //    new System.Xml.Serialization.XmlSerializer(typeof(readData));
            //System.IO.StreamReader file = new System.IO.StreamReader(
            //    @"C:\Users\tomcr\source\repos\projectRobby\Data\CrabAdr.gml");
            //readData overview = (readData)reader.Deserialize(file);
            //file.Close();

            //Console.WriteLine(overview.title);

        }
    }
}
