using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textBasedActionAdvantureRPG
{
    class Character
    {
        //Core
        private String name = "";
        private int level = 0;
        private int skillPoints = 4;
        private int exp = 0;
        private int expMax = 100;

        //Attributes
        private int strength = 1;
        private int vitality = 1;
        private int dexterity = 1;
        private int agility = 1;
        private int intelligance = 1;

        //Stats
        private int hp = 1;
        private int hpMax = 1;
        private int dmg = 1;
        private int dmgMax = 1;
        private int accuracy = 1;
        private int defence = 1;

        //General
        private int gold = 0;

        private void CalculateExp()
        {
            this.expMax = this.level * 100;
        }

        private void CalculateStats()
        {
            this.hp = this.vitality * 10;
            this.dmgMax = this.strength * 3;
            this.dmg = this.strength;
            this.accuracy = this.dexterity * 2;
            this.defence = this.agility * 2;
        }

        public Character(String name)
        {
            this.CalculateStats();

            this.name = name;
        }

        public String Name()
        {
            return this.name;
        }

        public String ToStringSimple()
        {
            String str =
                $"Name:\t\t{this.name}\n" +
                $"Health\t\t{ this.hp}/{ this.hpMax}\n" +
                $"Gold\t\t{this.gold}\n" +
                $"Level:\t\t{this.level}\n" +
                $"EXP\t\t{this.exp}/{this.expMax}";

            return str;
        }

        public override String ToString()
        {
            String str =
                $"Name:\t\t{this.name}\n" +
                $"Gold\t\t{this.gold}\n" +
                $"Level:\t\t{this.level}\n" +
                $"Skillpoints\t{this.skillPoints}\n" +
                $"EXP\t\t{this.exp}/{this.expMax}\n\n" +
                $"Strength\t\t{this.strength}\n" +
                $"Vitality\t\t{this.vitality}\n" +
                $"Dexterity\t\t{this.dexterity}\n" +
                $"Agility\t\t{this.agility}\n" +
                $"Intelligance\t\t{this.intelligance}\n\n" +
                $"Health\t\t{this.hp}/{this.hpMax}\n" +
                $"Accuracy\t\t{this.accuracy}\n" +
                $"Defence\t\t{this.defence}";

            return str;
        }
    }
}
