/***************************************************************************\
File Name:  BabelFish.cs
Project:      FishTank
Copyright (c) 2020
\***************************************************************************/

namespace FishtankSample.Entities
{
    using System;
    using FishtankSample.Settings;

    /// <summary>
    /// A bebel fish.
    /// </summary>
    internal class BabelFish : Fish
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BabelFish"/> class.
        /// </summary>
        /// <param name="name">The name of the fish</param>
        public BabelFish(string name)
            :
            base(name)
        {
        }

        /// <summary>
        /// Implementation of FeedAmountInGrammes for the babel fish.
        /// </summary>
        public override float FeedAmountInGrammes
        {
            get
            {
                float result = Convert.ToSingle(SettingsHelper.GetSetting("BabelFishFeedAmountGrammes"));
                return (float)Math.Round(result, 2);
            }
        }
    }
}
