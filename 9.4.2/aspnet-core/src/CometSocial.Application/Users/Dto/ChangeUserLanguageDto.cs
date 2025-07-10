using System.ComponentModel.DataAnnotations;

namespace CometSocial.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}