using System.Xml.Linq;

namespace Problema_1_Heroes
{
    public abstract class Hero : ICloneable<Hero>
    {
        public string Name { get; set; }
        public string VisualAppearance { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public int SkillPoints { get; set; }
        public List<string> Abilities { get; set; }

        protected Hero(string name, string visualAppearance, int experience, int level, int skillPoints, List<string> abilities)
        {
            Name = name;
            VisualAppearance = visualAppearance;
            Experience = experience;
            Level = level;
            SkillPoints = skillPoints;
            Abilities = new List<string>(abilities);
        }

        public abstract Hero Clone();
    }
}
