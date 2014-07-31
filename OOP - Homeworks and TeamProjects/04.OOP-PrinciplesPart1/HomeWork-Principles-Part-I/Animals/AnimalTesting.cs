namespace Animals
{
    using System;
    public class AnimalTesting
    {
        static void Main()
        {
            Cat[] cats = 
            { 
                new Cat("Puhcho", "male", 7), 
                new Cat("Trolcho", "male", 4), 
                new Cat("Kazablanka", "female", 3) 
            };
            Console.WriteLine("Average Age Of Cats Is : {0:F2}", Animal.AverageAge(cats));

            Dog[] Dogs =
            {
                new Dog("Mecho","male",3),
                new Dog("Sharo","male",6),
                new Dog("Mecho","male",10)
            };
            Console.WriteLine("Dogs overage is: {0:F2}", Animal.AverageAge(Dogs));
            Frog[] Frogs =
            {
                new Frog("Malcho","male",2),
                new Frog("Gencho","male",6),
                new Frog("Pencho","male",4)
            };
            Console.WriteLine("Frogs overage is: {0:F2}", Animal.AverageAge(Frogs));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("ANIMALS SOUNDS");
            Console.WriteLine();

            cats[0].MakeSound();
            Dogs[1].MakeSound();
            Frogs[2].MakeSound();
            Console.WriteLine();
            Console.WriteLine("TOM CAT");
            TomCat topurko = new TomCat("Malkiqt", 2);
            topurko.MakeSound();
            Console.WriteLine(topurko.Sex);
            Console.WriteLine();
            Kitten milka = new Kitten("Sladuranka", 3);
            milka.MakeSound();
            Console.WriteLine(milka.Sex);
        }
    }
}
