using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class SHIFTBL
    {
        MYAPPEntities db = new MYAPPEntities();
        public List<ShiftTable> GetShiftTables()
        {
            List<ShiftTable> ShiftT = db.ShiftTable.ToList();
            return ShiftT;
        }
        public ShiftTable Get1EShiftTable(int id)
        {
            return db.ShiftTable.Where(X => X.ShiftID == id).First();
        }
    }
}