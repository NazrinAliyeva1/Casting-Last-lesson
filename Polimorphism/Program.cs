using Polimorphism.Interfaces;
using Polimorphism.Models;

namespace Polimorphism
{
    class Program
    {
        static void Main()
        {
            //Shark akula = new Shark("Akula");
            //Eagle qartal = new Eagle("Shahin");
            //Cat mestan = new("Şahin"); 
            //Animal[] animals = { akula, qartal, mestan, new Chicken("asd") };
            ////upcasting
            //Animal a = new Shark("Akula");
            ////downcasting 

            //foreach(var animal in animals)
            //{
            //if(animal is Domestic)
            //    {
            //    Domestic domestic = (Domestic)animal;
            //    domestic.Pet();
            //}
            //else if(animal is Dog)
            //{
            //    Dog dog = (Dog)animal;
            //    dog.Eat();
            //}
            //Bird bird = animal as Bird;
            //if(bird != null)
            //{
            //    bird.Fly();
            //}
            //diger bir usul burda avtomatik obyektini ozu yaradir:
            //if(animal is Eagle eagle)
            //{
            //    eagle.Eat();
            //}
            //}


            // Asagidakilar Polimorphism dersinden qalanlardir.
            //a.Eat();
            //foreach (var animal in animals)
            //{
            //    animal.Eat();
            //}
            //ISwim dog = new Dog("Toplan");
            //ISwim fish = new Shark("Akula");
            //ISwim[] swimmers = new ISwim[] { fish, dog };
            //foreach (var swimmer in swimmers)
            //{
            //    swimmer.Swim();
            //}
            //IDivide c = new Calculate();
            //Console.WriteLine(c.Divide(1, 5));


            //Operator overload


            Student nazim = new()
            {
                Name = "Nazim",
                Surname = "Ceferli",
                Age = 35 
            };
            Student zumrud = new()
            {
                Name = "Zumrud",
                Surname = "Kerimli",
                Age = 21
            };
            Student nazim2 = new()
            {
                Name = "Nazim",
                Surname = "Ceferli",
                Age = 35
            };
            //Console.WriteLine(nazim==zumrud); //true false verecek.
            var a = nazim2 == nazim;
            Console.WriteLine(a);

        }
    }
    class Student
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

        //Age yazmadan bir basa adlari yazmaq isteyirikse:

        //public static bool operator >(Student a, Student b)
        //{
        //    return a.Age > b.Age;
        //}
        //public static bool operator <(Student a, Student b)
        //{
        //    return a.Age < b.Age;
        //}

        public static bool operator ==(Student a, Student b)
        {
            //a.Equals(b);//kimi yaz da da bilerik bunu override ede bilerik class daxilinde 
            if (a.Name != b.Name || a.Surname != b.Surname
                || a.Age != b.Age) return false;
            return true;
        }
        public static bool operator !=(Student a, Student b)
        {
            return !(a == b);
        }

    }

}
