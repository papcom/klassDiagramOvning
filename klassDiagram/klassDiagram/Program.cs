using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klassDiagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, email;
            char gender;
            Console.Write("enter name: ");
            name = Console.ReadLine();
            Console.Clear();
            Console.Write("enter email: ");
            email = Console.ReadLine();
            Console.Clear();
            Console.Write("enter gender (m/f): ");
            gender = char.Parse(Console.ReadLine());
            Console.Clear();
            Author atur = new Author(name, email, gender);
            Console.WriteLine(atur.toString());
            Console.ReadLine();
        }
    }
}
