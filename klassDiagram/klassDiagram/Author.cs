using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassDiagram
{
    class Author
    {
        string name;
        string email;
        char gender;
        public Author(string name, string email, char gender)
        {
            this.name = name;
            this.email = email;
            this.gender = gender;
        }
        public string getName()
        {
            return name;
        }
        public string getEmail()
        {
            return email;
        }
        public void setEmail(string email)
        {
            email = Console.ReadLine();
        }
        public char getGender()
        {
            return gender;
        }
        public string toString()
        {
            return name + " (" + gender + ") " + "at " + email;
        }
    }
}
