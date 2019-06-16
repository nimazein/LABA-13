using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Journal
    {
        private List<JournalEntry> entries = new List<JournalEntry>();


        public void CollectionCountChanged(object sourse, CollectionHandlerEventArgs args) 
        {

            JournalEntry entry = new JournalEntry(args.Name, args.Change, args.Link.ToString());
            entries.Add(entry);
        }
        public void CollectionReferenceChanged(object sourse, CollectionHandlerEventArgs args)
        {
            JournalEntry entry = new JournalEntry(args.Name, args.Change, args.Link.ToString());
            entries.Add(entry);
        }


        public override string ToString()
        {
            string output = "";
            foreach (JournalEntry e in entries)
            {
                output += $"{e.ToString()}\n";
            }
            return output;
        }
    }
}
