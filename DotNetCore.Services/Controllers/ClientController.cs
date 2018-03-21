using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learn.Business;
using Learn.Core.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Learn.Services.Controllers
{
    [Produces("application/json")]
    [Route("api/Client")]
    public class ClientController : Controller
    {
        private readonly IClientBusiness _clientBusiness;
        public ClientController(IClientBusiness clientBusiness)
        {

            _clientBusiness = clientBusiness;

           }

        [HttpGet]
        public async Task<IPagedList<Client>> Get()
        {
            //var client = new Client { ClientName = "Client 1", EIN = 11111, CreatedDate = DateTime.Now };
            //await _clientBusiness.Post(client);
            var result = _clientBusiness.Get();
            return await result;
        }

        // GET api/values/Page/5/10
        [HttpGet("Page/{pageIndex}/{pageSize}")]
        public async Task<IPagedList<Client>> Get(int pageIndex, int pageSize)
        {

            return await _clientBusiness.Get(pageIndex: pageIndex, pageSize: pageSize);
        }

        // GET api/values/Search/a1
        [HttpGet("Search/{term}")]
        public async Task<IPagedList<Client>> Get(string term)
        {

            return await _clientBusiness.Get(term);
        }

        // GET api/values/4
        [HttpGet("{id}")]
        public async Task<Client> Get(int id)
        {
            return await _clientBusiness.Get(id);
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody]Client value)
        {

            await _clientBusiness.Post(value);
        }
    }
}

