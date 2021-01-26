using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodTrackerLib.Models;

namespace MoodTrackerTests
{
    [TestClass]
    public class DayModelTests
    {
        private Day _day;

        [TestInitialize]
        public void Init()
        {
            _day = new Day(new DateTimeOffset(DateTime.Today.AddDays(-1)), 5);
        }

        [TestMethod]
        public void ConstructorTest()
        {
            Day day = new Day(new DateTimeOffset(DateTime.Today), 5);
            Assert.AreEqual(5, day.Points);
            Assert.AreEqual(DateTime.Today, day.Date);

            Day d2 = new Day(10);
            Assert.AreEqual(10, d2.Points);

            Day d3 = new Day();
            Assert.AreEqual(default, d3.Date);
            Assert.AreEqual(0, d3.Points);
        }
        [TestMethod]
        public void PointsTest()
        {
            Assert.AreEqual(5, _day.Points);

            _day.Points = 1;
            Assert.AreEqual(1, _day.Points);

            _day.Points = 10;
            Assert.AreEqual(10, _day.Points);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _day.Points = 0.9);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _day.Points = 10.1);
        }
    }
}
