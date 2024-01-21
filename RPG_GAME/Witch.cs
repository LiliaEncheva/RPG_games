using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME
{
    public abstract class Witch: Character
    {
        public Witch(string name, int health, int power) : base(name, health, power, "Witch")
        {
        }

        public override void Attack(Character target)
        {
            //Те нанасят средно ниво на щети, както и могат да се възстановяват.
        }

        public override void Defend(int attackPower)
        {
            
        }
    }
}
