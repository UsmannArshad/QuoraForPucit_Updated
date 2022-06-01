using Microsoft.Data.SqlClient;
namespace QuoraForPucit.Models
{
    public class UserRepository
    {
        public static void AddUser(User u)
        {
            var context = new QuoraForPucit_DBContext();
            context.Users.Add(u);
            context.SaveChanges();
        }
        public static bool IsUsernameUnique(string username)
        {
            string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuoraForPucit_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "Select * from Users where Username=@u";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("u", username);
            cmd.Parameters.Add(p1);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool CheckCredentials(string username, int pwd)
        {
            string constring = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QuoraForPucit_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            string query = "Select * from Users where Username=@u AND Password=@p";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlParameter p1 = new SqlParameter("u", username);
            SqlParameter p2 = new SqlParameter("p", pwd);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
