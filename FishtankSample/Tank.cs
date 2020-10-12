/***************************************************************************\
File Name:  Tank.cs
Project:      FishTank
Copyright (c) 2020
\***************************************************************************/

namespace FishtankSample
{
    using System;
    using System.Collections.Generic;
    using FishtankSample.Entities;

    /// <summary>
    /// A tank to hold the fish.
    /// </summary>
    internal class Tank
    {
        #region Fields

        /// <summary>
        /// The collection of fish in the tank.
        /// </summary>
        private readonly List<Fish> _fishes = null;

        #endregion

        #region Properties

        /// <summary>
        /// Gets a count of the number of fish in the tank.
        /// </summary>
        public int FishCount => _fishes.Count;

        #endregion

        #region Constructors

        /// <summary>
        /// Initialises a new instance of the <see cref="Tank" /> class.
        /// </summary>
        public Tank()
        {
            _fishes = new List<Fish>();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Adds a fish to the tank.
        /// </summary>
        /// <param name="fish">The fish to add.</param>
        public void AddFish(Fish fish)
        {
            if (fish == null)
                throw new ArgumentException($"Error attempting to add a null fish to the tank, type : {this.GetType().Name}, parameter : {nameof(fish)}");

            _fishes.Add(fish);
        }

        /// <summary>
        /// Calculates how much food to feed the fish.
        /// </summary>
        /// <returns>The amount of required food in grammes to feed the fish.</returns>
        public float Feed()
        {
            float result = 0.0f;
            _fishes.ForEach(fish => result += fish.FeedAmountInGrammes);
            return (float)Math.Round(result, 2);
        }

        #endregion
    }
}
