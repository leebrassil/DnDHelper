using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnDHelper.Models
{
    public class Character
    {
        public int Id { get; set; }        
        public Guid UserId { get; set; }
        [Required]
        [Display(Name = "Character name")]
        public string CharacterName { get; set; }
        [Range(1,20,ErrorMessage = "Character level must be between 1 and 20")]
        [Required]
        public int Level { get; set; }
        [Required]
        public int Race { get; set; }
        [Required]
        public int Class { get; set; }
        [Display(Name = "Proficiency bonus")]
        public int ProficiencyBonus { get { return GetProficiencyBonus(); } }

        public List<Skill> Skills { get { return _skills; } }
        private List<Skill> _skills;

        [Range(1, 20, ErrorMessage = "Strength must be between 1 and 20")]
        public int Strength { get; set; }
        [Range(1, 20, ErrorMessage = "Dexterity must be between 1 and 20")]
        public int Dexterity { get; set; }
        [Range(1, 20, ErrorMessage = "Constitution must be between 1 and 20")]
        public int Constitution { get; set; }
        [Range(1, 20, ErrorMessage = "Intelligence must be between 1 and 20")]
        public int Intelligence { get; set; }
        [Range(1, 20, ErrorMessage = "Wisdom must be between 1 and 20")]
        public int Wisdom { get; set; }
        [Range(1, 20, ErrorMessage = "Charisma must be between 1 and 20")]
        public int Charisma { get; set; }

        public Character(string charName,int level,int charClass,int race)
        {
            Race = race;
            CharacterName = charName;
            Level = level;
            Class = charClass;                        
        }

        public Character()
        {
            Strength = 1;
            Dexterity = 1;
            Constitution = 1;
            Intelligence = 1;
            Wisdom = 1;
            Charisma = 1;
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

        public static int GetModifier(int stat)
        {
            if (stat == 10 || stat == 11)
            {
                return 0;
            }
            else if (stat < 10)
            {
                stat = (10 - stat) * -1;
                return stat / 2;
            }
            else
            {
                return (stat - 10) / 2;
            }
        }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
    }
}