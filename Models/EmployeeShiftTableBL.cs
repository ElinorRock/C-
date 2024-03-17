using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;

namespace WebApplication2.Models
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeShiftTableBL
    {
        MYAPPEntities db = new MYAPPEntities();
        public List<EmployeeShiftTable> GetEmployeeShiftTabsle()
        {
            List<EmployeeShiftTable> EmploShiftT = db.EmployeeShiftTable.ToList();
            return EmploShiftT;
        }
        public EmployeeShiftTable Get1EmployeeShiftTable(int id)
        {
            return db.EmployeeShiftTable.Where(X => X.EmployeeID == id).First();
        }
    }
}
    