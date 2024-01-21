using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME
{
    public abstract class Nekromant: Character
    {
        public Nekromant(string name, int health, int power) : base(name, health, power, "Nekromant")
        {
        }

        public override void Attack(Character target)
        {
            //Некромант - Те правят малко щети, и възстановяват малко сила.
        }

        public override void Defend(int attackPower)
        {
            
        }
    }
}
