namespace Task_1To3_StudentInfo
{
    using System;
    public class StudentTest
    {
        public static void Main()
        {
            var pesho = new Student("Pesho", "Tonev", "Geshov", "1016982","Sofia , kv.Hadji Dimityr, bl.109" ,
                "+359888568231", "Peshkata@abv.bg", 
                "3", Specialties.Hacker, Faculties.Management, 
                University.UniversityOfChicago);

            // Testing ToString Method
            Console.WriteLine("ToString Method works like that:\r\n" + pesho.ToString());
            Console.WriteLine(new string('-', 50));

            var gosho = new Student("Gosho", "Panayotov", "Toshev", "1013399", 
                "Plovdiv, ul.Rekata, bl.999", "+359888776622", "Gosho@gmail.com", "2", 
                Specialties.Dealer, Faculties.HumanitiesArtsAndSocialSciences, 
                University.Princeton);

            // Testing Clone() Method
            Console.WriteLine("Original:\r\n" + pesho + System.Environment.NewLine);

            Student cloning = pesho.Clone();

            Console.WriteLine("Cloned:\r\n" + cloning + System.Environment.NewLine);
            cloning.FirstName = "Stamat";

            Console.WriteLine("As u can see the first name changed only in the cloned version");
            Console.WriteLine(pesho + System.Environment.NewLine + cloning + System.Environment.NewLine);


        }
    }
}
