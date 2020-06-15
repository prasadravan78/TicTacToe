using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Base
    {
        [ScaffoldColumn(false)]
        public bool IsActive { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreationDate { get; set; }

        [ScaffoldColumn(false)]
        public DateTime ModificationDate { get; set; }

        [ScaffoldColumn(false)]
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
