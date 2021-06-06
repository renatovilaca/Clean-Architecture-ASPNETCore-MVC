using CleanArchMvc.Domain.Entities;
using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchMvc.Infra.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        ApplicationDbContext _categoryContext;
        public CategoryRepository(ApplicationDbContext context)
        {
            //Inject context instance
            _categoryContext = context;
        }

        public async Task<Category> Create(Category category)
        {
            //Add into context in memory
            _categoryContext.Add(category);
            //Action in database
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> GetById(int? id)
        {
            return await _categoryContext.Categories.FindAsync(id);
        }

        public async Task<IEnumerable<Category>> GetCategories()
        {
            return await _categoryContext.Categories.ToListAsync();
        }

        public async Task<Category> Remove(Category category)
        {
            _categoryContext.Remove(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }

        public async Task<Category> Update(Category category)
        {
            _categoryContext.Update(category);
            await _categoryContext.SaveChangesAsync();
            return category;
        }
    }
}
