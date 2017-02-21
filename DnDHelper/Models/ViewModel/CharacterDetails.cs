using System.ComponentModel.DataAnnotations;

namespace DnDHelper.Models.ViewModel
{
    public class CharacterDetails
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string CharacterName { get; set; }
        public int Level { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        [Display(Name = "Proficiency bonus")]
        public int ProficiencyBonus { get; set; }        
        public int Strength { get; set; }
        public int Dexterity { get; set; }        
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        public CharacterDetails(Character character)
        {
            Id = character.Id;
            CharacterName = character.CharacterName;
            Level = character.Level;
            Race = ((Enums.Race)character.Race).ToString();
            Class = ((Enums.Race)character.Class).ToString();
            ProficiencyBonus = character.ProficiencyBonus;
        }

        public CharacterDetails()
        {

        }
    }
}