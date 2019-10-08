using CarObject;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryForm
{
    public class Repository
    {
        List<Car> myCars = new List<Car>();
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=model;Integrated Security=True");

        public void Save(Car c) 
        {
            connect.Open();

            SqlCommand cm = new SqlCommand("INSERT INTO CarProperties(Brand, Model) VALUES ('" + c.Brand + "', '" + c.Model + "');");
            cm.Connection = connect;
            cm.ExecuteNonQuery();

            connect.Close();
        }
    }
}
