using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class ObjectNotFoundException : ApplicationException
    {
        public ObjectNotFoundException()
            : base()
        {

        }

        public ObjectNotFoundException(string str)
            : base(str)
        {

        }
        public override string ToString()
        {
            return Message;
        }
    }
}
