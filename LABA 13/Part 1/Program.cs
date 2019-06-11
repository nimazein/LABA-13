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

            FillRandomly();
            GetLength();
            AddElement();
            GetLength();
            RemoveElement();
            GetLength();
            Sort();

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
            zoo.Add(animal);
            Console.WriteLine($"В коллекцию добавлен объект: {animal.ToString()}");

            Console.ReadKey();
                
        }
        static void RemoveElement()
        {
            Console.Clear();
            Console.WriteLine("Удаление элемента из коллекции");


            KingdomAnimals animal = support.InputAnimalParameters();
            if (zoo.Contains(animal))
            {
                zoo.Remove(animal);
                Console.WriteLine($"Удален объект: {animal.ToString()}");
            }
            else
            {
                Console.WriteLine("Такого объекта нет в коллекции");
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
    }
}
