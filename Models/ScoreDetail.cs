using System;
using System.Collections.Generic;
using System.Text;

namespace EPLDataSet.Models
{
    public class ScoreDetail
    {
        public int ScoreDetailID { get; set; }

        //public int MatchID { get; set; }
        public Fixtures Fixture { get; set; }

        public string SeasonYear { get; set; }

        public virtual IEnumerable<Player> PlayerID { get; set; }

        public int ScoreMinute { get; set; }

        public string ScoreKind { get; set; }//Win or Lose
    }
}
