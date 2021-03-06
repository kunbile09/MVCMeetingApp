//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeetingApp.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.Employee_Guest = new HashSet<Employee_Guest>();
            this.Meeting_Employee = new HashSet<Meeting_Employee>();
            this.Notes = new HashSet<Note>();
        }
    
        public int Id { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Nullable<int> Role_Id { get; set; }
        public string EmployeeStatus { get; set; }
        public Nullable<int> Manager_Id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee_Guest> Employee_Guest { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Meeting_Employee> Meeting_Employee { get; set; }
        public virtual Role Role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Note> Notes { get; set; }
    }
}
