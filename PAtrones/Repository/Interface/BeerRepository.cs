using Microsoft.EntityFrameworkCore;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public class BeerRepository : IBeerRepository
    {
        private DesignPatternsContext _context;

        public BeerRepository(DesignPatternsContext context)
        {
            _context = context;
        }

        public void Add(Beer data) => 
            _context.Beers.Add(data);

        public void Delete(int id)
        {
            var beer = _context.Beers.Find(id);
            _context.Beers.Remove(beer);
        }

        public IEnumerable<Beer> Get() => _context.Beers.ToList();

        public Beer Get(int id) => _context.Beers.Find(id);

        public void Save() => _context.SaveChanges();

        public void update(Beer beer) => _context.Entry(beer).State = EntityState.Modified;
    }
}
