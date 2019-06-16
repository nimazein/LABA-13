using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class CollectionHandlerEventArgs : EventArgs
    {
        public string Name { get; set; }
        public string Change { get; set; }
        public object Link { get; set; }

        public CollectionHandlerEventArgs(){}
        public CollectionHandlerEventArgs(string name, string change, object link)
        {
            Name = name;
            Change = change;
            Link = link;
        }
        public override string ToString()
        {
            return $"Коллекция: {Name}, изменение: {Change}, ссылка на объект: {Link.ToString()}";
        }
    }
}
