﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HostingCalculator.Repos.Repositories;
using Entity = HostingCalculator.Domain.Entities;

namespace HostingCalculator.API.Controllers
{    
    public class CustomerController : ApiController
    {
        private CustomerRepository customerRepository = new CustomerRepository();
       
        [HttpGet]   
        [Route("api/customer/")]
        public IEnumerable<Entity.Customer> GetAll()
        {
            var customers = customerRepository.GetAllCustomers();
            return customers;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        [Route("api/customer/")]
        public HttpResponseMessage Post()
        {
            try
            {
                customerRepository.AddCustomer();

                return new HttpResponseMessage(HttpStatusCode.OK);
            }
            catch
            {

                return new HttpResponseMessage(HttpStatusCode.BadRequest);
            }
            
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}