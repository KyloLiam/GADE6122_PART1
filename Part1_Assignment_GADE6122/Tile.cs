using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Assignment_GADE6122
{
    abstract class Tile
    {
        public enum TileType
        {
            Hero,
            Enemy,
            Gold,
            Weapon
        }

        protected int x;
        protected int y;

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
            
        }
            
    
   }
    
}

