//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeShiftTable
    {
        public int EmployeeShiftID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public Nullable<int> ShiftID { get; set; }
    
        public virtual EmployeeTable EmployeeTable { get; set; }
        public virtual ShiftTable ShiftTable { get; set; }
    }
}
