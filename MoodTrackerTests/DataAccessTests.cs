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
            Assert.AreEqual(typeof(List<IDay>), _dataAccess.GetDays().GetType());
        }

        [TestMethod]
        public void AddDaysTest()
        {
            int before = _dataAccess.GetDays().Count;

            _dataAccess.AddDay(new Day(8));
            int after = _dataAccess.GetDays().Count;

            Assert.AreEqual(before + 1, after);

            _dataAccess.RemoveLastDayEntry();
        }

        [TestMethod]
        public void RemoveLastDayEntry()
        {
            _dataAccess.AddDay(new Day(5));
            int before = _dataAccess.GetDays().Count;
            _dataAccess.RemoveLastDayEntry();
            Assert.AreEqual(before - 1, _dataAccess.GetDays().Count);
        }

        [TestMethod]
        public void RemoveOldEntryIfSameDayTest()
        {
            // TODO: RemoveOldEntryIfSameDay Test
            // 1. If Days contains an entry for today it should return true
            // 2. if Not, it should return true.
            // 3. If Days conatain an entry for today and it fails to remove it, it should return false.

            //_dataAccess.GetDays().Find(x => PIHelpers.IsToday(x.Date));
            //Assert.AreEqual(true, _dataAccess.RemoveOldEntryIfTheSameDay());
        }
    }
}
