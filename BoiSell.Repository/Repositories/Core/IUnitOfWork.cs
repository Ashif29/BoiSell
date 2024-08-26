using BoiSell.Repository.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoiSell.Repository.Repositories.Core
{
    public interface IUnitOfWork
    {

        ICategoryRepository CategoryRepository { get; }
        Task<bool> CompleteAsync();
    }
}
