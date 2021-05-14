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
        /// <para>Initial release was 1.00</para>
        /// <para>Small releases  will increase the Version by 0.01</para>
        /// <para>Feature releases will increase the Version by 0.10</para>
        /// <para>Major release will increase the Version by 1.00</para>
        /// </summary>
        public const string Version = "1.12";
    }
}
