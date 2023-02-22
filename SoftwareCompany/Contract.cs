using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany
{
    class Contract
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalAmount { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public DateTime Deadline { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
