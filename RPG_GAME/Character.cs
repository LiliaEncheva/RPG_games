using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPG_GAME
{
    public abstract class Character
    {
        private string name;
        private int health;
        private int power;
        private string race;

        public Character(string name, int health, int power, string race)
        {
            this.name = name;
            this.health = health;
            this.power = power;
            this.race = race;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Power
        {
            get { return power; }
            set { power = value; }
        }

        public string Race
        {
            get { return race; }
            set { race = value; }
        }

        public abstract void Attack(Character target); // metod attack for character target
        public abstract void Defend(int attackPower); // metod for defend from attack power
    }
}
