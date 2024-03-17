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
    [EnableCors(origins:"*", headers:"*", methods:"*")]
    public class LogInController : ApiController
    {
        USERLOGINBL UserTBL = new USERLOGINBL();
        // GET: api/LogIn
        public IEnumerable<UserTable> Get()
        {
            return UserTBL.GetUserTables();
        }

        // GET: api/LogIn/5
        public UserTable Get(int id)
        {
            return UserTBL.Get1UserTable(id);
        }

        // POST: api/LogIn
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/LogIn/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/LogIn/5
        public void Delete(int id)
        {
        }
    }
}
