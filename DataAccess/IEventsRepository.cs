using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public interface IEventsRepository
    {
        Task<List<Events>> GetAllEventsAsync();
        Task<List<Events>> GetEventsByDateAsync(string date);
        Task<bool> AddEventAsync(Events even);
        Task<bool> UpdateEventAsync(Events even);
        Task<bool> DeleteEventAsync(string id);
        Task<bool> UpdateNotesAsync(string id, string notes);
    }
}
