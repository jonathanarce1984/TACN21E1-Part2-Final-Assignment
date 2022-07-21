/*
 * Jonathan Arce
 * 
 * 
 * Define Code-First
 * In Code-First approach, you start creating domain classes first. Then the Entity Framework (EF) will create the database based on your domain classes and configuration. 
 * In Code-first, you don't need to worry about designing your database first. It will be automatically created for you by the Entity Framework based on your domain classes code. 
 * 
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCode_FirstAssignmentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student App
            Console.WriteLine("TACN21E1 - C# and .NET Framework - Part 2 Final Assignment");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Entity Framework Code-First Student app");
            Console.WriteLine("Enter Student Information below\n");

            // Ask the user to Enter Student Information.
            Console.WriteLine("Student Name:");
            String studentName = Console.ReadLine();
            Console.WriteLine("Student Date Of Birth in format MM/DD/YYYY: ");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Student Height:");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Student Weight:");
            float weight = float.Parse(Console.ReadLine());

            using (var ctx = new StudentContext())
            {
                
                var stud = new Student() { StudentName = studentName, DateOfBirth = dateOfBirth, Height = height, Weight = weight };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.WriteLine("Student Sucessfully Saved!");
                Console.ReadLine();
            }
        }
    }
}
