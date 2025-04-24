namespace COMP003.CodingAssignment5.Models;

public class Ticket
{
    public int TicketId { get; set; }
    
    public string MovieName { get; set; } = string.Empty;
    
    public decimal TicketCost { get; set; }
    
    public DateTime StartTime { get; set; }
    
}