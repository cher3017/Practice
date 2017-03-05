namespace Repository.MockRepository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entities;
    using Interfaces;    
    using Moq;

    /// <summary>
    /// Mock Class
    /// </summary>    
    public class MockUserRepository: IMockRepository<User>
    {
        #region Property Region
        /// <summary>
        /// Our Mock User Repository
        /// </summary>     
        public IRepository<User> MockRepository { get; set; }
        #endregion

        #region Constructor Region
        /// <summary>
        /// Constructor class
        /// </summary>
        public MockUserRepository()
        {
            // create some mock Users to play with
            IList<User> users = new List<User>();

            // Mock the Users Repository using Moq
            Mock<IRepository<User>> mockUserRepository = new Mock<IRepository<User>>();

            // Return all the Users
            mockUserRepository.Setup(mr => mr.FindAll()).Returns(users);

            // return a User by Id
            mockUserRepository.Setup(mr => mr.FindById(It.IsAny<int>())).Returns((int i) => users.Where(x => x.Id == i).Single());

            // Allows us to test saving a User
            mockUserRepository.Setup(mr => mr.Save(It.IsAny<User>())).Returns(
            (User target) =>
            {
                DateTime now = DateTime.Now;

                if (target.Id == 0)
                {
                    target.Id = users.DefaultIfEmpty().Max(c => c == null ? 0 : c.Id) + 1;
                    users.Add(target);
                }
                else
                {
                    var original = users.Where(q => q.Id == target.Id).SingleOrDefault();

                    if (original == null)
                    {
                        return false;
                    }

                    original.Name = target.Name;
                    original.Birthdate = target.Birthdate;
                }

                return true;
            });

            // Allows us to test saving a User
            mockUserRepository.Setup(mr => mr.Delete(It.IsAny<int>())).Returns(
            (int id) =>
            {
                var original = users.Where(q => q.Id == id).SingleOrDefault();
                if(original != null)
                {
                    users.Remove(original);
                }                    
                return true;
            });

            // Complete the setup of our Mock User Repository
            this.MockRepository = mockUserRepository.Object;
        }

        #endregion       
    }
}
