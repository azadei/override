using System;

namespace ConsoleApp11
{
    public sealed class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }

        public Person(string name, string surname, int age, int weight, int height)


        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Weight = weight;
            this.Height = height;

        }
        public override string ToString()
        {
            return Name + " " + Surname + " " + Age + " " + Weight + " " + Height;
        }


        public class Program
        {
            static void Main(string[] args)
            {
                Person p = new("Azad", "Ibrahimli", 31, 170, 79);
                Console.WriteLine(p);
            }







        }

    }

}


