﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    interface IAnimal
    {
        int Weight
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
    }
}