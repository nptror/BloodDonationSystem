using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace BDS.Common.DAL
{
    public class GenericRep<c, T> : IGenericRep<T> where T : class where c : DbContext, new()
    {
        private c _context;

        public c Context
        {
            get { return _context; }
            set { _context = value; }
        }

        public GenericRep()
        {
            _context = new c();
        }

        public IQueryable<T> GetAll { get { return _context.Set<T>(); } }

        public void Create(T m)
        {
            _context.Set<T>().Add(m);
            _context.SaveChanges();
        }

        public void CreateList(List<T> l)
        {
            _context.Set<T>().AddRange(l);
            _context.SaveChanges();
        }

        public void Delete(T m)
        {
            _context.Set<T>().Remove(m);
            _context.SaveChanges();

        }

        public void DeleteList(List<T> l)
        {
            _context.Set<T>().RemoveRange(l);

        }

        public IQueryable<T> Read(Expression<Func<T, bool>> p)
        {
            return _context.Set<T>().Where(p);
        }

        public virtual T ReadById(int id)
        { return null; 
        }

        public void Update(T m)
        {
        _context.Set<T>().Update(m);
            _context.SaveChanges(); 
        }

        public void UpdateList(List<T> l)
        {
        _context.Set<T>().UpdateRange(l);
            _context.SaveChanges(); 
        }
    }
}
