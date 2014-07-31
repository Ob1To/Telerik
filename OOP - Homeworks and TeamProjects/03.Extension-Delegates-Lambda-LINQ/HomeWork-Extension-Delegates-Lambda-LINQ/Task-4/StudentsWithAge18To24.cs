namespace Task_4 
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Task_3;
    public class StudentsWithAge18To24
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Angol", "Mirchev", 19));
            students.Add(new Student("Zarko", "Temenugov", 22));
            students.Add(new Student("Faraona", "Murdjev", 33));
            students.Add(new Student("Velizar", "Petrov", 50));
            students.Add(new Student("Jorkata", "Peckov", 12));


            var ageBetween = from student in students where student.Age > 18 && student.Age < 24 select new { FirstName = student.FirstName, LastName = student.LastName }; //Creating new anonymos class for our purpose

            Task_3.FirstNameBeforeLastTest.Print(ageBetween);
        }
        
    }
}
