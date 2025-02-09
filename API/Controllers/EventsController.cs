using Business;
using DataAccess;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model;
using static Model.DTO;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly EventsService _eventsService;
        public EventsController(EventsService eventsService) 
        {
            _eventsService = eventsService;
        }
        [HttpGet]
        public async Task<ActionResult<List<Events>>> GetAllEvents()
        {
            var events = await _eventsService.GetAllEventsAsync();
            return Ok(events);
        }
        [HttpGet("{date}")]
        public async Task<ActionResult<List<Events>>> GetEventsByDateAsync(string date)
        {
            var events = await _eventsService.GetEventsByDateAsync(date);
            if (events == null)
            {
                return NotFound();
            }
            return Ok(events);
        }
        [HttpPost]
        public async Task<ActionResult> AddEvent([FromBody] Events even)
        {
            await _eventsService.AddEventAsync(even);
            return CreatedAtAction(nameof(GetAllEvents), new { id = even.ID }, even);
        }
        [HttpPut]
        public async Task<ActionResult> UpdateEvent([FromBody] Events even)
        {
            await _eventsService.UpdateEventAsync(even);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEvent(string id)
        {
            await _eventsService.DeleteEventAsync(id);
            return NoContent();
        }
        [HttpPut("{updateNotes}")]
        public async Task<ActionResult> UpdateNotes([FromBody] EventNotes eventnotes)
        {
            await _eventsService.UpdateNotesAsync(eventnotes.ID, eventnotes.Notes);
            return Ok();
        }
    }
}