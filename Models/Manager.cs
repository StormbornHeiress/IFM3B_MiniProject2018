using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPLDataSet.Models
{
    public class Manager
    {
        public int ManagerID { get; set; }//pk
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        //public int TeamForeignKeyId { get; set; }

        //public Team Team { get; set; }
        //[Required]
        //public virtual Team TeamName { get; set; }
    }
}
