using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventTest.Models;
using EventTest.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EventTest.Controllers
{
    [Produces("application/json")]
    [Route("api/Event")]
    public class EventController : Controller
    {
        private EventRepository repository = new EventRepository();
        // GET: api/Event
        [HttpGet]
        public IEnumerable<Event> Get()// 返回所有的数据
        {
            return repository.GetAll(); 
        }

        // GET: api/Event/5
        [HttpGet("{id}", Name = "Get")]
        public Event Get(String  id)
        {
            return repository.Get(id);
        }

        // POST: api/Event
      
        [HttpPost]
     
        public void Post(Event value)
        {
            repository.Add(value);
        }
        
        // PUT: api/Event/5
        [HttpPut("{id}")]
        public void Put(Event value)
        {

            repository.Update(value);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(String id)
           
        {
            repository.Delete(id);
        }
        // repository是对数据库进行增删改查
        //cotroller里面的post get  put  delete  是对外面提供接口
    }
}
