
namespace Human
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class HumanTesting
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Pepi", "Nachev", 4));
            students.Add(new Student("Rosen", "Balev", 2));
            students.Add(new Student("Velizar", "Tsonev", 3));
            students.Add(new Student("Faraona", "Jelev", 4));
            students.Add(new Student("Izumrud", "Mundev", 6));
            students.Add(new Student("Mundo", "Ralev", 5));
            students.Add(new Student("Safar", "Histimqn", 3));
            students.Add(new Student("Johny", "Bravo", 6));
            students.Add(new Student("Znaiko", "Popov", 4));
            students.Add(new Student("Cvetelin", "Rozev", 2));

            var sortStudentsByGrade = students.OrderBy(st => st.Grade);

            Console.WriteLine("========== STUDENTS ==========");

            foreach (var student in sortStudentsByGrade)
            {
                Console.WriteLine("{0, -12} {1, -12} {2}",student.FirstName, student.LastName, student.Grade);
            }

            Console.WriteLine("========== WORKERS ============");

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Chudomir", "Chudov", 320, 6));
            workers.Add(new Worker("Rabotlivko", "Strashen", 500, 10));
            workers.Add(new Worker("Radomir", "Jivkov", 300, 8));
            workers.Add(new Worker("Anatoli", "Spasov", 280, 9));
            workers.Add(new Worker("Rosen", "Gacov", 290, 8));
            workers.Add(new Worker("Ivan", "Slavov", 330, 8));
            workers.Add(new Worker("Lubomir", "Petrov", 410, 9));
            workers.Add(new Worker("Martin", "Petrov", 285, 7));
            workers.Add(new Worker("Stoqn", "Jelev", 225, 7));
            workers.Add(new Worker("Myrzelcho", "Popov", 120, 5));

            workers = workers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            foreach (var worker in workers)
            {
                Console.WriteLine("{0, -12} {1, -12} {2, -5:F2} $", worker.FirstName, worker.LastName, worker.MoneyPerHour());
            }

            Console.WriteLine("========== HUMANS ==========");

            List<Human> Humans = new List<Human>();
            Humans.AddRange(students);
            Humans.AddRange(workers);

            var mergeList = Humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var human in mergeList)
            {
                Console.WriteLine("{0 , -12} {1, -12}", human.FirstName,human.LastName);
            }
        }
    }
}
