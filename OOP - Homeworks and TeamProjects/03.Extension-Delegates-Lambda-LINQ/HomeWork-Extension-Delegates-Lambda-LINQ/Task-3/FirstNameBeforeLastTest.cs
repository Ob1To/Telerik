/*
 * Write a method that from a given array of students finds 
 * all students whose first name is before its last name 
 * alphabetically. Use LINQ query operators.
*/

namespace Task_3
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class FirstNameBeforeLastTest
    {
        public static void Print(IEnumerable list)
        {
            foreach (var student in list)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }

        
        static void Main()
        {

            List<Student> students = new List<Student>();

            students.Add(new Student("Angol", "Mirchev",18));
            students.Add(new Student("Zarko", "Temenugov",22));
            students.Add(new Student("Faraona", "Murdjev",33));
            students.Add(new Student("Velizar", "Petrov",50));
            students.Add(new Student("Jorkata", "Peckov",12));

            
            var firstNameBefore = from student in students where student.FirstName.CompareTo(student.LastName) < 0 select student;

            Print(firstNameBefore);
        }
    }
}
