using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class TooBigWeightException : ApplicationException
    {
        public TooBigWeightException()
            : base()
        {

        }

        public TooBigWeightException(string str)
            : base(str)
        {

        }
        public override string ToString()
        {
            return Message;
        }
    }
}
