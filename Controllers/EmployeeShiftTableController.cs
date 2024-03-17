using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class EmployeeShiftTableController : ApiController
        {
        EmployeeShiftTableBL EmploShiftBL = new EmployeeShiftTableBL();

        // GET: api/EmployeeShiftTable
        public IEnumerable<EmployeeShiftTable> Get()
        {
            return EmploShiftBL.GetEmployeeShiftTabsle();
        }

        // GET: api/EmployeeShiftTable/5
        public EmployeeShiftTable Get(int id)
        {
            return EmploShiftBL.Get1EmployeeShiftTable(id);
        }

        // POST: api/EmployeeShiftTable
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/EmployeeShiftTable/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EmployeeShiftTable/5
        public void Delete(int id)
        {
        }
    }
}
