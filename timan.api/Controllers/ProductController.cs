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

    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            try
            {
                return Ok(await productRepository.GetProductLists());

            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Không tải được dữ liệu");
            }

        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductList>> GetProduct(int id)
        {
            try
            {
                var result = await productRepository.GetProduct(id);
                if(result == null)
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
        [HttpPost]
        public async Task<ActionResult<ProductList>> createProduct(ProductList product)
        {
            try
            {
                if(product == null)
                {
                    return BadRequest();
                }
                var namepd = productRepository.GetProductbyName(product.ProductName);
                if(namepd.Result != null)
                {
                    ModelState.AddModelError("name", "Sản phẩm đã tồn tại");
                    return BadRequest(ModelState);
                }
               var createdProduct = await productRepository.AddProduct(product);
                return CreatedAtAction(nameof(GetProduct), new { id = createdProduct.ProductID }, createdProduct);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Không tạo mới được dữ liệu");
            }
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult<ProductList>> updateProduct(int id, ProductList productList)
        {
            try
            {
                if(id != productList.ProductID)
                {
                    return BadRequest("Không trùng ID");
                }
                var updatetheproduct = await productRepository.GetProduct(id);
                if (updatetheproduct == null)
                {
                    return NotFound($"Sản phẩm với ID ={id} không tồn tại");
                }
                return await productRepository.UpdateProduct(productList);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                   "Không cập nhật  được dữ liệu");
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ProductList>> DeleteProduct(int id)
        {
            try
            {
                var deleteproduct = await productRepository.GetProduct(id);
                if(deleteproduct == null)
                {
                    return NotFound($"Không có sản phẩm với ID = {id}");
                }
                return await productRepository.DeleteProduct(id);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                     "Không xóa  được dữ liệu");
            }
        }
        [HttpGet("{search}")]
        public async Task<ActionResult<IEnumerable<ProductList>>> Search(string nameProduct)
        {
            try
            {
                var result = await productRepository.SearchProduct(nameProduct);
                if (result.Any())
                {
                    return Ok(result);
                }
                return NotFound();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                 "Không tìm thấy dữ liệu");
            }
        }
    }
}
