using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Grintsys.SROverview.Clients.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grintsys.SROverview.Clients
{
    public class ClientAppService : AsyncCrudAppService<Client, ClientDto, int, GetAllClientInput>, IClientAppService
    {
        private readonly IRepository<Client> _repository;
        private readonly ClientManager _clientManager;
        public ClientAppService(IRepository<Client> repository,
            ClientManager clientManager): base(repository)
        {
            _repository = repository;
            _clientManager = clientManager;
        }

        public async Task<PagedResultDto<GetAllClientInput>> GetAllBySearchCriteria(ClientSearchInput input)
        {
            var clients = await _repository.GetAllListAsync(a => a.Name.Contains(input.Name) 
                           || a.Code.Contains(input.Code));
           
            return new PagedResultDto<GetAllClientInput>
            {
                TotalCount = clients.Count(),
                Items = ObjectMapper.Map<List<GetAllClientInput>>(clients)
            };
        }

        public async Task<ClientDto> GetClient(GetClientInput input)
        {
            var client = await _clientManager.GetClient(input.Id);

            return MapToEntityDto(client);
        }

        public override Task<ClientDto> CreateAsync(ClientDto input)
        {
            return base.CreateAsync(input);
        }
    }
}
