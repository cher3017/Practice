namespace Repository.Repository
{
    using System;
    using System.Collections.Generic;    
    using Interfaces;

    /// <summary>
    /// Repository Class
    /// </summary>
    /// <typeparam name="T">Class to use for management repository</typeparam>
    public class Repository<T> : IRepository<T> 
        where T : class
    {
        #region PublicMethods
        /// <summary>
        /// Find all Entities 
        /// </summary>
        /// <returns>List to Entities</returns>
        public IList<T> FindAll()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Find an Entity by Param
        /// </summary>
        /// <param name="Id">Parameter to Indetify an Entitiy</param>
        /// <returns>Entity finded</returns>
        public T FindById(int Id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Save an Entity
        /// </summary>
        /// <param name="target">Entity to Save</param>
        /// <returns>Entity saved</returns>
        public bool Save(T target)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Delete an Entity
        /// </summary>
        /// <param name="Id">Parameter to Indetify an Entitiy</param>
        /// <returns>Entity deleted</returns>
        public bool Delete(int Id)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
