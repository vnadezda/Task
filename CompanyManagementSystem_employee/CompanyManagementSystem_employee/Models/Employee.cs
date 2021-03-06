//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CompanyManagementSystem_employee.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;

    public partial class Employee
    {
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Name")]
        public string Name { get; set; }
        public Nullable<int> Salary { get; set; }
        [DisplayName("Start Date")]
        public Nullable<System.DateTime> StartDate { get; set; }
        [DisplayName("Experiance Level")]
        public Nullable<int> ExperianceLevel { get; set; }
        [DisplayName("Vacation Days")]
        public Nullable<int> VacationDays { get; set; }
    }
}
