using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class MyZoo
    {
        private Support support = new Support();
        private List<IAnimal> zoo = new List<IAnimal>();
        public List<IAnimal> Zoo
        {
            get
            {
                return zoo;
            }
        }

        public MyZoo()
        {

        }
        public int Length
        {
            get
            {
                return zoo.Count;
            }
        }
        public void Fill(int size)
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                int weight = rnd.Next(1, 1000);
                string name;
                if (i % 2 == 0)
                {
                    name = $"Млекопитающее {i + 1}";
                    int lifeExpectancy = rnd.Next(3, 120);
                    int incubationPeriod = rnd.Next(3, 12);

                    zoo.Add(new ClassMammals(incubationPeriod, lifeExpectancy, weight, name));
                    continue;
                }
                if (i % 3 == 0)
                {
                    name = $"Птица {i + 1}";
                    int buf = rnd.Next(100);
                    bool domestic = buf <= 20;
                    bool flying = buf <= 20;

                    zoo.Add(new ClassBirds(flying, domestic, weight, name));

                    continue;
                }
                if (i % 5 == 0)
                {
                    name = $"Парнокопытное {i + 1}";
                    int lifeExpectancy = rnd.Next(3, 120);
                    int incubationPeriod = rnd.Next(3, 12);
                    int horns = rnd.Next(100);
                    bool hasHorns = horns <= 20;
                    string habitat = $"Среда обитания {i + 1}";

                    zoo.Add(new OrderArtiodactyl(hasHorns, habitat, incubationPeriod, lifeExpectancy, weight, name));

                    continue;
                }
                name = $"Животное {i + 1}";
                zoo.Add(new KingdomAnimals(weight, name));

            }
        }
        public void Add(IAnimal animal)
        {
            zoo.Add(animal);
        }
        public void Remove(IAnimal animal)
        {
            try
            {
                foreach (IAnimal el in zoo)
                {
                    if (el.Name == animal.Name)
                    {
                        if (el.Weight == animal.Weight)
                        {
                            zoo.Remove(el);
                        }
                    }
                }

            }
            catch
            {

            }
            
        }
        public void SortByName()
        {
            IAnimal temp;
            for (int i = 0; i < zoo.Count - 1; i++)
            {
                for (int j = i + 1; j < zoo.Count; j++)
                {
                    if (String.Compare(zoo[i].Name, zoo[j].Name) > 0)
                    {
                        temp = zoo[i];
                        zoo[i] = zoo[j];
                        zoo[j] = temp;
                    }
                }
            }
        }
        public void SortByWeight()
        {
            IAnimal temp;
            for (int i = 0; i < zoo.Count - 1; i++)
            {
                for (int j = i + 1; j < zoo.Count; j++)
                {
                    if (zoo[i].Weight > zoo[j].Weight)
                    {
                        temp = zoo[i];
                        zoo[i] = zoo[j];
                        zoo[j] = temp;
                    }
                }
            }

        }
        public IAnimal this[int index]
        {
            get
            {
                return zoo[index];
            }
            set
            {
                zoo[index] = value;
            }
        } 
        public bool Contains(IAnimal animal)
        {
            foreach (IAnimal el in zoo)
            {
                if (el.Name == animal.Name)
                {
                    if (el.Weight == animal.Weight)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void PrintCollection()
        {
            foreach (IAnimal animal in zoo)
            {
                Console.WriteLine(animal.ToString());
            }
        }




    }
}
