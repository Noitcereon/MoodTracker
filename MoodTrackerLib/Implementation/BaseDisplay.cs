using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoodTrackerLib.Interfaces;

namespace MoodTrackerLib.Implementation
{
    public abstract class BaseDisplay : IDisplay
    {
        public virtual void StartUp()
        {
            throw new NotImplementedException();
        }

        public virtual void ChangeView(string viewName)
        {
            throw new NotImplementedException();
        }

        public virtual void Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}
