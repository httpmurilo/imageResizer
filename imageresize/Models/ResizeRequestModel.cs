using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace imageresize.Models
{
    public class ResizeRequestModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Format { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public int? Quality { get; set; }
    }
}
