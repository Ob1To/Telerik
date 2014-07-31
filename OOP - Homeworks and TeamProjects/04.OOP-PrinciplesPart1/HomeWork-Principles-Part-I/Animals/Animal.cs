namespace Animals
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public Animal(string name, string sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        public static double AverageAge(Animal[] array)
        {
            double averageAge = 0;
            foreach (var animal in array)
            {
                averageAge += animal.Age;
            }
            averageAge = averageAge / array.Length;
            return averageAge;
        }
    }
}
