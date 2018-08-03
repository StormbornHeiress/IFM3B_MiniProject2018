using System;
using System.Collections.Generic;
using System.Text;

namespace EPLDataSet.Models
{
    public class Player
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Position { get; set; }

        public virtual Team TeamName { get; set; }
    }
}
