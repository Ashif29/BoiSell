using BoiSell.Repository.Repositories.Contracts;
using BoiSell.Repository.Repositories.Implementations;
using BoiSell.Web.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoiSell.Repository.Repositories.Core
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;
        public ICategoryRepository CategoryRepository { get; private set; }
        public IBookRepository BookRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            this.CategoryRepository = new CategoryRepository(_db);
            this.BookRepository = new BookRepository(_db);
        }

        public async Task<bool> CompleteAsync()
        {
            return await _db.SaveChangesAsync() > 0;
        }
    }
}
