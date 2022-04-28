using System;
using System.Collections.Generic;
using System.Linq;

namespace lesson_7_adv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 uzd---------------
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //var result = arr.Select(i => Math.Pow(i, 2));

            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            // 2 uzd---------------
            //int[] arr = { 1, -2, 3, -4, 5, -6, 7, -8, 9 };
            //var result = arr.Where(i => i > 0);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            // 3 uzd---------------
            //int[] arr = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -11, 12 };
            //var result = arr.Where(i => i > 0 && i < 10);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            // 4 uzd---------------
            //int[] arr = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -11, 12 };
            //var result = arr.OrderBy(i => i);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            // 5 uzd---------------
            //int[] arr = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -11, 12 };
            //var result = arr.OrderByDescending(i => i);
            //foreach (int i in result)
            //{
            //    Console.WriteLine(i);
            //}
            // 6 uzd---------------
            //int[] arr = { 1, -2, 3, -4, 5, -6, 7, -8, 9, -11, 12 };
            //var result = arr.Max(i => i);
            //Console.WriteLine(result);
            // 7 uzd---------------
            //List<Person> people = new List<Person>();
            //people.Add(new Person("Person1", 65));
            //people.Add(new Person("Lerson2", 10));
            //people.Add(new Person("Berson3", 15));
            //people.Add(new Person("Zerson4", 20));
            //people.Add(new Person("Kerson5", 25));
            //people.Add(new Person("Abrson6", 30));
            //people.Add(new Person("Bbrson7", 35));
            //people.Add(new Person("Hhrson8", 40));
            //people.Add(new Person("Jerson9", 45));
            //people.Add(new Person("Rerson10", 50));
            //people.Add(new Person("Aerson11", 55));

            //var names = people.Select(i => i.Name);
            //foreach (var name in names)
            //{
            //    Console.WriteLine(name);
            //}
            //var ages = people.Select(i => i.Age).OrderByDescending(i => i);
            //foreach (var age in ages)
            //{
            //    Console.WriteLine(age);
            //}
            //var namesStartingLetterA = people.Where(i => i.Name.StartsWith("A"));
            //foreach (var n in namesStartingLetterA)
            //{
            //    Console.WriteLine(n.Name);
            //}
            //var namesSortedByAge = people.Where(i => i.Age > 40).OrderBy(i => i.Name);
            //foreach (var n in namesSortedByAge)
            //{
            //    Console.WriteLine(n.Name);
            //}
            //------------------------------------------------------------
            List<Person1> people1 = new List<Person1>();

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("Suo", 8));
            animals.Add(new Animal("Kate", 12));
            animals.Add(new Animal("Triusis", 3));
            List<Animal> animals1 = new List<Animal>();
            animals.Add(new Animal("Vista", 2));
            animals.Add(new Animal("Kiaule", 1));
            animals.Add(new Animal("Zasis", 3));
            List<Animal> animals2 = new List<Animal>();
            animals.Add(new Animal("Antis", 77));
            animals.Add(new Animal("Sermonelis", 7));
            animals.Add(new Animal("Seskas", 3));

            people1.Add(new Person1("Antanas", animals));
            people1.Add(new Person1("Lukas", animals1));
            people1.Add(new Person1("Zenonas", animals2));

            var allAnimals = people1.SelectMany(i => i.Animals);
            foreach (var animal in allAnimals)
            {
                Console.WriteLine(animal.Name);
            }
            Console.WriteLine("-----------");
            var animalsStartingLetterA = allAnimals.Where(i => i.Name.StartsWith("A"));
            foreach (var animal in animalsStartingLetterA)
            {
                Console.WriteLine(animal.Name);
            }
            Console.WriteLine("-----------");
            var animalsStartingLetterAAgeMoreThan5 = allAnimals.Where(i => i.Name.StartsWith("A") && i.Age > 5);
            foreach (var a in animalsStartingLetterAAgeMoreThan5)
            {
                Console.WriteLine($"vardas: {a.Name}, amzius: {a.Age}");
            }
        }
    }
}
