namespace Repository.Interfaces
{
    using System;

    /// <summary>
    /// User interface
    /// </summary>
    public interface IUser
    {
        #region Property Region 
        /// <summary>
        /// Id property to User identify 
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Name property to User identity
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Birthdate property to User identity
        /// </summary>
        DateTime Birthdate { get; set; }

        #endregion        
    }
}
