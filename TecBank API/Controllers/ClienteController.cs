using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TecBank_API.DBMS.File_manager;
using TecBank_API.Models;

namespace TecBank_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        ClienteManager cm = new ClienteManager();

        // GET: api/<ClienteController>
        [HttpGet]
        public List<Cliente> Get()
        {
            return cm.listarClientes();
        }

        // GET api/<ClienteController>/5
        [HttpGet("{id}")]
        public Cliente Get(string id)
        {
            return cm.consultarCliente(id);
        }

        // POST api/<ClienteController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ClienteController>/5
        [HttpPut("{id}")]
        public void Put(string llave, string valor)
        {
            cm.actualizarCliente("{id}", llave, valor);
        }

        // DELETE api/<ClienteController>/5
        [HttpDelete]
        public void Delete(string cedula)
        {
            cm.eliminarCliente(cedula);
        }
    }
}
