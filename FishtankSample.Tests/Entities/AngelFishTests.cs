/***************************************************************************\
File Name:  AngelFishTests.cs
Project:      FishTank
Copyright (c) 2020
\***************************************************************************/

namespace FishtankSample.Tests
{
    using System;
    using Xunit;
    using FishtankSample.Entities;

    /// <summary>
    /// Unit tests for the <see cref="AngelFish" /> class.
    /// </summary>
    public class AngelFishTests
    {
        [Fact]
        public void AngelFish_name_is_initialised_correctly()
        {
            // Arrange
            string name = "Angel";

            // Act
            AngelFish fish = new AngelFish(name);

            // Assert
            Assert.Equal(name, fish.Name);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Data_driven_tests_for_invalid_angel_fish_names_throws_exception(string name)
        {
            // Arrange
            string expectedResult = "Error attempting to create a fish without a name, type : AngelFish, parameter : name";

            // Act
            Exception ex = Assert.Throws<ArgumentException>(() => new AngelFish(name));

            // Assert
            Assert.Equal(expectedResult, ex.Message);
        }

        [Fact]
        public void AngelFish_feed_amount_is_correct_value()
        {
            // Arrange
            float expectedResult = 0.2f;
            string name = "Angel";

            // Act
            AngelFish fish = new AngelFish(name);

            // Assert
            Assert.Equal(expectedResult, fish.FeedAmountInGrammes);
        }
    }
}
