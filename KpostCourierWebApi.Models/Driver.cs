using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KpostCourierWebApi.Models
{
    public class Driver
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}