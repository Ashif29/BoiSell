using BoiSell.Core.Models;
using BoiSell.Repository.Repositories.Contracts;
using BoiSell.Repository.Repositories.Core;
using BoiSell.Web.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoiSell.Repository.Repositories.Implementations
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {

        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
