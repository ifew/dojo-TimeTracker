using System;
using Xunit;

namespace TimeTracker
{
    public class TimeTrackerTest
    {
        TimeTracker timeTracker = new TimeTracker();

        [Theory]
        [InlineData(8,0,0)]
        [InlineData(8,1,0)]
        [InlineData(16,59,0)]
        [InlineData(17,0,0)]
        public void When_Time_In_Period_0800_1700_Should_Be_True(int hour, int minute, int second)
        {
            TimeSpan setTime = new TimeSpan(hour, minute, second);

            bool actual = timeTracker.CheckValid(setTime);

            Assert.True(actual);
        }
        
        [Fact]
        public void When_Time_Is_1701_Should_Be_False()
        {
            TimeSpan setTime = new TimeSpan(17,1,0);

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

        [Fact]
        public void When_Time_Is_0000_Should_Be_False()
        {
            TimeSpan setTime = new TimeSpan(0,0,0);

            bool actual = timeTracker.CheckValid(setTime);

            Assert.False(actual);
        }
    }
}
