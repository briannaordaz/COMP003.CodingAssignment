using COMP003.CodingAssignment5.Models;

namespace COMP003.CodingAssignment5.Data;

public class TicketList
{
    public static List<Ticket> Tickets { get; } = new()
    {
        new Ticket { TicketId = 1, MovieName = "Star Wars", TicketCost = 10.00m, StartTime = DateTime.Parse("2025-04-25 10:50:00 PM") },
        new Ticket { TicketId = 2, MovieName = "Wicked", TicketCost = 15.00m, StartTime = DateTime.Parse("2025-04-28 10:50:00 PM") },
        new Ticket { TicketId = 3, MovieName = "Ice Age", TicketCost = 7.99m, StartTime = DateTime.Parse("2025-04-25 10:50:00 PM")}
    };

}