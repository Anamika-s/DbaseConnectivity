using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Models
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Exp { get; set; }
        public string Dept { get; set; }
    }
}
