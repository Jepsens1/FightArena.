using System;
using System.Collections.Generic;
using System.Text;

namespace FightArena
{
    class Logic
    {
        public List<Heroes> heroes = new List<Heroes>();
        public string Fighting(Player player, Enemy enemy)
        {
            string temp = "";
            Random random;
            int bighit;
            random = new Random(Guid.NewGuid().GetHashCode());
           
            if (enemy.DefenceRange < player.AttackRange && player.HitPoints > 0)
            { 
                //Checks if player has a crictical strike
                if (random.Next(1, 100) >= 65)
                {
                    bighit = player.AttackRange * 2;
                    enemy.HitPoints -= (bighit - enemy.DefenceRange);
                    temp += $"Ohhh {player.Name} landed a critical hit and {enemy.Name} now has {enemy.HitPoints} hitpoints left\n";
                }
                else
                {
                    enemy.HitPoints -= (player.AttackRange - enemy.DefenceRange);
                    temp += $"{enemy.Name} has been damaged by {player.Name} he now has {enemy.HitPoints} hitpoints left\n";
                }

            }
            //Check if player cant attack
            else if (enemy.DefenceRange > player.AttackRange)
            {
                temp += $"{enemy.Name} defended against {player.Name}\n";
            }
            //Checks to see if player can attack
            if (player.DefenceRange < enemy.AttackRange && enemy.HitPoints > 0)
            {
                //Checks if player has a crictical strike
                if (random.Next(1, 100) >= 65)
                {
                    bighit = enemy.AttackRange * 2;
                    player.HitPoints -= (bighit - player.DefenceRange);
                    temp += $"Ohhh {enemy.Name} landed a critical hit and {player.Name} now has {player.HitPoints} hitpoints left\n";
                }
                else
                {
                    player.HitPoints -= (enemy.AttackRange - player.DefenceRange);
                    temp += $"{player.Name} has been damaged by {enemy.Name} he now has {player.HitPoints} hitpoints left\n";
                }

            }
            //Checks to see if enemy can attack
            else if (player.DefenceRange > enemy.AttackRange)
            {
                temp += $"{player.Name} defended against {enemy.Name}\n";
            }
            //Checks to see if player has been killed and if enemy has been killed
            if (player.HitPoints <= 0)
            {
                player.BeenKilled = true;
                temp += $"{player.Name} has been killed";
            }
            if (enemy.HitPoints <= 0)
            {
                enemy.BeenKilled = true;
                temp += $"{enemy.Name} has been killed";
            }
            return temp;
        }
    }
}
