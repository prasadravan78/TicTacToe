using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    ///  Provides members to manage User entity.
    /// </summary>
    public class User : Base
    {
        /// <summary>
        /// Gets or Sets the Id.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets the FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets the LastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets the Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets the Password.
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets the IsEmailConfirmed.
        /// </summary>
        public bool IsEmailConfirmed { get; set; }

        /// <summary>
        /// Gets or Sets the EmailConfirmationDate.
        /// </summary>
        public DateTime EmailConfirmationDate { get; set; }

        /// <summary>
        /// Gets or Sets the Score.
        /// </summary>
        public int Score { get; set; }
    }
}
