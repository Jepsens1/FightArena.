using System;
using System.Collections.Generic;
using System.Text;

namespace FightArena
{
    class Enemy
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private int attackRange;

        public int AttackRange
        {
            get { return attackRange; }
            set { attackRange = value; }
        }
        private int defenceRange;

        public int DefenceRange
        {
            get { return defenceRange; }
            set { defenceRange = value; }
        }
        private int hitPoints;

        public int HitPoints
        {
            get { return hitPoints; }
            set { hitPoints = value; }
        }
        private bool beenKilled;

        public bool BeenKilled
        {
            get { return beenKilled; }
            set { beenKilled = value; }
        }
        //selected hero as parameter to give them a random hero from herolist
        public Enemy(Heroes hero)
        {
            AttackRange = hero.AttackRange;
            Name = hero.Name;
            DefenceRange = hero.DefenceRange;
            HitPoints = hero.HitPoints;
            BeenKilled = false;
        }
    }
}
