namespace WebApplication.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Repository.Entities;
    using Repository.MockRepository;
    using Business.BusinessClass;
    
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        #region Private Region
        /// <summary>
        /// Mock User repository to save entity
        /// </summary>
        static MockUserRepository mock = new MockUserRepository();

        /// <summary>
        /// Class where management businness 
        /// </summary>
        Management<User> man = new Management<User>(mock);
        #endregion

        #region WebAPI Region
        // GET api/values
        [HttpGet]
        public IEnumerable<User> Get()
        {
            IEnumerable<User> LstUsers;
            try
            {
                LstUsers =  man.GetAll();
            }
            catch (Exception)
            {
                LstUsers = null;
            }
            return LstUsers;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            User user;
            try
            {
                user = man.FindById(id);
            }
            catch (Exception)
            {
                user = null;
            }
            return user;
        }

        // POST api/values
        [HttpPost]
        public User Post([FromForm]User value)
        {
            User user;
            try
            {
                user = man.Save(value);
            }
            catch (Exception)
            {
                user = null;
            }
            return user;
        }

        // PUT api/values/5
        [HttpPut]
        public User Put([FromForm]User value)
        {
            User user;
            try
            {
                user = man.Update(value);
            }
            catch (Exception)
            {
                user = null;
            }
            return user;            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {         
            man.Delete(id);
        }
        #endregion       
    }
}
