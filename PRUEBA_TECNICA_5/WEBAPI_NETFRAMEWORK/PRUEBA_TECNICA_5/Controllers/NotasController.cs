using PRUEBA_TECNICA_5.Data;
using PRUEBA_TECNICA_5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PRUEBA_TECNICA_5.Controllers
{
    public class NotasController : ApiController
    {
        // GET api/<controller>
        public List<Notas> Get()
        {
            return NotasData.Listar();
        }

        /*
        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }*/
    }
}