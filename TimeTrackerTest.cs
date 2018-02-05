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
        
        [Theory]
        [InlineData(17,1,0)]
        [InlineData(7,59,0)]
        [InlineData(21,0,0)]
        [InlineData(0,0,0)]
        public void When_Time_Out_Of_Period_0800_1700_Should_Be_False(int hour, int minute, int second)
        {
            TimeSpan setTime = new TimeSpan(hour, minute, second);

            bool actual = timeTracker.CheckValid(setTime);

            Assert.False(actual);
        }
    }
}
