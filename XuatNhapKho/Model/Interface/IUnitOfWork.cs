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
        IRepository<K> EntityRepository { get; }
        void Save();
    }
}
