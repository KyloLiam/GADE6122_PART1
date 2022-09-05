using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Assignment_GADE6122
{
    abstract class Enemy : Character
    {
      
        Random rng = new Random();
        
        int randNum = rng.Next();

    }
}
