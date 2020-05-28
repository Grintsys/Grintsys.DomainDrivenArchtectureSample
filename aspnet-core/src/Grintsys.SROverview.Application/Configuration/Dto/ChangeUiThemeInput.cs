using System.ComponentModel.DataAnnotations;

namespace Grintsys.SROverview.Configuration.Dto
{
    public class ChangeUiThemeInput
    {
        [Required]
        [StringLength(32)]
        public string Theme { get; set; }
    }
}
