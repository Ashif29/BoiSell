using BoiSell.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoiSell.Service.Services.Contracts
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllAsync(Expression<Func<Book, bool>>? filter = null, string? includeProperties = null);
        Task<Book> GetByIdAsync(Expression<Func<Book, bool>> filter, string? includeProperties = null);
        Task<bool> IsExistsAsync(Expression<Func<Book, bool>> filter, string? includeProperties = null);
        Task AddAsync(Book book);
        Task UpdateAsync(Book book);
        Task<bool> DeleteAsync(Book book);
    }
}
