using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackerLib
{
    /// <summary>
    /// Holds information about the application, such as version number.
    /// </summary>
    public class ApplicationInfo
    {

        /// <summary>
        /// Semantic Versioning is used. See <see href="https://semver.org/spec/v2.0.0.html">SemVer 2.0.0</see> 
        /// <para>Patch releases  will increase the Version by 0.0.1</para>
        /// <para>Feature releases will increase the Version by 0.1.0</para>
        /// <para>Major release will increase the Version by 1.0.0</para>
        /// </summary>
        public const string Version = "0.1.0";
    }
}
