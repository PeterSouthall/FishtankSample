/***************************************************************************\
File Name:  Fish.cs
Project:      FishTank
Copyright (c) 2020
\***************************************************************************/

namespace FishtankSample.Entities
{
    using System;

    /// <summary>
    /// An abstract base class for a <see cref="Fish"/>.
    /// </summary>
    internal abstract class Fish
    {
        /// <summary>
        /// Gets or sets the name of the fish.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Fish"/> class.
        /// </summary>
        /// <param name="name">The name of the fish</param>
        public Fish(string name)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
                throw new ArgumentException($"Error attempting to create a fish without a name, type : {this.GetType().Name}, parameter : {nameof(name)}");

            Name = name;
        }

        /// <summary>
        /// Gets the feed amount for the fish type in grammes.
        /// </summary>
        /// <remarks>
        /// Each derived fish type has a different "feeding amount" so we want to implement that in the derived,
        /// for every derived as we may add different fish types later.
        /// </remarks>
        public abstract float FeedAmountInGrammes { get; }
    }
}
