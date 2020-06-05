using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System.Threading.Tasks;

namespace Grintsys.SROverview.Clients
{
    public class ClientManager: DomainService, IClientManager
    {
        private readonly IRepository<Client> _repository;
        public ClientManager(IRepository<Client> repository)
        {
            _repository = repository;
        }
        public async Task<Client> GetClient(int id)
        {
            var client = await _repository.GetAsync(id);

            if (client == null)
                throw new UserFriendlyException(L("ClientNotExist"));

            return client;
        }
    }
}
