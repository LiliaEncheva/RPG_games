using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_GAME
{
    public abstract class Amazonka: Character
    {
        public Amazonka(string name, int health, int power) : base(name, health, power, "Amazonka")
        {

        }

        public override void Attack(Character target)
        {
            //Амазонка - Те са по-бързи и нанасят повече щети от Хората, могат също и да възстановяват малко кръв
            //но по-малко от Хората
        }

        public override void Defend(int attackPower)
        {
          
        }
    }
}
