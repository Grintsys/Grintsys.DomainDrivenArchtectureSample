using System;
using System.Collections.Generic;
using System.Text;

namespace Grintsys.SROverview.Clients.Dto
{
    public class ClientSearchInput
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int TenantId { get; set; }
    }
}
