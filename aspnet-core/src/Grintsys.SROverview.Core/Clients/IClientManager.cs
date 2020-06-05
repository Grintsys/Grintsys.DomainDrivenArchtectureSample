using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Grintsys.SROverview.Clients
{
    public interface IClientManager: IDomainService
    {
        Task<Client> GetClient(int id);
    }
}
