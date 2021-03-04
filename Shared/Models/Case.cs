using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorDemo2.Shared.Models
{
    public class Case
    {
        public int id { get; set; }
        public string Title { get; set; }
        public CaseType CaseType { get; set; }
        public int CaseTypeId { get; set; }
        public int CompanyId { get; set; }
        public string Details { get; set; }
        public string refNumber { get; set; }
        public string reCaptcha { get; set; }

    }
}
