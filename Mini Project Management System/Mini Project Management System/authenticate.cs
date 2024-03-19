using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project_Management_System
{
    public class authenticate
    {

        public class User
        {
            public string Username { get; set; } // User's username property
            public byte[] Image { get; set; } // User's image property (binary data)
            public string Email { get; set; }
            public string Gender { get; set; }

        }


        public class DatabaseManager
        {
            // Method to authenticate user
            public static User AuthenticateUser(string username, string password)
            {
                User user = RetrieveUserInformation(username, password);
                return user;
            }

            private static User RetrieveUserInformation(string username, string password)
            {
                // Using statement ensures proper disposal of resources
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=LAB109PC21\SQLEXPRESS; Initial Catalog=CompanyManagement; Integrated Security=True;"))
                {
                    sqlCon.Open();

                    string loginQuery = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
                    string imgQuery = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password";


                    using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                    {
                        using (SqlCommand imgCmd = new SqlCommand(imgQuery, sqlCon))
                        {
                            loginCmd.CommandType = CommandType.Text;
                            imgCmd.CommandType = CommandType.Text;

                            loginCmd.Parameters.AddWithValue("@Username", username);
                            loginCmd.Parameters.AddWithValue("@Password", password);
                            imgCmd.Parameters.AddWithValue("@Username", username);
                            imgCmd.Parameters.AddWithValue("@Password", password);

                            int count = Convert.ToInt32(loginCmd.ExecuteScalar());

                            if (count == 1)
                            {
                                using (SqlDataReader reader = imgCmd.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        byte[] imageData = reader["img"] as byte[];
                                        string email = reader["email"].ToString();
                                        string gender = reader["gender"].ToString();

                                        return new User { Username = username, Email = email, Image = imageData, Gender = gender };

                                    }
                                }
                            }

                            return null; // Return null if no user is found with the specified username and password
                        }
                    }
                }
            }
        }
    }
}
