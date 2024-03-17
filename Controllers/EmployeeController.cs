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

    public class EmployeeController : ApiController
    {
        EMPLOYEEBL EmployeeTBL = new EMPLOYEEBL();

        // GET: api/Employee
        public IEnumerable<EmployeeTable> Get()
        {
            return EmployeeTBL.GetEmployeeTables();
        }

        // GET: api/Employee/5
        public EmployeeTable Get(int id)
        {
            return EmployeeTBL.Get1EmployeeTable(id);
        }


        // POST: api/Employee
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Employee/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Employee/5
        public void Delete(int id)
        {
        }
    }
}
