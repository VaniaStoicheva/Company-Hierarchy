﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_HJer.Interfaces
{
    interface ISale
    {
        string ProductName { get; set; }

        DateTime SaleDate { get; set; }

        decimal ProductPrice { get; set; }
    }
}
