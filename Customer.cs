using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WONG_BANKING
{
    public class Customer
    {
        

        public static List<Customer> _customerListInstance;

        public static List<Customer> getInstance()
        {
            if (_customerListInstance == null)
            {
                _customerListInstance = new List<Customer>();
            }
            return _customerListInstance;
        }
        public string CustomerID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
        public string Address { get; set; }
        public string CivilStatus { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
        public string AccNum { get; set; }

        public double Balance { get; set; }

        public void saveQuery()
        {
            using (SqlConnection conn = DBHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Customers VALUES (@CustomerID,  @AccNum, @Name, @Gender, @Age, @Birthdate, @Address, @CivilStatus, @ContactNumber, @Email, @ImagePath, @Balance)";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                cmd.Parameters.AddWithValue("@AccNum", AccNum);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@Birthdate", Birthdate);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@CivilStatus", CivilStatus);
                cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
                cmd.Parameters.AddWithValue("@Balance", Balance);

                cmd.ExecuteNonQuery();
            }
        }


    }
}
