using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName(){
            var returnValue = controller.Get(1);
            Assert.Equal("ISB", returnValue.Value);
        }

        [Fact]
        public void testAddition(){
            var num = 1;
            Assert.Equal(1, num);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
