using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskRobo.DataAccess.Repository
{
    public class CategoryRepository : ICategoryRepository, IDisposable
    {
        private TaskRoboDbContext db = new TaskRoboDbContext();
        public IEnumerable<Category> GetCategorys()
        {
          var Categorys =   db.Category.ToList();

          return Categorys;
        }

        public Category GetCategory(int id)
        {
           return db.Category.Find(id);
        }

        public void AddCategory(Category category)
        {
            db.Category.Add(category);
            db.SaveChanges();
        }

        public void UpdateCategory(Category category)
        {
            db.Entry(category).State = EntityState.Modified;
            db.SaveChanges();
        }

        public void DeleteCategory(int id)
        {
            Category categorys = db.Category.Find(id);
            db.Category.Remove(categorys);
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}