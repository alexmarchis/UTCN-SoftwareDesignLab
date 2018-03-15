using System;
using System.Collections.Generic;

namespace DataAccess
{
    public class TicketDataMapper
    {
        public List<Ticket> GetAllTickets()
        {
            return new List<Ticket>
            {
                new Ticket{Id = 1, TimeStamp = DateTime.Now},
                new Ticket{Id = 2, TimeStamp = DateTime.Now.AddDays(-1)},
                new Ticket{Id = 3, TimeStamp = DateTime.Now.AddHours(-1)},
                new Ticket{Id = 4, TimeStamp = DateTime.Now.AddDays(-2)},
                new Ticket{Id = 5, TimeStamp = DateTime.Now.AddDays(-2)}
            };
        }
    }
}
