using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab2._2.Models
{
    public class Event
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [MinLength(5), MaxLength(30)]
        public string location { get; set; }

    }
}