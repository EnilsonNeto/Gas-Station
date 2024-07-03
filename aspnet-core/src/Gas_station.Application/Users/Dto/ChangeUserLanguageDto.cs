using System.ComponentModel.DataAnnotations;

namespace Gas_station.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}