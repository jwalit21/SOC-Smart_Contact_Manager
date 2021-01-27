using Backend_Service.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Configuration;

namespace Backend_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class AccountService : IAccountService
    {
        SqlConnection conn;
        SqlCommand cmd;

        void dbInit()
        {
            var connectionString = WebConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            conn = new SqlConnection(connectionString);
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }
        public User Login(User user)
        {
            dbInit();
            cmd.CommandText = "SELECT * FROM [Users] WHERE Email=@Email and Password=@Password";
            SqlParameter param1 = new SqlParameter("@Email", user.Email);
            SqlParameter param2 = new SqlParameter("@Password", user.Password);
            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            conn.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            User fetchedUser = null;
            while (sqlDataReader.Read())
            {
                fetchedUser = new User();
                fetchedUser.UserId = sqlDataReader.GetInt32(0);
                fetchedUser.Email = sqlDataReader.GetString(1);
                fetchedUser.Name = sqlDataReader.GetString(2);
                fetchedUser.PhoneNumber = sqlDataReader.GetString(4);
            }
            sqlDataReader.Close();
            conn.Close();
            return fetchedUser;
        }

        public void Logout(User user)
        {
            throw new NotImplementedException();
        }

        public bool Register(User user)
        {
            dbInit();
            cmd.CommandText = "Insert into [Users] values(@Email,@Name,@Password,@PhoneNumber)";
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@Name", user.Name);
            cmd.Parameters.AddWithValue("@Password", user.Password);
            cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);

            conn.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                conn.Close();
                return false;
            }
            conn.Close();
            return true;
        }
    }
}
