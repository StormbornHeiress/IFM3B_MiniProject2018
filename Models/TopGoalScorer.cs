using System;
using System.Collections.Generic;
using System.Text;

namespace EPLDataSet.Models
{
    public class TopGoalScorer
    {
        public int TopGoalScorerID { get; set; }

        public virtual Player FirstName { get; set; }
        public virtual Player LastName { get; set; }

        public int PlayerRank { get; set; }//could use this as a foreign key.
        public int TotalScore { get; set; }

        //public int calculateTotalScore(int TotalScore)
        //{
        //    return TotalScore;
        //}

        //public void sortRank(TopGoalScorer)
        //{

        //}
    }
}
