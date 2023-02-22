using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany
{
    class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TaxNo { get; set; }
        public string Address { get; set; }
        public int CompanyDetailId { get; set; }
        public CompanyDetail CompanyDetail { get; set; }
        public List<Employee> Employees { get; set; }
        public List<Contract> Contracts { get; set; }
    }
}
