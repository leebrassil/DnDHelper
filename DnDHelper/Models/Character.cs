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
        

        public Character(string charName,int level,int charClass,int race)
        {
            Race = race;
            CharacterName = charName;
            Level = level;
            Class = charClass;
        }

        public Character()
        {           
        }

    }
}