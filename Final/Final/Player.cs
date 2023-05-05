using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Player
    {
        public string Name { get; set; }

        public int HP { get; set; }

        public int ATK { get; set; }

        public int DEF { get; set; }

        public double[,] Items { get; set; }

        public bool Defeated { get; set; }

        public int Kills { get; set; }

        public Player(string name, int hp, int atk, int def, double[,] items)
        {
            Name = name;
            HP = hp;
            ATK = atk;
            DEF = def;
            Items = items;

            Defeated = false;
        }
    }
}
