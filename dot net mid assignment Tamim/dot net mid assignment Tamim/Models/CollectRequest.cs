using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dot_net_mid_assignment_Tamim.Models
{
    public class CollectRequest
    {
        [Key]
        public int id { get; set; }
        [Required]
        public Restaurant restaurant { get; set; }
        public string description { get; set; }
        public DateTime max_preserve_time { get; set; }
        public string status { get; set; }
        public Employee employee { get; set; }
        public DateTime collection_time { get; set; }
        public DateTime completion_time { get; set; }

    }
}