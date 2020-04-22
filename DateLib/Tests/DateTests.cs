using System;
using DateLib;

using Xunit;

namespace Tests
{
    public class DateTests
    {
        private DateTime dateRef = new DateTime(2000, 1, 1, 0, 0, 0);

        [Fact]
        public void intervalBetweenDateTime_should_return_1_second()
        {
            var expected = new TimeSpan(0, 0, 1);
            var res = DateUtils.intervalBetweenDateTime(dateRef, dateRef.AddSeconds(1));
            Assert.Equal(res, expected);
        }

        [Fact]
        public void intervalBetweenDateTime_should_throw_exception_with_start_date_later_than_end_date()
        {
            var expected = new TimeSpan(0, 0, 1);
            ArgumentException exception = Assert.Throws<ArgumentException>(() => DateUtils.intervalBetweenDateTime(dateRef.AddSeconds(1), dateRef));
            Assert.Equal("Start Date should be inferior", exception.Message);
        }

        [Fact]
        public void formatWord_should_return_one_day(){
            var timeSpan = new TimeSpan(24, 0, 0);
            var res = DateUtils.formatWords(timeSpan);
            Assert.Equal(res, "1 Days");
        }

        [Fact]
        public void formatWord_should_return_one_hours(){
            var timeSpan = new TimeSpan(1, 0, 0);
            var res = DateUtils.formatWords(timeSpan);
            Assert.Equal(res, "1 Hours");
        }

        [Fact]
        public void formatWord_should_return_one_second(){
            var timeSpan = new TimeSpan(0, 0, 1);
            var res = DateUtils.formatWords(timeSpan);
            Assert.Equal(res, "1 Secondes");
        }

    }
}
