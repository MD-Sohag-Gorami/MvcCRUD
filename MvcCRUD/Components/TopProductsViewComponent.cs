using Microsoft.AspNetCore.Mvc;
using MvcCRUD.Controllers;
using MvcCRUD.Data;
using MvcCRUD.Models;

namespace MvcCRUD.Components
{
    public class TopProductsViewComponent: ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public TopProductsViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var list = _db.Categories.Select(category => new Category()
            {
                Id = category.Id,
                Name = category.Name,
                displayOrder = category.displayOrder,
                CreatedDate = category.CreatedDate
            }).Take(3).ToList();
            return View(list);
        }
        
    }
}
