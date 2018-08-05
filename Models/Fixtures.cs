using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPLDataSet.Models
{
    public class Fixtures
    {
        public int FixturesID { get; set; }
        [Required]
        public long SeasonYear { get; set; }
        //public string MatchID { get; set; }
        [Required]
        public virtual IEnumerable<Team> Team { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        public string MatchResults { get; set; }
        [Required]
        public virtual IEnumerable<Stadium> StadiumName { get; set; }
    }
}
