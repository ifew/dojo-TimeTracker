using System;
using Xunit;

namespace TimeTracker
{
    public class TimeTrackerTest
    {
        TimeTracker timeTracker = new TimeTracker();

        [Fact]
        public void When_Time_Is_0800_Should_Be_True()
        {
            TimeSpan setTime = new TimeSpan(8,0,0);

            bool actual = timeTracker.CheckValid(setTime);

            Assert.True(actual);
        }
        
        [Fact]
        public void When_Time_Is_0801_Should_Be_True()
        {
            TimeSpan setTime = new TimeSpan(8,1,0);

            bool actual = timeTracker.CheckValid(setTime);

            Assert.True(actual);
        }
        
        [Fact]
        public void When_Time_Is_1659_Should_Be_True()
        {
            TimeSpan setTime = new TimeSpan(16,59,0);

            bool actual = timeTracker.CheckValid(setTime);

            Assert.True(actual);
        }
        
        [Fact]
        public void When_Time_Is_1701_Should_Be_False()
        {
            TimeSpan setTime = new TimeSpan(17,01,0);

            bool actual = timeTracker.CheckValid(setTime);

            Assert.False(actual);
        }

        [Fact]
        public void When_Time_Is_0759_Should_Be_False()
        {
            TimeSpan setTime = new TimeSpan(07,59,0);

            bool actual = timeTracker.CheckValid(setTime);

            Assert.False(actual);
        }

        [Fact]
        public void When_Time_Is_2100_Should_Be_False()
        {
            TimeSpan setTime = new TimeSpan(21,0,0);

            bool actual = timeTracker.CheckValid(setTime);

            Assert.False(actual);
        }
    }
}
