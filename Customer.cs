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
        //public void setName(string name)
        //{
        //    this.name = name;
        //}
        //public string getName()
        //{
        //    return this.name;
        //}

        //public void setGender(string gender)
        //{
        //    this.gender = gender;
        //}

        //public string getGender()
        //{
        //    return this.gender;
        //}

        //public void setAge(int age)
        //{
        //    this.age = age;
        //}

        //public int getAge()
        //{
        //    return this.age;
        //}

        //public void setBirthdate(string birthdate)
        //{
        //    this.birthdate = birthdate;
        //}

        //public string getBirthdate()
        //{
        //    return this.birthdate;
        //}

        //public void setCStatus(string civil_status)
        //{
        //    this.civil_status = civil_status;
        //}
        //public string getCStatus()
        //{
        //    return this.civil_status;
        //}

        //public void setAddress(string address)
        //{
        //    this.address = address;
        //}
        //public string getAddress()
        //{
        //    return this.address;
        //}
        //public void setCNumber(string contact_number)
        //{
        //    this.contact_number = contact_number;
        //}

        //public string getCNumber()
        //{
        //    return this.contact_number;
        //}
        //public void setEmail(string email)
        //{
        //    this.email = email;
        //}
        //public string getEmail()
        //{
        //    return this.email;
        //}

        //public void setId(string id)
        //{
        //    this.id = id;
        //}

        //public string getId()
        //{
        //    return this.id;
        //}

        //public string accNum
        //{
        //    get { return this.accNum; }
        //    set { this.accNum = value; }
        //}

        //public void setImagePath(string imagePath)
        //{
        //    this.imagePath = imagePath;
        //}
        //public string getImagePath()
        //{
        //    return this.imagePath;
        //}

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
