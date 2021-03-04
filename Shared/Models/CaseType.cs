using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo2.Shared.Models
{
    public class CaseType
    {
        public int id { get; set; }
        [Required]
        public string Title { get; set; }
    }
}
