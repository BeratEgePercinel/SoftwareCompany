using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany
{
    class ProjectEmployee
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
