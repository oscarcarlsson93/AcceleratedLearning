using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirdWatcher.Web.Models
{
    public class Repository
    {
        private readonly ObservationContext _context;

        public Repository(ObservationContext context)
        {
            _context = context;
        }

        public void Add(Observation observation)
        {
            _context.Add(observation);
            _context.SaveChanges();
        }
        
        public void RecreateDatabase()
        {
            
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            //[Bind("Id,Name")];
        }

        public IEnumerable<Observation> GetAll()
        {
            return _context.Observations.OrderBy(x => x.Date).ToList(); 
            

            
        }

        public IEnumerable<string> GetAllUnique()
        {
            List<string> allNames = _context.Observations.Select(x => x.Name).Distinct().ToList();
            return allNames.OrderBy(x => x);
        }
    }
}
