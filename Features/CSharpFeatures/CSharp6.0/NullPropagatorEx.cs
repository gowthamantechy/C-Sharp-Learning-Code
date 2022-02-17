using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharpFeatures.CSharp6._0
{
    public class NullPropagatorEx
    {


        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Siddharth";
            student1.rollno = 12;

            student1.studentdetails = new Details()
            {

                Address = "Lakshmi Nagar New Delhi India",
                Email = "abcd@xyz.com"

            };

            Student student2 = new Student();
            student2.Name = "Aditya";
            student2.rollno = 05;
            student2.studentdetails = new Details()
            { Address = null, Email = null };
            WriteLine("Student 1:\n");
            WriteLine(student1?.Name ?? "No Name");
            WriteLine(student1?.studentdetails?.Address ?? "No Address");
            WriteLine(student1?.studentdetails?.Email ?? "No Email provided");
            WriteLine("\nStudent 2:\n");
            WriteLine(student2?.Name ?? "No Name");
            WriteLine(student2?.studentdetails?.Address ?? "No Address");
            WriteLine(student2?.studentdetails?.Email ?? "No Email provided");
            ReadLine();

        }

        
    }


    public class Student
    {
        public string Name { get; set; }
        public int rollno { get; set; }
        public Details studentdetails { get; set; }
    }
    public class Details
    {
        public string Address { get; set; }
        public string Email { get; set; }
    }
}
