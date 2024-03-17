using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Cors;

namespace WebApplication2.Models
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class DEPARTMENTBL
    {
        MYAPPEntities db = new MYAPPEntities();
        public List<DepartmentTable> GetDepartmentTables()
        {
            List<DepartmentTable> DepartmentT = db.DepartmentTable.ToList();
            return DepartmentT;
        }
        public DepartmentTable Get1DepartmentTable(int id)
        {
            return db.DepartmentTable.Where(X => X.DepartmentID == id).First();
        }
        public string AddDepartmenttoTable(DepartmentTable DepartmentT)
        {
            db.DepartmentTable.Add(DepartmentT);
            db.SaveChanges();
            return "CreatedNewDepartment!";
        }
        public string UpdateDepartmentTables(int id, DepartmentTable DepartmentT) 
        {
            DepartmentTable Depart = db.DepartmentTable.Where(X => X.DepartmentID == id).First();
            if(Depart != null) 
            {
                Depart.DepartmentName = DepartmentT.DepartmentName;
                Depart.ManagerID = DepartmentT.ManagerID;
                Depart.UserID = DepartmentT.UserID;
            }
            db.SaveChanges();
            return "UpddatedDepartment";
        }
        public string DeleteDepartmentTable(int id) 
        {
         DepartmentTable Depart = db.DepartmentTable.Where(X => X.DepartmentID == id).First();
         if(Depart != null)
         {
                db.DepartmentTable.Remove(Depart);
                db.SaveChanges();
         }
            return "DeletedDepartmentTable";
        }
    }    
  }