using DnDHelper.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DnDHelper.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Name { get; set; }
        public int Stat { get; set; }
        public bool Proficient { get; set; }

        public Skill(string name, int stat)
        {
            Name = name;
            Stat = stat;
            Proficient = false;
        }

        public Skill()
        {}

        public static List<Skill> CreateSkillsList(BaseStats stats)
        {
            var skills = new List<Skill>
            {
                new Skill(SkillStrings.Acrobatics,BaseStats.GetModifier(stats.Dexterity)),
                new Skill(SkillStrings.AnimalHandling,BaseStats.GetModifier(stats.Wisdom)),
                new Skill(SkillStrings.Arcana,BaseStats.GetModifier(stats.Intelligence)),
                new Skill(SkillStrings.Athletics,BaseStats.GetModifier(stats.Strength)),
                new Skill(SkillStrings.Deception,BaseStats.GetModifier(stats.Charisma)),
                new Skill(SkillStrings.History,BaseStats.GetModifier(stats.Intelligence)),
                new Skill(SkillStrings.Insight,BaseStats.GetModifier(stats.Wisdom)),
                new Skill(SkillStrings.Intimidation,BaseStats.GetModifier(stats.Charisma)),
                new Skill(SkillStrings.Investigation,BaseStats.GetModifier(stats.Intelligence)),
                new Skill(SkillStrings.Medicine,BaseStats.GetModifier(stats.Wisdom)),
                new Skill(SkillStrings.Nature,BaseStats.GetModifier(stats.Intelligence)),
                new Skill(SkillStrings.Perception,BaseStats.GetModifier(stats.Wisdom)),
                new Skill(SkillStrings.Performance,BaseStats.GetModifier(stats.Charisma)),
                new Skill(SkillStrings.Persuasion,BaseStats.GetModifier(stats.Charisma)),
                new Skill(SkillStrings.Religion,BaseStats.GetModifier(stats.Intelligence)),
                new Skill(SkillStrings.SleightOfHand,BaseStats.GetModifier(stats.Dexterity)),
                new Skill(SkillStrings.Stealth,BaseStats.GetModifier(stats.Dexterity)),
                new Skill(SkillStrings.Survival,BaseStats.GetModifier(stats.Wisdom))
            };
            return skills;
        }
    }
}