using Microsoft.EntityFrameworkCore;
using Science_Conferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScienceConferences.Data
{
    public class ConferencesRepository
    {
        private readonly AppDbContext _dbContext;

        public ConferencesRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddConference(Conference conference)
        {
            _dbContext.Conferences.Add(conference);
            _dbContext.SaveChanges();
        }

        public void UpdateConference(Conference conference)
        {
            _dbContext.Conferences.Update(conference);
            _dbContext.SaveChanges();
        }

        public void DeleteConference(Conference conference)
        {
            _dbContext.Conferences.Remove(conference);
            _dbContext.SaveChanges();
        }

        public List<Conference> GetAllConferences()
        {
            return _dbContext.Conferences.ToList();
        }

    }
}
