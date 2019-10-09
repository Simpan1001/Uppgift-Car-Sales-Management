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
        //List<Car> myCars = new List<Car>();
        SqlConnection connect = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=model;Integrated Security=True");

        public void Save(Car c) 
        {
            connect.Open();

            SqlCommand cm = new SqlCommand("INSERT INTO CarProperties(Brand, Model, Number, Color, HP, Distance) VALUES " +
                "('" + c.Brand + "', '" + c.Model + "', '" + c.Number + "', '" + c.Color + "', '" + c.HP + "', '" + c.Distance + "');");
            cm.Connection = connect;
            cm.ExecuteNonQuery();

            connect.Close();
        }
        public int Count() 
        {
            connect.Open();
            SqlCommand cm = new SqlCommand("SELECT COUNT(Brand) FROM CarProperties;");
            cm.Connection = connect;
            //cm.ExecuteNonQuery();
            int a = int.Parse(cm.ExecuteScalar().ToString());
            connect.Close();
            return a;
        }
        public void Search(string temp) 
        {
            connect.Open();

            SqlCommand c = new SqlCommand("SELECT COUNT(Brand) FROM CarProperties WHERE Brand = " + temp + ";");
            c.Connection = connect;
            //cm.ExecuteNonQuery();
            int a = int.Parse(c.ExecuteScalar().ToString());

            for (int i = 0; i < a; i++)
            {
                SqlCommand cm = new SqlCommand("SELECT Brand FROM CarProperties WHERE Brand = " + temp + ";");
                cm.Connection = connect;
                cm.ExecuteNonQuery();
            }
            

            connect.Close();
        }
    }
}
