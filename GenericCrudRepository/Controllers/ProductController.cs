using DataAccessBase.GenericDataAccessRepos;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace GenericCrudRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IRepository<Product> _productDataAccessor;
        public ProductController(IRepository<Product> dataAccessor)
        {
            _productDataAccessor = dataAccessor;
        }


        public IActionResult InsertProduct(Product product)
        {
            var value = _productDataAccessor.Insert(product);
            if (value)
                return Ok(product);
            return BadRequest();
        }


        public IActionResult GetAllListProduct(Product product)
        {
            var list = _productDataAccessor.GetAllList();
            if (list != null)
                return Ok(list);
            return BadRequest();    

        }

    }
}
