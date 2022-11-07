using System.ComponentModel.DataAnnotations;

namespace boilerplateasp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}