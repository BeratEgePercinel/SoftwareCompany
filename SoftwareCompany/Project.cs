using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany
{
    class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public CompanyDetailChart CompanyDetailChartId { get; set; }
        public List<ProjectEmployee> ProjectEmployees { get; set; }
    }
}
