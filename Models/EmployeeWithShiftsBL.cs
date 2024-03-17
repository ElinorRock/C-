using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;

namespace WebApplication2.Models
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class EmployeeWithShiftsBL
    {
        MYAPPEntities db = new MYAPPEntities();

        public List<EmployeeTableWithEmployeeShiftTable> GetEmployeeWithShifts()
        {
            List<EmployeeTableWithEmployeeShiftTable> EmployeesWithShifts = new List<EmployeeTableWithEmployeeShiftTable>();
            foreach (var Emplo in db.EmployeeTable)
            {
                EmployeeTableWithEmployeeShiftTable EmploWithShifts = new EmployeeTableWithEmployeeShiftTable();
                EmploWithShifts.EmployeeID = Emplo.EmployeeID;
                EmploWithShifts.FirstName = Emplo.FirstName;
                EmploWithShifts.LastName = Emplo.LastName;
                EmploWithShifts.StartYearWork = Emplo.StartYearWork;
                EmploWithShifts.DepartmentID = Emplo.DepartmentID;
                EmploWithShifts.UserID = Emplo.UserID;
                EmploWithShifts.CombainEMPLOWithSHIFT
                    = db.EmployeeShiftTable.Where(x => x.EmployeeID == Emplo.EmployeeID).Select(x => x.ShiftID).ToList();

                EmployeesWithShifts.Add(EmploWithShifts);
            }

            return EmployeesWithShifts;
        }
    }
}