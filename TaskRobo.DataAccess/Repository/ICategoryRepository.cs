using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskRobo.DataAccess.Repository
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategorys();

        Category GetCategory(int id);

        void AddCategory(Category category);

        void UpdateCategory(Category category);

        void DeleteCategory(int id);
    }
}