using CatalogCartingServiceAPIGateway.Models.DbModels;
using CatalogCartingServiceAPIGateway.Data;

namespace CatalogCartingServiceAPIGateway.Services
{
    public class CategoryService
    {
        private readonly DataContext dataContext;

        public CategoryService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public List<Category> GetAll()
        {
            return this.dataContext.Categories.ToList();
        }

        public List<KeyValuePair<string, List<CatalogItemDetails>>> GetCatalogItemDetails(int itemId)
        {
            var catalogItems = CatalogItemsData.GetCatalogItems();

            return catalogItems.Where(i => i.Value.Any(i => i.ItemId == itemId)).ToList();
        }
        public void CreateCateogry(Category category)
        {
            dataContext.Categories.Add(category);
            dataContext.SaveChanges();
        }

        public void UpdateCateogry(Category updateCategory)
        {
            var category = this.dataContext.Categories.Where(i => i.Id == updateCategory.Id).FirstOrDefault();
            if (category != null)
            {
                category.Name = updateCategory.Name;
                category.ImageURL = updateCategory.ImageURL;
            }
            dataContext.SaveChanges();
        }

        public void DeleteCateogry(int categoryId)
        {
            var category = this.dataContext.Categories.Where(i => i.Id == categoryId).FirstOrDefault();
            if (category != null)
            {
                dataContext.Remove(category);
            }
            dataContext.SaveChanges();
        }
    }
}
