using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPLDataSet.Models
{
     public class Team
    {
        public int TeamID { get; set; }//pk
        [Required]
        public string TeamName { get; set; }
        [Required]
        public string TeamHomeTown { get; set; }
        [Required]
        public virtual Manager Managers { get; set; }
        [Required]
        public virtual IEnumerable<Player> Players { get; set; }

        //public virtual Manager ManagerID { get; set; }//FK
        public string TelephoneNo { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        public string HomeJersey { get; set; }
        public string AwayJersey { get; set; }




    }
}
