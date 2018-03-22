using System;
using System.Linq;
using DataAccess;

namespace Services
{
    public class TicketService
    {
        private int ticketPrice = 200;

        public int GetTotalRevenue()
        {
            TicketDataMapper dataMapper = new TicketDataMapper();
            return dataMapper.GetAllTickets().Count() * ticketPrice;
        }

        public int GetRevenue(DateTime date)
        {
            TicketDataMapper dataMapper = new TicketDataMapper();
            return dataMapper.GetAllTickets().Count(t => t.TimeStamp.Date == date.Date) * ticketPrice;
        }
    }
}
