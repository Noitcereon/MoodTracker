using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackerLib.Interfaces
{
    public interface IDay
    {
        DateTimeOffset Date { get; }

        double Points { get; set; }
    }
}
