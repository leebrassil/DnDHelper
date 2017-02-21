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

        public static List<Skill> CreateSkillsList(Character character)
        {
            var skills = new List<Skill>
            {
                new Skill(SkillStrings.Acrobatics,Character.GetModifier(character.Dexterity)),
                new Skill(SkillStrings.AnimalHandling,Character.GetModifier(character.Wisdom)),
                new Skill(SkillStrings.Arcana,Character.GetModifier(character.Intelligence)),
                new Skill(SkillStrings.Athletics,Character.GetModifier(character.Strength)),
                new Skill(SkillStrings.Deception,Character.GetModifier(character.Charisma)),
                new Skill(SkillStrings.History,Character.GetModifier(character.Intelligence)),
                new Skill(SkillStrings.Insight,Character.GetModifier(character.Wisdom)),
                new Skill(SkillStrings.Intimidation,Character.GetModifier(character.Charisma)),
                new Skill(SkillStrings.Investigation,Character.GetModifier(character.Intelligence)),
                new Skill(SkillStrings.Medicine,Character.GetModifier(character.Wisdom)),
                new Skill(SkillStrings.Nature,Character.GetModifier(character.Intelligence)),
                new Skill(SkillStrings.Perception,Character.GetModifier(character.Wisdom)),
                new Skill(SkillStrings.Performance,Character.GetModifier(character.Charisma)),
                new Skill(SkillStrings.Persuasion,Character.GetModifier(character.Charisma)),
                new Skill(SkillStrings.Religion,Character.GetModifier(character.Intelligence)),
                new Skill(SkillStrings.SleightOfHand,Character.GetModifier(character.Dexterity)),
                new Skill(SkillStrings.Stealth,Character.GetModifier(character.Dexterity)),
                new Skill(SkillStrings.Survival,Character.GetModifier(character.Wisdom))
            };
            return skills;
        }
    }
}