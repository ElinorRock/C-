using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class USERLOGINBL
    {
        MYAPPEntities db = new MYAPPEntities();
        public List<UserTable> GetUserTables()
        {
            List<UserTable> UserT = db.UserTable.ToList();
            return UserT;
        }
        public UserTable Get1UserTable(int id)
        {
            return db.UserTable.Where(X => X.UserID == id).First();
        }
    }
}