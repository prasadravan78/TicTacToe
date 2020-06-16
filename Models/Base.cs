using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe
{
    /// <summary>
    /// Provides Common Tracking Information and Concurrency.
    /// </summary>
    public class Base
    {
        /// <summary>
        /// Gets or Sets the Is Active.
        /// </summary>
        [ScaffoldColumn(false)]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or Sets the CreationDate.
        /// </summary>
        [ScaffoldColumn(false)]
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Gets or Sets the ModificationDate.
        /// </summary>
        [ScaffoldColumn(false)]
        public DateTime ModificationDate { get; set; }

        /// <summary>
        /// Gets or Sets the RowVersion.
        /// </summary>
        [ScaffoldColumn(false)]
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
