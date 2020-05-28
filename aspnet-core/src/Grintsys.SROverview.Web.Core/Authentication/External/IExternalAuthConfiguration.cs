using System.Collections.Generic;

namespace Grintsys.SROverview.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
