using System;
using System.Collections.Generic;
using System.Text;

namespace EPLDataSet.Models
{
    public class ReserveMatchDayTicket 
    {
        public int ReserveMatchDayTicketID { get; set; }

        public virtual IEnumerable<Customer> Customer { get; set; }

        public virtual IEnumerable<Fixtures> Fixture { get; set; }

        public DateTime ReserveDate { get; set; }

        public int NoOfSeatsReserved { get; set; }


        public string ReserveStatus { get; set; }
        public string BuyStatus { get; set; }
        public string ExpireStatus { get; set; }
    }
}
