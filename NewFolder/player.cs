using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sec_4.NewFolder
{
    internal class player
    {
        public string  Name { get; set; }
        public string  TeamName { get; set; }

        public void Run(ball ball)
        {

            Console.WriteLine( $"play { Name } is running at {ball} ");
        }
        public override string ToString()
        {
            return $"player name : {Name} team name {TeamName}";
        }
    }
}
