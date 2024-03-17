using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication2.Models;
using System.Web.Http.Cors;


namespace WebApplication2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class ShiftController : ApiController
    {
        SHIFTBL ShiftTBL = new SHIFTBL();
    
        // GET: api/Shift
        public IEnumerable<ShiftTable> Get()
        {
            return ShiftTBL.GetShiftTables();
        }

        // GET: api/Shift/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Shift
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Shift/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Shift/5
        public void Delete(int id)
        {
        }
    }
}
