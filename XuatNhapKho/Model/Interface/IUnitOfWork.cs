using Database.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> StudentRepository { get; }
        void Save();
    }
}
