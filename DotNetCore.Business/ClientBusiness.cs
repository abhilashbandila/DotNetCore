using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Learn.Core.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Learn.Business
{
    public class ClientBusiness : IClientBusiness
    {
        private readonly IUnitOfWork _unitOfWork;

        private ILogger<ClientBusiness> _logger;
        public ClientBusiness(IUnitOfWork unitOfWork, ILogger<ClientBusiness> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;

            // seeding
            var repo = _unitOfWork.GetRepository<Client>();
            if (repo.Count() == 0)
            {
                repo.Insert(new Client
                {
                    ClientName = "Client 1",
                    CreatedDate = DateTime.Now,
                    EIN = 111111111,
                    ModifiedDate = DateTime.Now
                });
                _unitOfWork.SaveChanges();

            }
        }
        public async Task<IPagedList<Client>> Get()
        {
            return await _unitOfWork.GetRepository<Client>().GetPagedListAsync();
        }

        public async Task<IPagedList<Client>> Get(int pageIndex, int pageSize)
        {
            // projection
            var items = _unitOfWork.GetRepository<Client>().GetPagedList();

            return await _unitOfWork.GetRepository<Client>().GetPagedListAsync(pageIndex: pageIndex, pageSize: pageSize);
        }

        public async Task<IPagedList<Client>> Get(string term)
        {
            //_logger.LogInformation("demo about first or default with include");

            //var item = _unitOfWork.GetRepository<Client>().GetFirstOrDefault();

            //_logger.LogInformation("demo about first or default without include");

            //item = _unitOfWork.GetRepository<Client>().GetFirstOrDefault();

            //_logger.LogInformation("demo about first or default with projection");

            var projection = _unitOfWork.GetRepository<Client>().GetFirstOrDefault();

            return await _unitOfWork.GetRepository<Client>().GetPagedListAsync();
        }

        public async Task<Client> Get(int id)
        {
            return await _unitOfWork.GetRepository<Client>().FindAsync(id);
        }


        public async Task Post(Client value)
        {
            var repo = _unitOfWork.GetRepository<Client>();
            repo.Insert(value);
            await _unitOfWork.SaveChangesAsync();
        }
    }
}