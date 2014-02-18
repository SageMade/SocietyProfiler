using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocietyProfiler.Society
{
    /// <summary>
    /// The general guidelines that a society follows
    /// </summary>
    public class SocietyRules
    {
        /// <summary>
        /// How names are taken upon marrige
        /// </summary>
        public MarrigeNaming NamingProtocol;
        /// <summary>
        /// True if the society allows gay marrige
        /// </summary>
        public bool AllowGayMarrige;
        /// <summary>
        /// True if the society limits the number of children per couple
        /// </summary>
        public bool HasMaxChildren;
        /// <summary>
        /// The maximum number of children per couple
        /// </summary>
        public int MaxChildren;
        /// <summary>
        /// True if marriges are arranged by the parents
        /// </summary>
        public bool ArrangedMarrige;
    }
}
