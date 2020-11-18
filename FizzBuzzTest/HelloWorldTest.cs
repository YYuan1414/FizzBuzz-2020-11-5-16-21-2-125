using Castle.DynamicProxy.Generators;
using FizzBuzz;
using Moq;
using Xunit;

namespace FizzBuzzTest
{
    public class HelloWorldTest
    {
        [Fact]
        public void Get_1_Return_1_Test()
        {
            //Given
            var dependency = new Dependency();
            string actual = string.Empty;
            //When
            actual = dependency.Say(1);
            //Then
            Assert.Equal("1", actual);
        }
    }
}