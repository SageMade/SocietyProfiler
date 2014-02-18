using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocietyProfiler.Profiles;

namespace SocietyProfiler.Society
{
    /// <summary>
    /// Represents a society
    /// </summary>
    public class Society
    {
        /// <summary>
        /// The rules for this society
        /// </summary>
        SocietyRules _rules;
        /// <summary>
        /// All of the core ancestors that created the society
        /// </summary>
        List<Profile> _coreAncestors;

        public void AddCoreProfile(Profile p)
        {

        }
    }
}
