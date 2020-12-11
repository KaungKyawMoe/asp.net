using Microsoft.AspNetCore.Mvc;
using Nop.Services.Catalog;
using Nop.Web.Factories;
using Nop.Web.Framework.Components;

namespace Nop.Web.Components
{
    public class ManufactureFilterViewComponent : NopViewComponent
    {
        private readonly ICatalogModelFactory _catalogModelFactory;
        private readonly ICategoryService _categoryService;
        public ManufactureFilterViewComponent(ICatalogModelFactory catalogModelFactory, ICategoryService categoryService)
        {
            _catalogModelFactory = catalogModelFactory;
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke(int currentCategoryId)
        {
            var category = _categoryService.GetCategoryById(currentCategoryId);
            var model = _catalogModelFactory.PrepareCategoryModelByCategory(category);
            return View(model);
        }
    }
}
