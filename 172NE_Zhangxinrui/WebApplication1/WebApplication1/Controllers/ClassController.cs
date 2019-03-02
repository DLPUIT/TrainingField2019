using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    using Repositories;
    using WebApplication1.新文件夹2;

    [Route("api/[controller]")]
    public class ClassController : Controller
    {
        private ClassRepository repository = new ClassRepository();
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<Class> Get()
        {
            return this.repository.GetAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public Class Get(string id)
        {
           return  this.repository.Get(id);
        }
       
        // POST api/<controller>
        [HttpPost]
        public void Post(Class value)
        {
            this.repository.Add(value);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(Class value)
        {

            repository.Update(value);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
           
            repository.Delete(id);
        }
    }
}
