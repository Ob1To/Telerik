namespace Task_9
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class TestingTheStudents
    {
        public static void TaskDescription(string taskNumber) // Methods for separation, so its looking a bit more nicer
        {
            string sln = taskNumber;
            Console.WriteLine("{0," + ((Console.WindowWidth / 2) + sln.Length / 2) + "}", sln);
            Console.WriteLine();
        }
        
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Toshko","Afrikanski",101613,"+359029582731","Tosheto@abv.bg",new List<int>(){3 , 2 , 6 , 4 , 4}, 2));
            students.Add(new Student("Pepi", "Marinkov", 101306, "+359887658899", "Pepi@abv.bg", new List<int>() { 5, 5, 6, 4, 5 }, 4));
            students.Add(new Student("Znaiko", "Poznaikov", 101606, "+359029336811", "Vsi4koZnam@Gmail.com", new List<int>() { 6, 6, 6, 4, 6 }, 3));
            students.Add(new Student("Nevest", "Angolov", 101111, "+359889871100", "Nevestian@yahoo.com", new List<int>() { 3, 2, 4, 2, 3 }, 2));

            // Task-9
            TaskDescription("Solution For Task-9");
            var stFromGr2Linq = from student in students where student.GroupNumber == 2 orderby student.FirstName select student;
            Task_3.FirstNameBeforeLastTest.Print(stFromGr2Linq);

            // Task-10
            TaskDescription("Solution For Task-10");
            var stFromGr2Lambda = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
            Task_3.FirstNameBeforeLastTest.Print(stFromGr2Lambda);

            // Task-11
            TaskDescription("Solution For Task-11");
            var studentWithAbv = from student in students where student.Email.EndsWith("abv.bg") select student;
            Task_3.FirstNameBeforeLastTest.Print(studentWithAbv);

            // Task-12
            TaskDescription("Solution For Task-12");
            var studentsWithTelSofia = from student in students where student.TelephoneNumber.StartsWith("+35902") select student;
            Task_3.FirstNameBeforeLastTest.Print(studentsWithTelSofia);

            // Task-13
            TaskDescription("Solution For Task-13");
            var studentsWithExcellent = from student in students where student.Marks.Any() select new { FullName = student.FirstName + " " + student.LastName, Marks = string.Join(" ",student.Marks) };
            Task_3.FirstNameBeforeLastTest.Print(studentsWithExcellent);

            // Task-14
            TaskDescription("Solution For Task-14");
            var stupidStudents = students.Where(st => st.Marks.FindAll(mark => mark == 2).Count == 2);
            Task_3.FirstNameBeforeLastTest.Print(stupidStudents);

            // Task-15
            TaskDescription("Solution For Task-15");
            var enrolled2006 = students.Where(st => st.FN % 100 == 6).Select(st => string.Join(", ", st.Marks));
            Task_3.FirstNameBeforeLastTest.Print(enrolled2006);

            // Task-18
            TaskDescription("Solution For Task-18");
            var studentsByGroupName = from student in students orderby student.GroupNumber select student;
            Task_3.FirstNameBeforeLastTest.Print(studentsByGroupName);

            // Task-19
            TaskDescription("Solution For Task-19");
            var studentByGroupNameLambda = students.OrderBy(x => x.GroupNumber);
            Task_3.FirstNameBeforeLastTest.Print(studentByGroupNameLambda);
        }
    }
}
