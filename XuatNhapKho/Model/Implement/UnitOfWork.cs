using Database.Interface;
using Database.Models;
using Model.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class UnitOfWork : IUnitOfWork
    {
        private IRepository<User> _userRepository;
        private Secrect_DevelopmentEntities _context;
        private bool disposed = false;
        public UnitOfWork()
        {
            if (_context == null)
                _context = new Secrect_DevelopmentEntities();
            
        }
        public IRepository<User> StudentRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new Repository<User>(_context);
                return _userRepository;
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
