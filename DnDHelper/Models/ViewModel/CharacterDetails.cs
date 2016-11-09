using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DnDHelper.Models.ViewModel
{
    public class CharacterDetails
    {
        public int Id { get; set; }
        [Display(Name = "Character name")]
        public string CharacterName { get; set; }
        public int Level { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }

        public CharacterDetails(Character character)
        {
            Id = character.Id;
            CharacterName = character.CharacterName;
            Level = character.Level;
            Race = ((Enums.Race)character.Race).ToString();
            Class = ((Enums.Race)character.Class).ToString();
        }
    }
}