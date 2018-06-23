using Database.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IUnitOfWork<K> : IDisposable
    {
        IRepository<User> UserRepository { get; }
        IRepository<Role> RoleRepository { get; }
        IRepository<SanPham> SanPhamRepository { get; }
        IRepository<QuanLySanPham> QuanLySanPhamRepository { get; }
        IRepository<QuanLyHoaDon> QuanLyHoaDonRepository { get; }
        IRepository<ChiTietHoaDon> ChiTietHoaDonRepository { get; }
        IRepository<ChiTien> ChiTienRepository { get; }
        IRepository<K> EntityRepository { get; }
        void Save();
    }
}
