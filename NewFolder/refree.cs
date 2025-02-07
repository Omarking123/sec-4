using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_4.NewFolder
{
    internal class refree
    {
        public string Name { get; set; }
        
        public void Look( ball ball)
        {
            Console.WriteLine( $"Reffer {Name} is look at Ball {ball}");
        }
        public override string ToString()
        {
            return $" Name : { Name}"; 
        }
    }
}
