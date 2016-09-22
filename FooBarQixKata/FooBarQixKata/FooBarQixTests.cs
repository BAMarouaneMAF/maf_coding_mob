using System;
using Xunit;

namespace FooBarQixKata
{
    public class FooBarQixTests
    {
        [Fact]
        public void Should_Foo_When_3()
        {
            //Arrange
            var fooBarQix = new FooBarQix();
            
            //Act
            var actual = fooBarQix.Convert(3);

            //Assert
            Assert.Equal("Foo", actual);
        }

        [Fact]
        public void Should_Bar_When_5()
        {
            //Arrange
            var fooBarQix = new FooBarQix();

            //Act
            var actual = fooBarQix.Convert(5);

            //Assert
            Assert.Equal("Bar", actual);
        }

        [Fact]
        public void Should_Foo_When_9()
        {
            //Arrange
            var fooBarQix = new FooBarQix();

            //Act
            var actual = fooBarQix.Convert(9);

            //Assert
            Assert.Equal("Foo", actual);
        }

        [Fact]
        public void Should_Bar_When_10()
        {
            //Arrange
            var fooBarQix = new FooBarQix();

            //Act
            var actual = fooBarQix.Convert(10);

            //Assert
            Assert.Equal("Bar", actual);
        }

        [Fact]
        public void Should_Raise_Exception_When_7()
        {
            //Arrange
            var fooBarQix = new FooBarQix();
            
            //Assert
            Assert.Throws<ArgumentException>(() => fooBarQix.Convert(7));
        }

        [Fact]
        public void Should_Foo_Bar_When_15()
        {
            //Arrange
            var fooBarQix = new FooBarQix();

            //Act
            var actual = fooBarQix.Convert(15);

            //Assert
            Assert.Equal("Foo,Bar", actual);
        }

        [Fact]
        public void Should_Foo_Bar_When_30()
        {
            //Arrange
            var fooBarQix = new FooBarQix();

            //Act
            var actual = fooBarQix.Convert(30);

            //Assert
            Assert.Equal("Foo,Bar", actual);
        }
    }
}
