using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".......Personal Information.......\n");

            Console.WriteLine("Please enter your name:");
            var name = Console.ReadLine();

            Console.WriteLine("Please enter your address:");
            var address = Console.ReadLine();

            Console.WriteLine("Please enter your mobile number:");
            var mobile = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your date of birth:");
            var dateOfBirth = Console.ReadLine();

            Console.WriteLine("Please enter your age:");
            var age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nName: " + name);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Mobile: 0" + mobile);
            Console.WriteLine("Date of Birth: " + dateOfBirth);
            Console.WriteLine("Age: " + age);

        }
    }
}
