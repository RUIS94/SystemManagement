using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace Business
{
    public class EventsService
    {
        private readonly IEventsRepository _eventsRepository;
        public EventsService(IEventsRepository eventsRepository) 
        {
            _eventsRepository = eventsRepository;
        }
        public async Task<List<Events>> GetAllEventsAsync()
        {
            return await _eventsRepository.GetAllEventsAsync();
        }
        public async Task<List<Events>> GetEventsByDateAsync(string date)
        {
            return await _eventsRepository.GetEventsByDateAsync(date);
        }
        public async Task<bool> AddEventAsync(Events even)
        {
            return await _eventsRepository.AddEventAsync(even);
        }
        public async Task<bool> UpdateEventAsync(Events even)
        {
            return await _eventsRepository.UpdateEventAsync(even);
        }
        public async Task<bool> DeleteEventAsync(string id)
        {
            return await _eventsRepository.DeleteEventAsync(id);
        }
        public async Task<bool> UpdateNotesAsync(string id, string notes)
        {
            return await _eventsRepository.UpdateNotesAsync(id, notes);
        }
    }
}