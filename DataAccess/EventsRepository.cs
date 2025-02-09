using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class EventsRepository : BaseRepository, IEventsRepository
    {
        public EventsRepository() : base()
        {
        }

        public async Task<List<Events>> GetAllEventsAsync()
        {
            string query = "SELECT * FROM Events";
            DataTable table = GetData(query);
            List<Events> events = new List<Events>();
            foreach (DataRow row in table.Rows) 
            {
                Events even = new Events();
                var properties = typeof(Events).GetProperties();
                for (int i = 0; i < properties.Length; i++) 
                {
                    if (row[i] != DBNull.Value) 
                    {
                        properties[i].SetValue(even, row[i]);
                    }
                }
                events.Add(even);
            }
            return events;
        }
        public async Task<List<Events>> GetEventsByDateAsync(string date)
        {
            string decodedDate = Uri.UnescapeDataString(date);
            string query = $"SELECT * FROM Events WHERE Date = '{decodedDate}'";
            DataTable table = GetData(query);
            List <Events> events = new List<Events>();
            foreach (DataRow row in table.Rows)
            {
                Events even = new Events();
                var properties = typeof(Events).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(even, row[i]);
                    }
                }
                events.Add(even);
            }
            return events;
        }
        public async Task<bool> AddEventAsync(Events even)
        {
            var parameters = new Dictionary<string, object>
            {
                { "ID", even.ID },
                { "Summary", even.Summary },
                { "Date", even.Date },
                { "Notes", even.Notes }
            };
            Insert("Events", parameters);
            return true;
        }
        public async Task<bool> UpdateEventAsync(Events even)
        {
            var parameters = new Dictionary<string, object>
            {
                { "ID", even.ID },
                { "Summary", even.Summary },
                { "Date", even.Date },
                { "Notes", even.Notes }
            };
            string condition = $"ID = '{even.ID}'";
            Update("Events", parameters, condition);
            return true;
        }
        public async Task<bool> DeleteEventAsync(string id)
        {
            string condition = $"ID = '{id}'";
            Delete("Events", condition);
            return true;
        }
        public async Task<bool> UpdateNotesAsync(string id, string notes)
        {
            var parameters = new Dictionary<string, object>
            {
                { "Notes", notes }
            };
            string condition = $"ID = '{id}'";
            Update("Events", parameters, condition);
            return true;
        }
    }
}
