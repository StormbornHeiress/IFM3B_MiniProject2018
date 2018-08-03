using System;
using System.Collections.Generic;
using System.Text;

namespace EPLDataSet.Models
{
    public class Fixtures
    {
        public virtual Team TeamName { get; set; }

        public DateTime DateTime { get; set; }

        public virtual Stadium StadiumName { get; set; }
    }
}
