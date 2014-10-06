using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace week_6_1_code_challenge.Models
{
    public class Contactajax
    {
        [Required, Display(Name = "Your Name")]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required, DataType(DataType.MultilineText)]
        public string Message { get; set; }
    }
}