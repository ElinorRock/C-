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

    public class employeeShiftsController : ApiController
    {
        EmployeeWithShiftsBL EmploWithShiftsBL = new EmployeeWithShiftsBL();
        // GET: api/employeeShifts
        public IEnumerable<EmployeeTableWithEmployeeShiftTable> Get()
        {
            return EmploWithShiftsBL.GetEmployeeWithShifts();
        }

        // GET: api/employeeShifts/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/employeeShifts
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/employeeShifts/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/employeeShifts/5
        public void Delete(int id)
        {
        }
    }
}