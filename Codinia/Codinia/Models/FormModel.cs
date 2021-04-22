using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Codinia.Models
{
    public class FormModel
    {
        [Required]
        public string  name { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string message { get; set; }
    }
}
