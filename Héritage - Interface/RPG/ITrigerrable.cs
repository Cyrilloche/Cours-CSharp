using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG
{
    public interface ITrigerrable
    {
        public void Trigger(Characteristics characteristics)
        {

        }
        
        public static void Trigger(Characteristics characteristicsDefender, Characteristics characteristicsAttacker)
        {

        }
    }
}