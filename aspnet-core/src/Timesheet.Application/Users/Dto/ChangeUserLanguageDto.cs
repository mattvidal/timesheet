using System.ComponentModel.DataAnnotations;

namespace Timesheet.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}