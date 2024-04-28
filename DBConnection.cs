using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace porches
{
    class DBConnection
    {
        SqlConnection con;
        SqlCommand cmd;

        public DBConnection()
        {
            con = new SqlConnection("Data Source = DESKTOP - 2ON1A63; Initial Catalog = tesla; Integrated Security = True;");
        }

        public int Save_Edit_Delete(String q)
        {
            con.Open();
            cmd = new SqlCommand(q, con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public DataSet Dsipaly(string q)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            con.Close();
            return ds;

        }

        public int Scalar(string q)
        {
            con.Open();
            cmd = new SqlCommand(q, con);
            int i = (int)cmd.ExecuteScalar();
            con.Close();
            return i;
        }

        public string getname(string q)
        {
            
            con.Open();
            cmd = new SqlCommand(q, con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return reader.GetString(0);
            } 
            con.Close();
            return null;
        }
    }
}
