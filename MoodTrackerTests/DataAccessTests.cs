using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodTrackerLib.Implementation;
using MoodTrackerLib.Interfaces;
using MoodTrackerLib.Models;

namespace MoodTrackerTests
{
    [TestClass]
    public class DataAccessTests
    {
        private readonly DataAccess _dataAccess = new DataAccess();
        [TestMethod]
        public void GetDaysTest()
        {
            Assert.AreEqual(typeof(List<IDay>),_dataAccess.GetDays().GetType());
            
        }

        public void AddDaysTest()
        {
            int before = _dataAccess.GetDays().Count;
            _dataAccess.AddDay(new Day(80));
            int after = _dataAccess.GetDays().Count;
            Assert.AreEqual(before, after+1);
            _dataAccess.RemoveLastDayEntry();
        }
    }
}
