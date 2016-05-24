using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public static class DataBaseOperations
    {

        public static int Createcar( int SNO,string NAME, int MODEL, int PRICE)
        {
            string cs = "server=PRANEETH;integrated security=true;database=STUDENT";
            string query = "insert into tblcars values(@SNO,@NAME,@MODEL,@PRICE)";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.Add(new SqlParameter("@SNO", SNO));
            cmd.Parameters.Add(new SqlParameter("@NAME", NAME));
            cmd.Parameters.Add(new SqlParameter("@MODEL", MODEL));
            cmd.Parameters.Add(new SqlParameter("@PRICE", PRICE));

            int c = cmd.ExecuteNonQuery();
            return c;
        }
             public static int Updatecar(int SNO, string NAME, int MODEL, int PRICE)
        {
            string cs = "server=PRANEETH;integrated security=true;database=STUDENT";
            string query = "Update tblcars set NAME=@NAME,MODEL=@MODEL,PRICE=@PRICE Where SNO=@SNO";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.Add(new SqlParameter("@SNO", SNO));
            cmd.Parameters.Add(new SqlParameter("@NAME", NAME));
            cmd.Parameters.Add(new SqlParameter("@MODEL", MODEL));
            cmd.Parameters.Add(new SqlParameter("@PRICE", PRICE));

            int c = cmd.ExecuteNonQuery();
            return c;
        }
        public static int Deletecar(int SNO)
        {
            string cs = "server= PRANEETH;integrated security=true;database=STUDENT";
            string query = "delete from tblcars Where SNO=@SNO";
            SqlConnection cn = new SqlConnection(cs);
            cn.Open();
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.Add(new SqlParameter("@SNO", SNO));
            int c = cmd.ExecuteNonQuery();
            return c;
        }
    }
} 
