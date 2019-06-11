using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    public class ClassBirds : KingdomAnimals, IAnimal
    {
        public bool Flying { get; set; }
        public bool Domestic { get; set; }

        public ClassBirds()
        {

        }
        public ClassBirds(bool flying, bool domestic, int weight, string name) 
            : base(weight, name)
        {
            Flying = flying;
            Domestic = domestic;
        }
        public static ClassBirds GetRandom()
        {
            Random rnd = new Random();
            int weight = rnd.Next(100, 2000);
            string name = $"Птица {Convert.ToChar(rnd.Next(65, 90))}{rnd.Next(100)}";
            bool flying = rnd.Next(100) <= 20;
            bool domestic = rnd.Next(100) <= 20;

            return new ClassBirds(flying, domestic, weight, name);
        }
        public override string ToString()
        {            
            return $"{Name}, {Weight} кг, летает: {Flying}, домашняя: {Domestic}";
        }
    }
}
