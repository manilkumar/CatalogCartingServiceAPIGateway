using CatalogCartingServiceAPIGateway.Models.DbModels;
using CatalogCartingServiceAPIGateway.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CatalogCartingServiceAPIGateway.Controllers
{
    [ApiController]
    [Route("cartingservice")]
    public class CartingController : Controller
    {
        private readonly ILogger logger;
        private readonly CategoryService categoryService;

        public CartingController(ILogger logger, CategoryService categoryService)
        {
            this.categoryService = categoryService;
            this.logger = logger;
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult<List<Category>> Get()
        {
            try
            {
                var categories = this.categoryService.GetAll();
                return Ok(categories);
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Create([FromBody] Category category)
        {
            try
            {
                this.categoryService.CreateCateogry(category);
                return Ok();
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPut]
        public ActionResult Update([FromBody] Category category)
        {
            try
            {
                this.categoryService.UpdateCateogry(category);
                return Ok();
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete]
        public ActionResult Delete(int categoryId)
        {
            try
            {
                this.categoryService.DeleteCateogry(categoryId);
                return Ok();
            }
            catch (Exception error)
            {
                logger.LogError(error.Message);
                return StatusCode(500);
            }
        }
    }
}
