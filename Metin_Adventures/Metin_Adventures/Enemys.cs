using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metin_Adventures
{
    class Enemys
    {

        //--------------------------------------------------------------------------Enemy Start
        public static double E_Damage;
        public static double E_Defence;
        public static double E_Health;
        public static double E_EXP;

        //Levels 1 - 10
        public static string[] weak_enemy_type = { "Stray Dog", "Wild Boar", "Hungry Bear", "Wild Tiger", "Wolf", "Aplha Wolf", "Giant Rat" };

        //Levels 1 - 20
        public static string[] medium_enemy_type = { "Bandit Archer", "Bandit Swordman", "Amazon Archer", "Amazon Infantery", "Orc Warrior", "Orc Caster", "Orc King" };

        //Levels 20 - 40
        public static string[] strong_enemy_type = { "Stone Golem", "Ice Golem", "Ice Tiger", "Yeti", "Berserker", "Ice Bug", "Ice Lion" };

        public static Random r_medium = new Random();
        public static string medium_enemy = medium_enemy_type[r_medium.Next(0, medium_enemy_type.Length)];
        public static int enemy_dead = 0;
        //--------------------------------------------------------------------------Enemy End


    }
}
