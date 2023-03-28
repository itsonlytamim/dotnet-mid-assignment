using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace dot_net_mid_assignment_Tamim.Models
{
    public class CollectRequestViewModel
    {
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Maximum Preserve Time")]
        [DataType(DataType.DateTime)]
        public DateTime MaxPreserveTime { get; set; }
    }

}