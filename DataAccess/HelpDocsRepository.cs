using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using Model;

namespace DataAccess
{
    public class HelpDocsRepository : BaseRepository, IHelpDocsRepository
    {
        public HelpDocsRepository() : base()
        {
        }
        public async Task<List<HelpDocs>> GetAllHelpDocsAsync()
        {
            string query = "SELECT * FROM HelpDocs";
            DataTable table = GetData(query);
            List<HelpDocs> docs = new List<HelpDocs>();

            foreach (DataRow row in table.Rows)
            {
                HelpDocs doc = new HelpDocs();
                var properties = typeof(HelpDocs).GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                    if (row[i] != DBNull.Value)
                    {
                        properties[i].SetValue(doc, row[i]);
                    }
                }
                docs.Add(doc);
            }

            return docs;
        }
        public async Task<List<HelpDocs>> GetHelpDocsByTerm(string term)
        {
            string query = $"SELECT * FROM HelpDocs WHERE Name Like '%{term}%'";
            DataTable table = GetData(query);
            List<HelpDocs> docs = new List<HelpDocs>();
            foreach (DataRow row in table.Rows) 
            {
                HelpDocs doc = new HelpDocs();
                var properties = typeof (HelpDocs).GetProperties();
                for (int i = 0; i < properties.Length; i++) 
                {
                    if (row[i] != DBNull.Value) 
                    {
                        properties[i].SetValue(doc, row[i]);
                    }
                }
                docs.Add(doc);
            }
            return docs;
        }
    }
}
