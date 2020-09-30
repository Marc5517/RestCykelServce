using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestCykelServceTrue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CykelController : ControllerBase
    {

        private static readonly List<Cykel> cykler = new List<Cykel>()
        {
            new Cykel(1,"Rød",2000,31),
            new Cykel(2,"Hvid",1750,24),
            new Cykel(3,"Blå",1980,27),
            new Cykel(4,"Gul",1800,22),
            new Cykel(5,"Rød",1750,22)
        };

        // GET: api/<CykelController>
        [HttpGet]
        public IEnumerable<Cykel> Get()
        {
            return cykler;
        }

        // GET api/<CykelController>/5
        [HttpGet("{id}")]
        public Cykel Get(int id)
        {
            return cykler.Find(c => c.Id == id);
        }

        // POST api/<CykelController>
        [HttpPost]
        public void Post([FromBody] Cykel value)
        {
            cykler.Add(value);
        }

        // PUT api/<CykelController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Cykel value)
        {
            Cykel Cykel = Get(id);
            if (Cykel != null)
            {
                Cykel.Id = value.Id;
                Cykel.Farve = value.Farve;
                Cykel.Pris = value.Pris;
                Cykel.Gear = value.Gear;
            }
        }

        // DELETE api/<CykelController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Cykel Cykel = Get(id);
            cykler.Remove(Cykel);
        }
    }
}
