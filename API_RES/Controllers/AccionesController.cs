using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_RES.Controllers
{
    public class AccionesController : ApiController
    {
        // GET: api/Acciones
        public IEnumerable<Models.Clase> Get()
        {
            return new Models.Clase[] { new Models.Clase()
                {
                id = 1,
                nombre = "Fabio"
                }
            };
        }

        // GET: api/Acciones/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Acciones
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Acciones/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Acciones/5
        public void Delete(int id)
        {
        }
    }
}
