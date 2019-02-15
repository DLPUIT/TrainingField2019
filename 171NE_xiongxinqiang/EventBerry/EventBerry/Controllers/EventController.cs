using EventBerry.Models;
using EventBerry.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace EventsBerry.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private static readonly EventRepositories eventRepository = new EventRepositories();

        // GET: api/Event
        [HttpGet]
        public dynamic Get()
        {
            return eventRepository.GetAll();
        }

        // GET: api/Event/5xxx
        [HttpGet("{id}", Name = "Get")]
        public Event Get(string id)
        {
            return eventRepository.Get(id);
        }

        // POST: api/Event
        [HttpPost]
        public void Post([FromBody] Event value)
        {
            eventRepository.Add(value);
        }

        // PUT: api/Event/5xxx
        [HttpPut("{id}")]
        public void Put(Event value)
        {
            eventRepository.Update(value);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            eventRepository.DeleteAsync(id);
        }
    }
}
