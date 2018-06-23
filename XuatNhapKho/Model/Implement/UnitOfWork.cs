using Database.Interface;
using Database.Models;
using Model.Interface;
using System;

namespace Model.Models
{
    public class UnitOfWork<K> : IUnitOfWork<K> where K : class
    {        
        private IRepository<K> _entityRepository;

        private Secrect_DevelopmentEntities _context;
        private bool disposed = false;

        public UnitOfWork()
        {
            if (_context == null)
                _context = new Secrect_DevelopmentEntities();
            
        }        

        public IRepository<K> EntityRepository
        {
            get
            {
                if (_entityRepository == null)
                    _entityRepository = new Repository<K>(_context);
                return _entityRepository;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
