using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YatzyGame
{
    public class Dice:IComparable<Dice>
    {
        public Dice() { }
        public int value { get; set; }
        public bool hold { get; set; }

        public int CompareTo(Dice other)
        {
            if (this.value == other.value)
                return 0;
            if (this.value > other.value)
                return 1;
            return -1;
        }


    }
}
