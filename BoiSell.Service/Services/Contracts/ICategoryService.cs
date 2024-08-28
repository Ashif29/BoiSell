using BoiSell.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoiSell.Service.Services.Contracts
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync(Expression<Func<Category, bool>>? filter = null, string? includeProperties = null);
        Task<Category> GetByIdAsync(Expression<Func<Category, bool>> filter, string? includeProperties = null);
        Task<bool> IsExistsAsync(Expression<Func<Category, bool>> filter, string? includeProperties = null);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task<bool> DeleteAsync(Category category);
    }
}
