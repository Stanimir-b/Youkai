namespace YoukaiKingdom.Logic.Models.Items.Armors
{

    public class Boots : Armor
    {
        private const int DefaultDefense = 20;
        private const int DefaultLevel = 1;

        public Boots(int id, string name, int level, int defensePoints, bool generateBonusAttributes = true) : base(id, name, level, defensePoints, generateBonusAttributes) { }

        public Boots(int id, string name, bool generateBonusAttributes = true) : base(id, name, DefaultLevel, DefaultDefense, generateBonusAttributes) { }
    }
}
