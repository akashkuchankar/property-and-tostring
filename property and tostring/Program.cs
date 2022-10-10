using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace property_and_tostring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //course cs = new course(12,1200000,"Akash");
            //Console.WriteLine(cs);

            // course1 c1 = new course1();
            // c1.Id = 12;
            // c1.Fees = 12000000;
            // c1.Name = ".Net";
            //// Console.WriteLine(c1.Name+""+c1.Fees);
            // Console.WriteLine(c1);

            // course1 c2 = new course1 { Id = 13, Fees = 12000000, Name = ".Net" };
            // Console.WriteLine(c2);

            // student st = new student(12, 78.65, "Akash");
            //Console.WriteLine(st);

            //student1 st = new student1();
            //st.Id = 12;
            //st.Percentage  = 74.34;
            //st.Name = "Akash";
            //// Console.WriteLine(c1.Name+""+c1.Fees);
            //Console.WriteLine(st);

            //student1 st1= new student1 { Id = 13, Percentage=74.34, Name = ".Net" };
            //Console.WriteLine(st1);

            //employee em = new employee(12,1200000,"Akash");
            //Console.WriteLine();

            employee1 em = new employee1();
            em.Id = 1;
            em.Salary = 12340000;
            em.Name = "Akash";
            Console.WriteLine(em);

            employee1 em2 = new employee1{Id = 2, Salary = 1234000, Name = "Akash"};
            Console.WriteLine(em2);
        }
    }
}
