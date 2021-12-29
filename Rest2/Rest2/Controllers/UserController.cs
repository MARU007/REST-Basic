using Microsoft.AspNetCore.Mvc;
using Rest2.Db;
using Rest2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rest2.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserDbContext _dbContext = new UserDbContext();

        // GET: api/User
        [HttpGet]
        public IEnumerable<User> Get()
        {
            List<User> listUser = this._dbContext.Users.ToList();
         
            return listUser;
        }

        // GET api/User/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User user = this._dbContext.Users.FirstOrDefault(x => x.IdUser==id);      
            return user;
            
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            //Address newAddress = new Address();
            //newAddress.City = "Bialystok";
            //newAddress.Country = "Polska";
            //newAddress.PostCode = "16";
            //newAddress.Street = "mala";
            //newAddress.HouseNumber = "22";
            //newAddress.LocalNumber = "1";

            //_dbContext.Address.Add(newAddress);
            //_dbContext.SaveChanges();

            //user.IdNavigation = newAddress.Id;
            //user.IdNavigationVirtual = newAddress;

            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        // PUT api/User/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            User userInDb = this._dbContext.Users.FirstOrDefault(x => x.IdUser == id);
            userInDb.FirstName = user.FirstName;
            userInDb.LastName = user.LastName;
            userInDb.DateOfBirth = user.DateOfBirth;
            userInDb.Gender = user.Gender;
            userInDb.Weight = user.Weight;
            _dbContext.Users.Update(userInDb); 
            _dbContext.SaveChanges();
        }

        // DELETE api/User/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            User user = this._dbContext.Users.FirstOrDefault(x => x.IdUser == id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
            
    }
}
