using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Grintsys.SROverview.Clients.Dto
{
    [AutoMap(typeof(Client))]
    public class ClientDto: EntityDto
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string IdNumber { get; set; }
    }
}
