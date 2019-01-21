using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoint06
{
   public class DataAccess
    {
        private SpaceContext _context;

        public DataAccess()
        {
            _context = new SpaceContext();
        }

        internal void AddSpaceship(string v)
        {

            _context.Add(new Spaceship { Name = v });
            _context.SaveChanges();
        }



    }
}
