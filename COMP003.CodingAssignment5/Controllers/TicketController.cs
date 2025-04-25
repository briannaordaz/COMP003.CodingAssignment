using COMP003.CodingAssignment5.Models;
using COMP003.CodingAssignment5.Data;
using Microsoft.AspNetCore.Mvc;

namespace COMP003.CodingAssignment5.Controllers;

[ApiController]
[Route("[controller]")]
public class TicketController : Controller
{
    [HttpGet]
    public ActionResult<List<Ticket>> GetTickets()
    {
        return Ok(TicketList.Tickets);
    }

    [HttpGet("{id}")]
    public ActionResult<Ticket> GetTicket(int id)
    {
        var ticket = TicketList.Tickets.FirstOrDefault(t => t.TicketId == id);
        
        if (ticket == null)
            return NotFound();
        
        return Ok(ticket);
    }

    [HttpPost]
    public ActionResult<Ticket> PostTicket(Ticket ticket)
    {
        ticket.TicketId = TicketList.Tickets.Max(t => t.TicketId) + 1;
        TicketList.Tickets.Add(ticket);
        
        return CreatedAtAction(nameof(GetTicket), new { id = ticket.TicketId }, ticket);
    }

    [HttpPut("{id}")]
    public IActionResult PutTicket(int id, Ticket ticket)
    {
        var ticketToUpdate = TicketList.Tickets.FirstOrDefault(t => t.TicketId == id);
        
        if (ticketToUpdate == null)
            return NotFound();
        
        ticketToUpdate.MovieName = ticket.MovieName;
        ticketToUpdate.TicketCost = ticket.TicketCost;
        
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteTicket(int id)
    {
        var ticket = TicketList.Tickets.FirstOrDefault(t => t.TicketId == id);
        
        if (ticket == null)
            return NotFound();
        
        TicketList.Tickets.Remove(ticket);
        
        return NoContent();
    }
}