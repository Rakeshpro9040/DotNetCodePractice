using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPractice
{
    class NullCoalescing
    {
        public NullCoalescing()
        {
            int? TicketsOnSale = 100;
            int AvailableTickets = TicketsOnSale ?? 0;
            Console.WriteLine($"Avilable Tickets: {AvailableTickets}");

            bool? IsAvailableTickets = AvailableTickets > 0 ? true : false;
            Console.WriteLine($"IsAvailableTickets: {IsAvailableTickets}");

        }
    }
}
