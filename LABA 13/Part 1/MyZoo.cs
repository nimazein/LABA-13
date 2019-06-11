using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class MyZoo
    {
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

        public void Fill(int size)
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                int loteryNumber = rnd.Next(1000);
                if (loteryNumber > 250)
                {
                    if (loteryNumber > 500)
                    {
                        if (loteryNumber > 750)
                        {
                            zoo.Add(OrderArtiodactyl.GetRandom());
                            continue;
                        }
                        zoo.Add(ClassMammals.GetRandom());
                        continue;
                    }
                    zoo.Add(ClassBirds.GetRandom());
                }
                else
                {
                    zoo.Add(KingdomAnimals.GetRandom());
                }
            }
        }
        public void Add(IAnimal animal)
        {
            zoo.Add(animal);
        }
        public void Remove(IAnimal animal)
        {
            zoo.Remove(animal);
        }

           


    }
}
