using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema_1_Heroes
{
    public class Archer : Hero
    {
        public Archer(string name, string visualAppearance, int experience, int level, int skillPoints, List<string> abilities)
            : base(name, visualAppearance, experience, level, skillPoints, abilities)
        {
        }

        public override Hero Clone()
        {
            return new Archer(Name, VisualAppearance, Experience, Level, SkillPoints, Abilities);
        }
    }
}
