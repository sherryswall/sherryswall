using System;
using System.Collections.Generic;
using System.Text;

namespace SherrysWall.DAL
{
    public class Repository
    {
        private SherrysWallContext _context;

        public Repository(SherrysWallContext context) {

            _context = context;
        }

        public void Add<T>(T item) where T : class
        {
            var itemObject = Activator.CreateInstance<T>();
            itemObject = item;

            _context.Add(itemObject);
            _context.SaveChanges();
        }
        public void Remove<T>(T item) where T : class
        {
            var itemObject = Activator.CreateInstance<T>();
            itemObject = item;

            _context.Remove<T>(item);
            _context.SaveChanges();
        }

        public T Update<T>(T item) where T : class
        {
            var currentItme=_context.Find<T>(item);

            currentItme = item;

            _context.Update<T>(currentItme);
            _context.SaveChanges();
            return currentItme;
        }
    }
}
