using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EPLDataSet.Models
{
    public class Customer
    {

        public int CustomerID { get; set; }//pk
        [Required]
        public string CustFirstName { get; set; }
        [Required]
        public string CustLastName { get; set; }

        //public virtual IEnumerable<Fixtures> Fixtures { get; set; }
    }
}
