using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;

namespace WebApplication2.Models
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EMPLOYEEBL
        {
            MYAPPEntities db = new MYAPPEntities();
            public List<EmployeeTable> GetEmployeeTables()
            {
                List<EmployeeTable> EmployeeT = db.EmployeeTable.ToList();
                return EmployeeT;
            }
            public EmployeeTable Get1EmployeeTable(int id)
            {
                return db.EmployeeTable.Where(X => X.EmployeeID == id).First();
            }
        }
    }
