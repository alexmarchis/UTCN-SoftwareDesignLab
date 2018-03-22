using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace DataAccess
{
    public class TicketDataMapper
    {
        public IEnumerable<Ticket> GetAllTickets()
        {
            using (DbConnection connection = DbConnectionBuilder.CreateConnection())
            {
                DbCommand command = DbConnectionBuilder.CreateCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT Id, TimeStamp FROM Tickets";

                connection.Open();
                DbDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        yield return new Ticket
                        {
                            Id = (int)reader[0],
                            TimeStamp = (DateTime)reader[1]
                        };
                    }
                }

                reader.Close();
            }
        }
    }
}
