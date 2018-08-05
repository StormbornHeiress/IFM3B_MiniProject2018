using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPLDataSet.Models
{
    public class Player
    {

        public  int PlayerID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        
        
        [Required]
        public int PlayerDOB { get; set; }
        public string PlayerPlaceOfBirth { get; set; }
        public int Age { get; set; }
        public int JerseyNo { get; set; }
        [Required]
        public string PlayerGameStatus { get; set; }
        [Required]
        public string PlayerNationality { get; set; }

        public string Position { get; set; }
        [Required]
        public virtual Team Team { get; set; }

        //public int calculateAge(int PlayerDOB)
        //{
        //    return PlayerDOB;
        //}
    }
}
