using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace hw6t
{
    internal class DBConnection
    {
        string strCon = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DB;Integrated Security=True;Encrypt=False;Trust Server Certificate=True";
        string strCmd;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;

        // Ctor
        public DBConnection()
        {

        }

        // Methods
        public string ReadItemTable()
        {
            strCmd = " SELECT * " +
                " FROM TBItem ";
            string res = "";
            con = new SqlConnection(strCon);
            cmd = new SqlCommand(strCmd, con);
           
            con.Open();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int code = (int)reader["Code"];
            string name = reader["Name"].ToString();
            string description = reader["Description"].ToString();
            int price = (int)reader["Price"];
           
                res += $"Code: {code}, Name: {name}, Description: {description}, Price: {price}\n";
            }
            con.Close();
            return res;

        }

        public int AddItemToDB(Item item)
        {
           strCmd = " INSERT INTO TBItem (Name, Description, Price) " +
             $" VALUES ('{item.Name}', '{item.Description}', {item.Price}) ";
            int rowsAffected = 0;
            con = new SqlConnection(strCon);
            cmd = new SqlCommand(strCmd, con);
            con.Open();
            rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;

        }

        public int DeleteItemFromDB(int code)
        {
            strCmd = " DELETE FROM TBItem  " +
             $" WHERE CODE = {code} ";
            int rowsAffected = 0;
            con = new SqlConnection(strCon);
            cmd = new SqlCommand(strCmd, con);
            con.Open();
            rowsAffected = cmd.ExecuteNonQuery();
            con.Close();
            return rowsAffected;
        }
    }
}
