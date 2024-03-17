using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;

namespace WebApplication2.Models
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeTableWithEmployeeShiftTable
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> StartYearWork { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> UserID { get; set; }
        public List<int?> CombainEMPLOWithSHIFT { get; internal set; }
        public List<String> Actions{ get; set; }

            }
}

