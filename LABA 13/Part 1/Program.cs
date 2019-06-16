using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Program
    {
        static MyZoo zoo = new MyZoo();
        static Support support = new Support();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Part1();

            Console.Clear();
            Console.WriteLine("Часть 2");
            Console.ReadKey();
            Part2();

        }

        // Раrt 1
        static void Part1()
        {
            FillRandomly();
            //GetLength();
            //AddElement();
            //GetLength();
            //RemoveElement();
            //GetLength();
           //Sort();
        }
        static void FillRandomly()
        {
            Console.WriteLine("Заполнение коллекции случайными элементами");
            Console.WriteLine();

            int size = support.InputSize();
            zoo.Fill(size);

            Console.WriteLine("Коллекция заполнена");
            Console.ReadKey();
        }
       
        static void GetLength()
        {

            Console.Clear();
            Console.WriteLine($"Объектов в коллекции: {zoo.Length}");
            Console.ReadKey();
        }
        static void AddElement()
        {
            Console.Clear();
            Console.WriteLine("Добавление элемента в коллекцию");

            KingdomAnimals animal = support.InputAnimalParameters();
            int position = zoo.AddToZoo(animal);

            Console.WriteLine($"В коллекцию добавлен объект: {animal.ToString()} " +
                $"на позицию {position}");

            Console.ReadKey();                
        }
        static void RemoveElement()
        {
            Console.Clear();
            Console.WriteLine("Удаление элемента из коллекции");
            Console.WriteLine();
            Console.Write("Удалить по индексу: ");

            int idx = Convert.ToInt32(Console.ReadLine());

            if (zoo.Remove(idx))
            {
                Console.WriteLine($"Объект с индексом {idx} удален");
            }
            else
            {
                Console.WriteLine($"Объекта с таким индексом в коллекции нет");
            }
            Console.ReadKey();
        }
        static void Sort()
        {
            Console.Clear();
            Console.WriteLine("Сортировка коллекции");
            Console.WriteLine("1. Сортировка по имени");
            zoo.SortByName();
            zoo.PrintCollection();

            Console.WriteLine();
            Console.WriteLine("2. Сортировка по весу");
            zoo.SortByWeight();
            zoo.PrintCollection();

            Console.ReadKey();
        }

        // Part 2
        static void Part2()
        {
            MyNewCollection PermZoo = new MyNewCollection("Пермский зоопарк");
            MyNewCollection MoscowZoo = new MyNewCollection("Московский зоопарк");

            Journal journal1 = new Journal();
            PermZoo.CollectionCountChanged += new MyNewCollection.CollectionHandler(journal1.CollectionCountChanged);
            PermZoo.CollectionReferenceChanged += new MyNewCollection.CollectionHandler(journal1.CollectionReferenceChanged);

            Journal journal2 = new Journal();
            PermZoo.CollectionReferenceChanged += new MyNewCollection.CollectionHandler(journal2.CollectionReferenceChanged);
            MoscowZoo.CollectionReferenceChanged += new MyNewCollection.CollectionHandler(journal2.CollectionReferenceChanged);

            IAnimal[] animals = zoo.Zoo.ToArray();

            Console.WriteLine("Добавление массива объектов в коллекцию");
            Console.ReadKey();
            Console.Clear();
            PermZoo.Add(animals);
            MoscowZoo.Add(animals);

            Console.WriteLine("Добавление значений по умолчанию в коллекцию");
            Console.ReadKey();
            Console.Clear();
            PermZoo.AddDefaults();
            MoscowZoo.AddDefaults();

            Console.WriteLine("Удаление элементов из коллекции");
            Console.ReadKey();
            Console.Clear();
            PermZoo.Remove(2);
            PermZoo.Remove(1);
            MoscowZoo.Remove(3);
            MoscowZoo.Remove(1);

            Console.WriteLine("Присвоение других значений некоторым элементам");
            Console.ReadKey();
            Console.Clear();
            PermZoo[4] = new KingdomAnimals(150000, "Кит");
            MoscowZoo[2] = new ClassMammals(9, 70, 80, "Человек");

            Console.WriteLine("Журнал 1");         
            Console.WriteLine(journal1.ToString());
            Console.ReadKey();

            Console.WriteLine("Журнал 2");
            Console.WriteLine(journal2.ToString());
            Console.ReadKey();


        }
    }
}
