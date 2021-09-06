using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TecBank_API.Models;

namespace TecBank_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolController : Controller
    {
        RolManager rm = new RolManager();

        // GET: api/<ClienteController>
        [HttpGet]
        public List<Rol> Get()
        {
            return rm.ListaDeRoles;
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Rol Get(string id)
        {
            return rm.consultarRol(id);
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(string id, string atributoAcambiar, string ValorParaCambiar)
        {
            rm.actualizarRol(id, atributoAcambiar, ValorParaCambiar);
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            rm.eliminarRol(id);
        }
    }
}
