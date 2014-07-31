namespace Animals
{
    using System;
    public class Dog : Animal, ISound
    {
        public Dog(string name , string sex , int age) : base(name,sex,age)
        {

        }
        public void MakeSound()
        {
            Console.WriteLine(Name + " said Bauuu Bau bau wuf wuf ! ! !");
        }
    }
}
