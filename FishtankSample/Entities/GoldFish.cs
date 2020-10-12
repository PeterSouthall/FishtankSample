/***************************************************************************\
File Name:  GoldFish.cs
Project:      FishTank
Copyright (c) 2020
\***************************************************************************/

namespace FishtankSample.Entities
{
    using System;
    using FishtankSample.Settings;

    /// <summary>
    /// A gold fish.
    /// </summary>
    internal class GoldFish : Fish
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoldFish"/> class.
        /// </summary>
        /// <param name="name">The name of the fish</param>
        public GoldFish(string name)
            :
            base(name)
        {
        }

        /// <summary>
        /// Implementation of FeedAmountInGrammes for the gold fish.
        /// </summary>
        public override float FeedAmountInGrammes
        {
            get
            {
                float result = Convert.ToSingle(SettingsHelper.GetSetting("GoldFishFeedAmountGrammes"));
                return (float)Math.Round(result, 2);
            }
        }
    }
}
