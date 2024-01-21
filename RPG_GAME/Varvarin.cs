using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME
{
    public abstract class Varvarin: Character
    {
        public Varvarin(string name, int health, int power) : base(name, health, power, "Varvarin")
        {

        }

        public override void Attack(Character target)
        {
            //Варварин - Те правят много щети, както и щетите върху тях са по - малки.
        }

        public override void Defend(int attackPower)
        {
            
        }
    }
}
