using Abp.AutoMapper;
using Grintsys.SROverview.Authentication.External;

namespace Grintsys.SROverview.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
