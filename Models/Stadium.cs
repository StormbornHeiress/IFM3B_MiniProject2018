using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPLDataSet.Models
{
    public class Stadium
    {
        public int StadiumID { get; set; }
        [Required]
        public string StadiumName { get; set; }
        [Required]
        public string StadiumLocation { get; set; }


        
    }
}
