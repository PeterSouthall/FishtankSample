/***************************************************************************\
File Name:  GoldFishTests.cs
Project:      FishTank
Copyright (c) 2020
\***************************************************************************/

namespace FishtankSample.Tests
{
    using System;
    using Xunit;
    using FishtankSample.Entities;

    /// <summary>
    /// Unit tests for the <see cref="GoldFish" /> class.
    /// </summary>
    public class GoldFishTests
    {
        [Fact]
        public void GoldFish_name_is_initialised_correctly()
        {
            // Arrange
            string name = "Gold";

            // Act
            GoldFish fish = new GoldFish(name);

            // Assert
            Assert.Equal(name, fish.Name);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void Data_driven_tests_for_invalid_gold_fish_names_throws_exception(string name)
        {
            // Arrange
            string expectedResult = "Error attempting to create a fish without a name, type : GoldFish, parameter : name";

            // Act
            Exception ex = Assert.Throws<ArgumentException>(() => new GoldFish(name));

            // Assert
            Assert.Equal(expectedResult, ex.Message);
        }

        [Fact]
        public void GoldFish_feed_amount_is_correct_value()
        {
            // Arrange
            float expectedResult = 0.1f;
            string name = "Gold";

            // Act
            GoldFish fish = new GoldFish(name);

            // Assert
            Assert.Equal(expectedResult, fish.FeedAmountInGrammes);
        }
    }
}
