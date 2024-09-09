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
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task AddAsync(Book book)
        {
            var bookEntry = new Book()
            {
                Title = book.Title,
                Author = book.Author,
                ISBN = book.ISBN,
                Description = book.Description,
                Price = book.Price,
                Discount = book.Discount,
                SpecialTag = book.SpecialTag,
                Publisher = book.Publisher,
                PublishedDate = book.PublishedDate,
                Pages = book.Pages,
                Language = book.Language,
                CategoryId = book.CategoryId,
                ImageUrl = book.ImageUrl,
                Status = book.Status,
                CreatedAt= DateTime.Now,
                UpdatedAt= book.UpdatedAt
            };
            await _unitOfWork.BookRepository.AddAsync(bookEntry);
            await _unitOfWork.CompleteAsync();
        }

        public async Task<bool> DeleteAsync(Book book)
        {
            await _unitOfWork.BookRepository.DeleteAsync(book);
            return await _unitOfWork.CompleteAsync();
        }

        public async Task<IEnumerable<Book>> GetAllAsync(Expression<Func<Book, bool>>? filter = null, string? includeProperties = null)
        {
            return await _unitOfWork.BookRepository.GetAllAsync(filter, includeProperties);
        }

        public async Task<Book> GetByIdAsync(Expression<Func<Book, bool>> filter, string? includeProperties = null)
        {
            return await _unitOfWork.BookRepository.GetByIdAsync(filter, includeProperties);
        }

        public async Task<bool> IsExistsAsync(Expression<Func<Book, bool>> filter, string? includeProperties = null)
        {
            return await _unitOfWork.BookRepository.IsExistsAsync(filter, includeProperties);
        }

        public async Task UpdateAsync(Book book)
        {
            
            book.UpdatedAt = DateTime.Now;
            await _unitOfWork.BookRepository.UpdateAsync(book);
            await _unitOfWork.CompleteAsync();
        }
    }
}
