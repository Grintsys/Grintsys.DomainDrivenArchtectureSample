using System.ComponentModel.DataAnnotations;

namespace Grintsys.SROverview.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}