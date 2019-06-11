using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    public class OrderArtiodactyl : ClassMammals, IAnimal
    {
        public bool HasHorns { get; set; }
        public string Habitat { get; set; }
        public OrderArtiodactyl()
        {

        }
        public OrderArtiodactyl(bool hasHorns, string habitat, int incubationPeriod, int lifeExpectancy, int weight, string name)
            : base(incubationPeriod, lifeExpectancy, weight, name)
        {
            HasHorns = hasHorns;
            Habitat = habitat;
        }
        public static OrderArtiodactyl GetRandom()
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

        public override string ToString()
        {
            return $"{Name}, {Weight} кг, {IncubationPeriod} месяцев, {LifeExpectancy} лет, есть рога: {HasHorns}, {Habitat}\n";
        }

    }
}
