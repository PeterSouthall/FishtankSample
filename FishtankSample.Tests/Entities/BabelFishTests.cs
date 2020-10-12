/***************************************************************************\
File Name:  BabelFishTests.cs
Project:      FishTank
Copyright (c) 2020
\***************************************************************************/

namespace FishtankSample.Tests
{
    using System;
    using Xunit;
    using FishtankSample.Entities;

    /// <summary>
    /// Unit tests for the <see cref="BabelFish" /> class.
    /// </summary>
    public class BabelFishTests
    {
        [Fact]
        public void BabelFish_name_is_initialised_correctly()
        {
            // Arrange
            string name = "Babel";

            // Act
            BabelFish fish = new BabelFish(name);

            // Assert
            Assert.Equal(name, fish.Name);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Data_driven_tests_for_invalid_babel_fish_names_throws_exception(string name)
        {
            // Arrange
            string expectedResult = "Error attempting to create a fish without a name, type : BabelFish, parameter : name";

            // Act
            Exception ex = Assert.Throws<ArgumentException>(() => new BabelFish(name));

            // Assert
            Assert.Equal(expectedResult, ex.Message);
        }

        [Fact]
        public void BabelFish_feed_amount_is_correct_value()
        {
            // Arrange
            float expectedResult = 0.3f;
            string name = "Babel";

            // Act
            BabelFish fish = new BabelFish(name);

            // Assert
            Assert.Equal(expectedResult, fish.FeedAmountInGrammes);
        }
    }
}
