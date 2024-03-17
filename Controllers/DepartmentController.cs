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

    public class DepartmentController : ApiController
    {
        DEPARTMENTBL DepartmentTBL = new DEPARTMENTBL();

        // GET: api/Department
        public IEnumerable<DepartmentTable> Get()
        {
            return DepartmentTBL.GetDepartmentTables();
        }

        // GET: api/Department/5
        public DepartmentTable Get(int id)
        {
            return DepartmentTBL.Get1DepartmentTable(id);
        }

        // POST: api/Department
        public string Post(DepartmentTable newDepartment)
        {
            return DepartmentTBL.AddDepartmenttoTable(newDepartment);
        }

        // PUT: api/Department/5
        public string Put(int id, DepartmentTable DepartmentT)
        {
            return DepartmentTBL.UpdateDepartmentTables(id, DepartmentT);
        }

        // DELETE: api/Department/5
        public string Delete(int id)
        {
            return DepartmentTBL.DeleteDepartmentTable(id);

        }
    }
}
