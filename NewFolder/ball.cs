using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_4.NewFolder
{
    internal class ball
    {
        public   int id  { get; set; }


        private Location location;
        public Location Location
        {
            get { return location; }
            set { 

                location = value; 
            }
        }

        public override string ToString()
        {
            return $" id : {id} , location {location}";
        }
    }
}
