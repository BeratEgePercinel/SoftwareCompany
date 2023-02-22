using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareCompany
{
    class CompanyDetail
    {
        public int Id { get; set; }
        public int PostCode { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
    }
}
