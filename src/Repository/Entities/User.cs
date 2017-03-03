namespace Repository.Entities
{
    using System;
    using Interfaces;

    /// <summary>
    /// User Entity
    /// </summary>
    public class User : IUser
    {
        #region Property Region
        /// <summary>
        /// Id property to User identify 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name property to User identity
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Birthdate property to User identity
        /// </summary>
        public DateTime Birthdate { get; set; }
        #endregion
    }
}
