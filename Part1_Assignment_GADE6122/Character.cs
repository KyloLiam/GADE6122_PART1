using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Assignment_GADE6122
{
    abstract class Character : Tile
    {
        public enum Movement 
        {
            noMovement,
            up,
            down,
            left,
            right,
        }
        int characterXaxis;
        int characterYaxis;
        int targetXaxis;
        int targetYaxis;
        int distanceX;
        int distanceY;
        bool isInRange = false;
        protected int hp;
        protected int maxHp;
        protected int damage;
        protected string[,] Tile = {
            {"XXXXXXXXXXXXXXX"},
            {"X.............X"},
            {"X.............X"},
            {"X.............X"},
            {"X.............X"},
            {"X.............X"},
            {"X.............X"},
            {"X.............X"},
            {"XXXXXXXXXXXXXXX"},
        };

        public Character(int x, int y) : base(x, y)
        {

        }
            
        public virtual void Attack(Character target)
        {
            //Attacks a target and decreases its health by the attacking character's damage
            target.hp = target.hp - damage;
        }

        public bool IsDead()
        {
            //Checks if the character is dead
            bool dead = false;
            if (hp <= 0)
            {
                dead = true;
            }
            return dead;

        }

        public virtual bool CheckRange(Character target)
        {
            //Checks if target is in range of a character
            if(isInRange == true)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private int DistanceTo(Character target, Character character)
        {

            int characterXaxis = character.x;
            int characterYaxis = character.y;
            int targetXaxis = target.x;
            int targetYaxis = target.y;
            distanceX = characterXaxis - targetXaxis;
            distanceY = characterYaxis - targetYaxis;

            if(distanceX < 0)
            {
                distanceX = distanceX * -1;
            }
            if(distanceY < 0)
            {
                distanceY = distanceY * -1;
            }


            if (distanceX <= 1)
            {
                if(distanceY <= 1)
                {
                    isInRange = true;
                }
            }

            if (isInRange)
            {

            }

            return distanceX;
            return distanceY;
           
        }
        public void Move(Movement move)    
        {
            if (move == Movement.noMovement)
            {
                x = x + 0;
                y = y + 0;
            }

            else if (move == Movement.up)
            {
                x = x + 0;
                y = y + 1;
            }

            else if (move == Movement.down)
            {
                x = x + 0;
                y = y - 1;
            }

            else if (move == Movement.left)
            {
                x = x - 1;
                y = y + 0;
            }

            else if (move == Movement.right)
            {
                x = x + 1;
                y = y + 0;
            }


        }

        public abstract Movement ReturnMove(Movement move = 0);



        //public abstract override ToString();
        

        

    }
}
