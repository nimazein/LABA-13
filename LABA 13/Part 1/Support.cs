using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Support
    {
        public int InputSize()
        {
            Console.Write("Введите количество объектов: ");
            int size = -666;

            string buf = Console.ReadLine();
            try
            {
                size = Convert.ToInt32(buf);

            }
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод");
            }
            
            if (size > 100)
            {
                throw new CollectionOverflowException("Размер не может быть таким большим");
            }     
            return size;
        }
        public KingdomAnimals InputAnimalParameters()
        {
            Console.Write("Введите название: ");
            string name = Console.ReadLine();                       

            Console.Write("Введите вес: ");
            int weight = -666;

            string buf = Console.ReadLine();
            try
            {
                weight = Convert.ToInt32(buf);
            }
            catch (Exception)
            {
                Console.WriteLine("Неверный ввод");
            }
            
            if (weight > 150000)
            {
                throw new TooBigWeightException("Вес не может быть таким большим");
            }

            return new KingdomAnimals(weight, name);

                    

        }
        public KingdomAnimals GetRandomAnimal()
        {
            Random rnd = new Random();
            int weight = rnd.Next(100, 2000);
            string name = $"Animal {Convert.ToChar(rnd.Next(65, 90))}{rnd.Next(100)}";

            return new KingdomAnimals(weight, name);
        }
        public OrderArtiodactyl GetRandomArt()
        {
            Random rnd = new Random();
            int weight = rnd.Next(100, 2000);
            string name = $"Парнокопытное {Convert.ToChar(rnd.Next(65, 90))}{rnd.Next(100)}";
            int lifeExpectancy = rnd.Next(20, 120);
            int incubationPeriod = rnd.Next(3, 12);
            bool hasHorns = rnd.Next(100) <= 20;
            string habitat = $"Среда обитания  {Convert.ToChar(rnd.Next(65, 90))}{rnd.Next(100)}";

            return new OrderArtiodactyl(hasHorns, habitat, incubationPeriod, lifeExpectancy, weight, name);
        }
        public ClassMammals GetRandomMammmal()
        {
            Random rnd = new Random();
            int weight = rnd.Next(100, 2000);
            string name = $"Млекопитающее {Convert.ToChar(rnd.Next(65, 90))}{rnd.Next(100)}";
            int lifeExpectancy = rnd.Next(20, 120);
            int incubationPeriod = rnd.Next(3, 12);

            return new ClassMammals(incubationPeriod, lifeExpectancy, weight, name);
        }
        public ClassBirds GetRandomBird()
        {
            Random rnd = new Random();
            int weight = rnd.Next(100, 2000);
            string name = $"Птица {Convert.ToChar(rnd.Next(65, 90))}{rnd.Next(100)}";
            bool flying = rnd.Next(100) <= 20;
            bool domestic = rnd.Next(100) <= 20;

            return new ClassBirds(flying, domestic, weight, name);
        }
    }
}
