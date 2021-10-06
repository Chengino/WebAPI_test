using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWord : ControllerBase
    {
        // GET: api/<HelloWord>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "HelloWord1", "HelloWord2" };
        }

        // GET api/<HelloWord>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (id == 1)
                return "YES 1";
            else
                return "NO";
        }

        // POST api/<HelloWord>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<HelloWord>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<HelloWord>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
