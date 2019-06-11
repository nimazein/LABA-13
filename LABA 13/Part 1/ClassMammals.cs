using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    public class ClassMammals : KingdomAnimals, IAnimal
    {
       
        public int IncubationPeriod { get; set; }
        public int LifeExpectancy { get; set; }
        public ClassMammals()
        {

        }

        public ClassMammals(int incubationPeriod, int lifeExpectancy, int weight, string name)
            : base(weight, name)
        {
            IncubationPeriod = incubationPeriod;
            LifeExpectancy = lifeExpectancy;
        }
        public static ClassMammals GetRandom()
        {
            Random rnd = new Random();
            int weight = rnd.Next(100, 2000);
            string name = $"Млекопитающее {Convert.ToChar(rnd.Next(65, 90))}{rnd.Next(100)}";
            int lifeExpectancy = rnd.Next(20, 120);
            int incubationPeriod = rnd.Next(3, 12);

            return new ClassMammals(incubationPeriod, lifeExpectancy, weight, name);
        }
        public override string ToString()
        {
            return $"{Name}, {Weight} кг, {IncubationPeriod} месяцев, {LifeExpectancy} лет\n";
        }
    }
    
}
