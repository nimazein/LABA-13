using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    
    class MyNewCollection : MyZoo
    {

        public delegate void CollectionHandler(object source, CollectionHandlerEventArgs args);
        public string NameOfCollection { get; set; }

        public event CollectionHandler CollectionCountChanged;
        public event CollectionHandler CollectionReferenceChanged;

        public MyNewCollection()
        {

        }
        public MyNewCollection(string name)
        {
            NameOfCollection = name;
        }

        public override bool Remove(int position)
        {
            List<IAnimal> animals = Zoo;

            if (position > Length)
            {
                return false;
            }
            else
            {
                OnCollectionCountChanged(this, new CollectionHandlerEventArgs(NameOfCollection, "элемент был удален", this[position]));
                animals.RemoveAt(position);
                Zoo = animals;
                return true;
            }
        }

        public override IAnimal this[int index]
        {
            get
            {
                return base[index];
            }
            set
            {
                if (index >= 0 && index < Length)
                {
                    base[index] = value;
                    OnCollectionReferenceChanged(this, new CollectionHandlerEventArgs(NameOfCollection, $"элемент с индексом {index} был изменен", value));
                }
                else
                {
                    Console.WriteLine("Неправильно задан индекс");
                }                                
            }
        }
        public void Add(object[] collection)
        {
            foreach (IAnimal el in collection)
            {
                AddToZoo(el);               
            }
            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(NameOfCollection, "была добавлена коллекция", collection));
        }

        public void AddDefaults()
        {
            IAnimal animal = new KingdomAnimals(80, "Человек");
            AddToZoo(animal);   

            OnCollectionCountChanged(this, new CollectionHandlerEventArgs(NameOfCollection, "был добавлен элемент", animal));
        }

        public virtual void OnCollectionCountChanged(object source, CollectionHandlerEventArgs args) 
        {
            CollectionCountChanged?.Invoke(source, args);
        }
        public virtual void OnCollectionReferenceChanged(object source, CollectionHandlerEventArgs args)
        {
            CollectionReferenceChanged?.Invoke(source, args);
        }
    }
}
