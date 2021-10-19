using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using timan.api.Models;
using timan.models;

namespace timan.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryRepository categoryRepository;
        public CategoryController(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            try
            {
                return Ok(await categoryRepository.categories());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Không tải được dữ liệu Category");
            }

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Category>> GetProduct(int id)
        {
            try
            {
                var result = await categoryRepository.GetCategory(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {


                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Không tải được dữ liệu");
            }
        }
    }
}
