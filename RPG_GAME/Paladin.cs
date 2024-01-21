using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME
{
    public abstract class Paladin: Character
    {
        public Paladin(string name, int health, int power) : base(name, health, power, "Paladin")
        {
        }

        public override void Attack(Character target)
        {
            //Паладин - Те разполагат със средно ниво на щети, но могат да се възстановяват.
        }

        public override void Defend(int attackPower)
        {
            
        }
    }
}
