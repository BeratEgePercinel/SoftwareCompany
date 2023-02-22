using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TC { get; set; }
        public int Salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Company CompanyId { get; set; }
        public List<ProjectEmployee> ProjectEmployees { get; set; }
    }
}
