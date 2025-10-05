using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WONG_BANKING
{
    public class Customer
    {
        private string name, gender, birthdate, civil_status, address, contact_number, email, imagePath, id;
        private int age;

        public static List<Customer> _customerListInstance;

        public static List<Customer> getInstance()
        {
            if (_customerListInstance == null)
            {
                _customerListInstance = new List<Customer>();
            }
            return _customerListInstance;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }

        public void setGender(string gender)
        {
            this.gender = gender;
        }

        public string getGender()
        {
            return this.gender;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return this.age;
        }

        public void setBirthdate(string birthdate)
        {
            this.birthdate = birthdate;
        }

        public string getBirthdate()
        {
            return this.birthdate;
        }

        public void setCStatus(string civil_status)
        {
            this.civil_status = civil_status;
        }
        public string getCStatus()
        {
            return this.civil_status;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }
        public string getAddress()
        {
            return this.address;
        }
        public void setCNumber(string contact_number)
        {
            this.contact_number = contact_number;
        }

        public string getCNumber()
        {
            return this.contact_number;
        }
        public void setEmail(string email)
        {
            this.email = email;
        }
        public string getEmail()
        {
            return this.email;
        }

        public void setId(string id)
        {
            this.id = id;
        }

        public string getId()
        {
            return this.id;
        }
        
        public void setImagePath(string imagePath)
        {
            this.imagePath = imagePath;
        }
        public string getImagePath()
        {
            return this.imagePath;
        }





    }
}
