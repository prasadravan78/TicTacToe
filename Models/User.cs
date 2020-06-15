using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class User : Base
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public DateTime EmailConfirmationDate { get; set; }

        public int Score { get; set; }
    }
}
