namespace Business.Interfaces
{
    using System.Collections.Generic;
    using Repository.Entities;

    /// <summary>
    /// Interface to Management 
    /// </summary>
    /// <typeparam name="T">Class to use for management</typeparam>
    public interface IManagement<T>
        where T : class
    {
        #region Methods Region
        /// <summary>
        /// Get all Entities 
        /// </summary>
        /// <returns>List to Entities</returns>
        IList<T> GetAll();

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
        T Save(T target);

        /// <summary>
        /// Update an Entity
        /// </summary>
        /// <param name="target">Entity to Update</param>
        /// <returns>Entity updated</returns>
        T Update(T target);

        /// <summary>
        /// Delete an Entity
        /// </summary>
        /// <param name="Id">Parameter to Indetify an Entitiy</param>
        /// <returns>Entity deleted</returns>
        bool Delete(int Id);

        #endregion
    }
}
