﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class PriceMustBeGratherThanZeroException:Exception
    {
        public PriceMustBeGratherThanZeroException() : base("error var qaqas") { }        
    }
}
