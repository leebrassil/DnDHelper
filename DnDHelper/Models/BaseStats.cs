using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnDHelper.Models
{
    public class BaseStats
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public static int GetModifier(int stat)
        {
            if (stat == 10 || stat == 11)
            {
                return 0;
            }                
            else if(stat < 10)
            {
                stat = (10 - stat) * -1;
                return stat / 2;
            }
            else
            {
                return (stat - 10) / 2;
            }            
        }

        public BaseStats()
        {
        }
    }
}