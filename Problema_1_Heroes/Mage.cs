using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_Heroes
{
    public class Mage : Hero
    {
        public Mage(string name, string visualAppearance, int experience, int level, int skillPoints, List<string> abilities)
            : base(name, visualAppearance, experience, level, skillPoints, abilities)
        {
        }

        public override Hero Clone()
        {
            return new Mage(Name, VisualAppearance, Experience, Level, SkillPoints, Abilities);
        }
    }
}
