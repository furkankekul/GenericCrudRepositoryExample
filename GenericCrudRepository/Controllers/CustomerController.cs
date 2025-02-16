using DataAccessBase.GenericDataAccessRepos;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace GenericCrudRepository.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IRepository<Customer> _customerDataAccessor;
        public CustomerController(IRepository<Customer> dataAccessor)
        {
            _customerDataAccessor = dataAccessor;
        }

        [HttpGet]
        public IActionResult GetAllList()
        {
            var values = _customerDataAccessor.GetAllList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult InserCustomer(Customer customer)
        {
            var status = _customerDataAccessor.Insert(customer);
            if (status)
                return Ok(customer);
            return BadRequest();
        }

    }
}
