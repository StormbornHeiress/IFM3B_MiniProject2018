using System;
using System.Collections.Generic;
using System.Text;

namespace EPLDataSet.Models
{
    public class Manager
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual Team TeamName { get; set; }
    }
}
