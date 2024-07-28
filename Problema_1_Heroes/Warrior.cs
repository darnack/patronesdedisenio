using System.Reflection.Emit;
using System.Xml.Linq;

namespace Problema_1_Heroes
{
    public class Warrior : Hero
    {
        public Warrior(string name, string visualAppearance, int experience, int level, int skillPoints, List<string> abilities)
            : base(name, visualAppearance, experience, level, skillPoints, abilities)
        {
        }

        public override Hero Clone()
        {
            return new Warrior(Name, VisualAppearance, Experience, Level, SkillPoints, Abilities);
        }
    }
}
