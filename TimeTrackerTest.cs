using System;
using Xunit;

namespace TimeTracker
{
    public class TimeTrackerTest
    {
        [Fact]
        public void When_Time_Is_0800_Should_Be_True()
        {
            TimeSpan setTime = new TimeSpan(8,0,0);

            TimeTracker timeTracker = new TimeTracker();
            bool actual = timeTracker.CheckValid(setTime);

            Assert.True(actual);
        }
    }
}
