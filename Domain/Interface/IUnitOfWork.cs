using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        //IWriteRepository<Course> Courses { get; }
        //IWriteRepository<User> Users { get; }


        Task<int> CommitAsync();
    }
}
