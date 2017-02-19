using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DnDHelper.Models
{
    public class Character
    {
        public int Id { get; set; }
        [Display(Name = "Character name")]
        [Required]
        public string CharacterName { get; set; }
        [Range(1,20,ErrorMessage = "Character level must be between 1 and 20")]
        [Required]
        public int Level { get; set; }
        [Required]
        public int Race { get; set; }
        [Required]
        public int Class { get; set; }

        public int ProficiencyBonus { get { return GetProficiencyBonus(); } }
        public BaseStats Stats { get; set; }

        public List<Skill> Skills { get { return _skills; } }
        private List<Skill> _skills;
        

        public Character(string charName,int level,int charClass,int race)
        {
            Race = race;
            CharacterName = charName;
            Level = level;
            Class = charClass;                        
        }

        public Character()
        {
            Stats = new BaseStats();
        }

        public int GetProficiencyBonus()
        {
            if (Level > 16)
                return 6;
            else if (Level > 12)
                return 5;
            else if (Level > 8)
                return 4;
            else if (Level > 4)
                return 3;
            else
                return 2;
        }

    }
}