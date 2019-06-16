using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class JournalEntry
    {
        public string Name { get; set; }
        public string Change { get; set; }
        public string AnimalInfo { get; set; }

        public JournalEntry() { }
        public JournalEntry(string name, string change, string animalInfo)
        {
            Name = name;
            Change = change;
            AnimalInfo = animalInfo;
        }
        public override string ToString()
        {
            return $"Коллекция: {Name}, изменение: {Change}, поля объекта: {AnimalInfo}";
        }
    }
}
