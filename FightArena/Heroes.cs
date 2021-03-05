using System;
using System.Collections.Generic;
using System.Text;

namespace FightArena
{
    class Heroes
    {

        //Creating properties to the heroes based on the information given
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


        //Creating constructor so i can create object with character information
        public Heroes()
        {

        }
        public Heroes(string _name, int _attack, int _defence, int _hitpoints)
        {
            Name = _name;
            AttackRange = _attack;
            DefenceRange = _defence;
            HitPoints = _hitpoints;
            BeenKilled = false;
        }




    }
}
