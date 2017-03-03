namespace Repository.Interfaces
{
    /// <summary>
    /// Mock Interface
    /// </summary>
    /// <typeparam name="T">Class to use for management Mock</typeparam>
    public interface IMockRepository<T> 
        where T : class
    {
        #region Property Region
        /// <summary>
        /// Mock repossitory to save Entities
        /// </summary>
        IRepository<T> MockRepository { get; set; }
        #endregion
    }
}
