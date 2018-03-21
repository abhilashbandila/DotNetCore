using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace Learn.Business
{
    public interface IClientBusiness
    {
        Task<IPagedList<Client>> Get();
        Task<IPagedList<Client>> Get(int pageIndex, int pageSize);
        Task<IPagedList<Client>> Get(string term);
        Task<Client> Get(int id);
        Task Post(Client value);
    }
}
