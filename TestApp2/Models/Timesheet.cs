//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestApp2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timesheet
    {
        public int Id_Timesheet { get; set; }
        public Nullable<int> Id_Customers { get; set; }
        public Nullable<int> Id_Contractor { get; set; }
        public Nullable<int> Id_Employee { get; set; }
        public Nullable<int> id_WorkAssignment { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> StopTime { get; set; }
        public string TotalTime { get; set; }
        public string Comments { get; set; }
        public Nullable<bool> WorkCompleted { get; set; }
        public Nullable<System.DateTime> CreatedAt { get; set; }
        public Nullable<System.DateTime> LastModifiedAt { get; set; }
        public Nullable<System.DateTime> DeletedAt { get; set; }
        public Nullable<bool> Active { get; set; }
    
        public virtual Contractor Contractor { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual WorkAssignment WorkAssignment { get; set; }
    }
}
