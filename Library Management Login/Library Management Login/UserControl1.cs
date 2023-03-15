using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Library_Management_Login
{
    public class UserControl1
    {
        public string er, ut;
        SqlCommand com;
        SqlDataAdapter da;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HKHCBLN;Initial Catalog=UserregistrationDB;Integrated Security=True");
        public string create(string AIUBId, string Name, string password, string mail, string Phonenumber, string gender,string address,string birthdate, string UserType)
        {
            con.Open();
            try
            {
                com = new SqlCommand("INSERT INTO SignUp (AIUBId,Name,password,mail,Phonenumber,gender,address,birthdate,UserType) values (@AIUBId,@Name,@password,@mail,@Phonenumber,@gender,@address,@birthdate,@UserType)", con);
                com.Parameters.AddWithValue("@AIUBId", AIUBId);
                com.Parameters.AddWithValue("@Name", Name);
                com.Parameters.AddWithValue("@password", password);
                com.Parameters.AddWithValue("@mail", mail);
                com.Parameters.AddWithValue("@Phonenumber", Phonenumber);
                com.Parameters.AddWithValue("@gender", gender);
                com.Parameters.AddWithValue("@address", address);
                com.Parameters.AddWithValue("@birthdate", birthdate);
                com.Parameters.AddWithValue("@UserType", UserType);
                com.ExecuteNonQuery();
                return "Info Added";
            }

            catch (Exception ex)
            {
               er = (ex.Message);
                return er;
            }
            con.Close();
        }
    }
}
