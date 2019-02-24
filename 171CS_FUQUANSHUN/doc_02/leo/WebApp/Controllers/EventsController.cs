using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAppCore.MainClass;
using WebAppCore.Repositories;

namespace WebAppCore.Controllers        // 写给另一个程序调用，提供访问
{
    [Route("api/[controller]")]         // 路由
    [ApiController]
    public class EventsController : ControllerBase
    {
        private EventsRepositories repository = new EventsRepositories();
        // GET: api/API
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/API/5
        [HttpGet("{id}", Name = "Get")]
        public Events Get(string id)        // 查
        {
            return this.repository.Get(id);
        }

        // POST: api/API
        [HttpPost]
        public void Post(Events value)      // 增
        {
            this.repository.Add(value);
        }

        // PUT: api/API/5
        [HttpPut("{id}")]
        public void Put(Events value)       // 改
        {
            this.repository.Update(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)       // 删
        {
            this.repository.Delete(id);  
        }
    }
}
