/***************************************************************************\
File Name:  TankTests.cs
Project:      FishTank
Copyright (c) 2020
\***************************************************************************/

namespace FishtankSample.Tests
{
    using System;
    using Xunit;
    using FishtankSample.Entities;

    /// <summary>
    /// Unit tests for the <see cref="Tank" /> class.
    /// </summary>
    public class TankTests
    {
        #region Unit Tests - Initialisation

        [Fact]
        public void Tank_is_initilaised_containing_0_fish()
        {
            // Arrange / Act
            Tank tank = new Tank();

            // Assert
            Assert.Equal(0, tank.FishCount);
        }

        #endregion

        #region Unit Tests - method AddFish

        [Fact]
        public void A_single_angelfish_can_be_added_to_the_fish_tank()
        {
            // Arrange
            Tank tank = new Tank();
            AngelFish fish = new AngelFish("Abigail");

            // Act
            tank.AddFish(fish);

            // Assert
            Assert.Equal(1, tank.FishCount);
        }

        [Fact]
        public void A_single_babelfish_can_be_added_to_the_fish_tank()
        {
            // Arrange
            Tank tank = new Tank();
            BabelFish fish = new BabelFish("Bob");

            // Act
            tank.AddFish(fish);

            // Assert
            Assert.Equal(1, tank.FishCount);
        }

        [Fact]
        public void A_single_goldfish_can_be_added_to_the_fish_tank()
        {
            // Arrange
            Tank tank = new Tank();
            GoldFish fish = new GoldFish("Geoff");

            // Act
            tank.AddFish(fish);

            // Assert
            Assert.Equal(1, tank.FishCount);
        }

        [Fact]
        public void Multiple_angelfish_can_be_added_to_the_fish_tank()
        {
            // Arrange
            Tank tank = new Tank();
            AngelFish fish1 = new AngelFish("Abigail 1");
            AngelFish fish2 = new AngelFish("Abigail 2");

            // Act
            tank.AddFish(fish1);
            tank.AddFish(fish2);

            // Assert
            Assert.Equal(2, tank.FishCount);
        }

        [Fact]
        public void Multiple_babelfish_can_be_added_to_the_fish_tank()
        {
            // Arrange
            Tank tank = new Tank();
            BabelFish fish1 = new BabelFish("Bob 1");
            BabelFish fish2 = new BabelFish("Bob 2");

            // Act
            tank.AddFish(fish1);
            tank.AddFish(fish2);

            // Assert
            Assert.Equal(2, tank.FishCount);
        }

        [Fact]
        public void Multiple_goldfish_can_be_added_to_the_fish_tank()
        {
            // Arrange
            Tank tank = new Tank();
            GoldFish fish1 = new GoldFish("Geoff 1");
            GoldFish fish2 = new GoldFish("Geoff 2");

            // Act
            tank.AddFish(fish1);
            tank.AddFish(fish2);

            // Assert
            Assert.Equal(2, tank.FishCount);
        }

        [Fact]
        public void All_fish_types_can_be_added_to_the_fish_tank()
        {
            // Arrange
            int expectedResult = 3;
            Tank tank = new Tank();
            AngelFish fish1 = new AngelFish("Abigail");
            BabelFish fish2 = new BabelFish("Bob");
            GoldFish fish3 = new GoldFish("Geoff");

            // Act
            tank.AddFish(fish1);
            tank.AddFish(fish2);
            tank.AddFish(fish3);

            // Assert
            Assert.Equal(expectedResult, tank.FishCount);
        }

        [Fact]
        public void Adding_null_fish_to_tank_throws_exception()
        {
            // Arrange
            string expectedResult = "Error attempting to add a null fish to the tank, type : Tank, parameter : fish";
            Tank tank = new Tank();

            // Act
            Exception ex = Assert.Throws<ArgumentException>(() => tank.AddFish(null));

            // Assert
            Assert.Equal(expectedResult, ex.Message);
        }

        #endregion

        #region Unit Tests - method Feed

        [Fact]
        public void Feeding_all_fish_types_returns_correct_food_weight_value()
        {
            // Arrange
            float expectedResult = 0.6f;
            Tank tank = new Tank();
            tank.AddFish(new AngelFish("Abigail"));
            tank.AddFish(new BabelFish("Bob"));
            tank.AddFish(new GoldFish("Geoff"));

            // Act
            float result = tank.Feed();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        [Theory()]
        [InlineData(0, 0, 0, 0.0f)]
        [InlineData(1, 0, 0, 0.2f)]
        [InlineData(0, 1, 0, 0.3f)]
        [InlineData(0, 0, 1, 0.1f)]
        [InlineData(2, 0, 0, 0.4f)]
        [InlineData(0, 2, 0, 0.6f)]
        [InlineData(0, 0, 2, 0.2f)]
        [InlineData(10, 0, 0, 2.0f)]
        [InlineData(0, 10, 0, 3.0f)]
        [InlineData(0, 0, 10, 1.0f)]
        [InlineData(1, 1, 1, 0.6f)]
        [InlineData(100, 100, 100, 60f)]
        public void Data_driven_test_for_feeding_varying_quantity_of_all_fish_types_returns_correct_food_weight_value(int angelFishCount, int babelFishCount, int goldFishCount, float expectedResult)
        {
            // Arrange
            Tank tank = InitialiseTank(angelFishCount, babelFishCount, goldFishCount);

            // Act
            float result = tank.Feed();

            // Assert
            Assert.Equal(expectedResult, result);
        }

        #endregion

        #region Private Utility Methods

        /// <summary>
        /// Adds fish to the fish tank based on the specified fish quantities.
        /// </summary>
        /// <param name="angelFishCount">The number of angel fish to add to the tank.</param>
        /// <param name="babelFishCount">The number of babel fish to add to the tank.</param>
        /// <param name="goldFishCount">The number of gold fish to add to the tank.</param>
        /// <returns>The fish tank.</returns>
        private Tank InitialiseTank(int angelFishCount, int babelFishCount, int goldFishCount)
        {
            Tank result = new Tank();

            for (int i = 0; i < angelFishCount; i++)
            {
                result.AddFish(new AngelFish($"Abigail {i + 1}"));
            }

            for (int i = 0; i < babelFishCount; i++)
            {
                result.AddFish(new BabelFish($"Bob {i + 1}"));
            }

            for (int i = 0; i < goldFishCount; i++)
            {
                result.AddFish(new GoldFish($"Geoff {i + 1}"));
            }

            return result;
        }

        #endregion
    }
}
