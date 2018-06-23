using Database.Interface;
using Database.Models;
using Model.Interface;
using System;

namespace Model.Models
{
    public class UnitOfWork<K> : IUnitOfWork<K> where K : class
    {
        private IRepository<User> _userRepository;
        private IRepository<Role> _roleRepository;
        private IRepository<SanPham> _sanPhamRepository;
        private IRepository<QuanLySanPham> _quanLySanPhamRepository;
        private IRepository<QuanLyHoaDon> _quanLyHoaDonRepository;
        private IRepository<ChiTietHoaDon> _chiTietHoaDonRepository;
        private IRepository<ChiTien> _chiTienRepository;
        private IRepository<K> _entityRepository;

        private Secrect_DevelopmentEntities _context;
        private bool disposed = false;

        public UnitOfWork()
        {
            if (_context == null)
                _context = new Secrect_DevelopmentEntities();
            
        }
        public IRepository<User> UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new Repository<User>(_context);
                return _userRepository;
            }
        }

        public IRepository<Role> RoleRepository
        {
            get
            {
                if (_roleRepository == null)
                    _roleRepository = new Repository<Role>(_context);
                return _roleRepository;
            }
        }

        public IRepository<SanPham> SanPhamRepository
        {
            get
            {
                if (_sanPhamRepository == null)
                    _sanPhamRepository = new Repository<SanPham>(_context);
                return _sanPhamRepository;
            }
        }

        public IRepository<QuanLySanPham> QuanLySanPhamRepository
        {
            get
            {
                if (_quanLySanPhamRepository == null)
                    _quanLySanPhamRepository = new Repository<QuanLySanPham>(_context);
                return _quanLySanPhamRepository;
            }
        }

        public IRepository<QuanLyHoaDon> QuanLyHoaDonRepository
        {
            get
            {
                if (_quanLyHoaDonRepository == null)
                    _quanLyHoaDonRepository = new Repository<QuanLyHoaDon>(_context);
                return _quanLyHoaDonRepository;
            }
        }

        public IRepository<ChiTietHoaDon> ChiTietHoaDonRepository
        {
            get
            {
                if (_chiTietHoaDonRepository == null)
                    _chiTietHoaDonRepository = new Repository<ChiTietHoaDon>(_context);
                return _chiTietHoaDonRepository;
            }
        }

        public IRepository<ChiTien> ChiTienRepository
        {
            get
            {
                if (_chiTienRepository == null)
                    _chiTienRepository = new Repository<ChiTien>(_context);
                return _chiTienRepository;
            }
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
