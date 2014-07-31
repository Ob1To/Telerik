namespace Task_5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Task_3;

    class ExtMethodsOrderByAndThenBy
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Angol", "Mirchev", 19));
            students.Add(new Student("Zarko", "Temenugov", 22));
            students.Add(new Student("Velizar", "Manolov", 26));
            students.Add(new Student("Faraona", "Murdjev", 33));
            students.Add(new Student("Velizar", "Petrov", 50));
            students.Add(new Student("Jorkata", "Peckov", 12));

            var studentsOrderByDescendingLambda = students.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.LastName);

            Console.WriteLine("This is with lambda:\n");
            Task_3.FirstNameBeforeLastTest.Print(studentsOrderByDescendingLambda);

            Console.WriteLine();

            Console.WriteLine("And now without:\n");
            var studentsOrderByDescendingLINQ = from student in students 
                                                orderby student.FirstName descending, 
                                                student.LastName descending 
                                                select student;

            Task_3.FirstNameBeforeLastTest.Print(studentsOrderByDescendingLINQ);
        }
    }
}
