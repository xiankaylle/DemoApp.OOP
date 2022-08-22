using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Polymorphism
{
    /// <summary>
    /// Base Entity
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Property Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Property Created Date
        /// </summary>
        public DateTime CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string UpdatedBy { get; set; }
    }
}
