using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventsBerry.Models;
using EventsBerry.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventsBerry.Controllers
{
    [Route("api/[controller]")]
    public class EventController : Controller
    {
        private EventRepository repository = new EventRepository();
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return this.repository.GetAll();
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Event Get(string id)
        {
            return this.repository.Get(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post(Event value)
        {
            this.repository.Add(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(Event value)
        {
            this.repository.Update(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(string eventId)
        {
            this.repository.Delete(eventId);
        }
    }
}
