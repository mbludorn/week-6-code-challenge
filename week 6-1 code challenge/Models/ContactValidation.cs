﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace week_6_1_code_challenge.Models
{
    //Step 2: create a partial class for the class we are trying to validate
    //Step 3: add the data annotation for the metadata type 
    [MetadataType(typeof(ContactValidation))]
    public partial class contactformModel
    {
    }
    public class ContactValidation
    {
        //Step 4: declare properties of the class you want to validate,
        //and set data annotations
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Body { get; set; }


    }
}