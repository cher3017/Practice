namespace Repository.Interfaces
{
    using System.Collections.Generic;
    using Entities;

    /// <summary>
    /// Repository Interface
    /// </summary>
    /// <typeparam name="T">Class to use for management repository</typeparam>
    public interface IRepository<T> 
        where T : class 
    {
        #region Methods Region
        /// <summary>
        /// Find all Entities 
        /// </summary>
        /// <returns>List to Entities</returns>
        IList<T> FindAll();

        /// <summary>
        /// Find an Entity by Param
        /// </summary>
        /// <param name="Id">Parameter to Indetify an Entitiy</param>
        /// <returns>Entity finded</returns>
        T FindById(int Id);

        /// <summary>
        /// Save an Entity
        /// </summary>
        /// <param name="target">Entity to Save</param>
        /// <returns>Entity saved</returns>
        bool Save(T target);

        /// <summary>
        /// Delete an Entity
        /// </summary>
        /// <param name="Id">Parameter to Indetify an Entitiy</param>
        /// <returns>Entity deleted</returns>
        bool Delete(int Id);

        #endregion        
    }
}
