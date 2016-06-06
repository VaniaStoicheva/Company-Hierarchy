using Company_HJer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_HJer.Interfaces
{
    interface IEmployee
    {
        Department Department { get; set; }

        decimal Salary { get; set; }

        string ToString();
    }
}
