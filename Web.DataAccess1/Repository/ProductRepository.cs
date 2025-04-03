using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Web.DataAccess1.Data;
using Web.DataAccess1.Repository.IRepository;
using Web.Models;

namespace Web.DataAccess1.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        public void Save()
        {
            _db.SaveChanges();
        }

        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(a=>a.Id == obj.Id);
            if (objFromDb != null)
            {
                objFromDb.Title = obj.Title;
                objFromDb.ISBN = obj.ISBN;
                objFromDb.Description = obj.Description;
                objFromDb.Price = obj.Price;
                objFromDb.Price50 = obj.Price50;
                objFromDb.Price100 = obj.Price100;
                objFromDb.ListPrice = obj.ListPrice;
                objFromDb.CategoryId = obj.CategoryId;
                objFromDb.Author = obj.Author;
                if (obj.ImageUrl != null)
                {
                    objFromDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
