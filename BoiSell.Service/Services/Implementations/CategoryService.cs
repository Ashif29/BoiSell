using BoiSell.Core.Models;
using BoiSell.Repository.Repositories.Core;
using BoiSell.Service.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BoiSell.Service.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddAsync(Category category)
        {
            var categoryEntry = new Category()
            {
                Name = category.Name,
            };
            await _unitOfWork.CategoryRepository.AddAsync(categoryEntry);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<bool> DeleteAsync(Category category)
        {
            await _unitOfWork.CategoryRepository.DeleteAsync(category);
            return await _unitOfWork.CompleteAsync();
        }

        public async Task<IEnumerable<Category>> GetAllAsync(Expression<Func<Category, bool>>? filter = null, string? includeProperties = null)
        {
            return await _unitOfWork.CategoryRepository.GetAllAsync(filter, includeProperties);
        }

        public async Task<Category> GetByIdAsync(Expression<Func<Category, bool>> filter, string? includeProperties = null)
        {
            return await _unitOfWork.CategoryRepository.GetByIdAsync(filter, includeProperties);
        }

        public async Task<bool> IsExistsAsync(Expression<Func<Category, bool>> filter, string? includeProperties = null)
        {
            return await _unitOfWork.CategoryRepository.IsExistsAsync(filter, includeProperties);
        }

        public async Task UpdateAsync(Category category)
        {
            var categoryEntry = new Category()
            {
                Name = category.Name,
            };
            await _unitOfWork.CategoryRepository.UpdateAsync(categoryEntry);
            await _unitOfWork.CompleteAsync();
        }
    }
}
