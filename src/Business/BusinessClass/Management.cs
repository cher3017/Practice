namespace Business.BusinessClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces;
    using Repository.Interfaces;

    /// <summary>
    /// Class to Management 
    /// </summary>
    /// <typeparam name="T">Class to use for management</typeparam>
    public class Management<T> : IManagement<T> 
            where T : class
    {
        #region Internal Region
        IMockRepository<T> mock;
        #endregion

        #region Constructor Region
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="moskRepository">Mock where save and find to Entity</param>
        public Management(IMockRepository<T> moskRepository)
        {
            this.mock = moskRepository; 
        }
        #endregion

        #region PublicMethods Region

        /// <summary>
        /// Delete an Entity
        /// </summary>
        /// <param name="Id">Parameter to Indetify an Entitiy</param>
        /// <returns>Entity deleted</returns>
        public bool Delete(int Id)
        {
            bool result = false;
            try
            {
                result = mock.MockRepository.Delete(Id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return result;
        }

        /// <summary>
        /// Find an Entity by Param
        /// </summary>
        /// <param name="Id">Parameter to Indetify an Entitiy</param>
        /// <returns>Entity finded</returns>
        public T FindById(int Id)
        {
            T user = null;
            try
            {
                user = mock.MockRepository.FindById(Id);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return user;
        }

        /// <summary>
        /// Get all Entities 
        /// </summary>
        /// <returns>List to Entities</returns>
        public IList<T> GetAll()
        {
            IList<T> lstUser = null;
            try
            {
                lstUser = mock.MockRepository.FindAll();
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return lstUser;
        }

        /// <summary>
        /// Save an Entity
        /// </summary>
        /// <param name="target">Entity to Save</param>
        /// <returns>Entity saved</returns>
        public T Save(T target)
        {
            T user = null;
            try
            {
                if (mock.MockRepository.Save(target))
                {
                    user = mock.MockRepository.FindAll().LastOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return user;
        }

        /// <summary>
        /// Update an Entity
        /// </summary>
        /// <param name="target">Entity to Update</param>
        /// <returns>Entity updated</returns>
        public T Update(T target)
        {
            T user = null;
            try
            {
                if (mock.MockRepository.Save(target))
                {
                    user = target;
                }
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            return user;
        }
        #endregion

    }
}
