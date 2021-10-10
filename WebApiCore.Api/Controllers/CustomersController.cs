using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApiCore.Data.Context;
using WebApiCore.Data.Models;
using WebApiCore.Data.Repository;

namespace WebApiCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IRepository<Customer> contextCustomers;

        public CustomersController(IRepository<Customer> contextCustomers)
        {
            this.contextCustomers = contextCustomers;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return contextCustomers.All;
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(Guid id)
        {
            return contextCustomers.FindById(id);
        }


        [HttpPost]
        public void Post([FromBody] Customer value)
        {
            contextCustomers.Add(value);
        }

        [HttpPut]
        public void Put([FromQuery] Customer value)
        {
            contextCustomers.Update(value);
        }

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            var item = contextCustomers.FindById(id);
            contextCustomers.Delete(item);
        }
    }
}