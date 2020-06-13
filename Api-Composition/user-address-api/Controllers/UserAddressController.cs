using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace user_address_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAddressController : ControllerBase
    {
        // GET: api/UserAddress
        [HttpGet]
        public IEnumerable<UserAddress> Get()
        {
            return new UserAddress[] { new UserAddress { UserName = "User1", City = "CityName", Street1 = "StreetOne", State = "StateName", Street2 = "StreetTwp" } };
        }

        // GET: api/UserAddress/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UserAddress
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/UserAddress/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
