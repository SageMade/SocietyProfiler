using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SocietyProfiler.Profiles
{
    /// <summary>
    /// Represents a person's personality
    /// </summary>
    public struct ProfileInfo
    {
        #region Undefined Variables
        /// <summary>
        /// Represents the person's sexual orientation
        /// </summary>
        public Sexuality Sexuality;
        /// <summary>
        /// Represents the person's gender
        /// </summary>
        public Gender Gender;
        #endregion

        #region Predefined Variables
        /// <summary>
        /// Represents the person's courage level
        /// </summary>
        public float Courage;
        /// <summary>
        /// Represents the person's empathy level
        /// </summary>
        public float Empathy;
        /// <summary>
        /// Represents the person's greed level
        /// </summary>
        public float Greed;
        /// <summary>
        /// Represents the person's motivation level
        /// </summary>
        public float Motivation;
        /// <summary>
        /// Represents the person's charisma level
        /// </summary>
        public float Charisma;
        /// <summary>
        /// Represents the person's compassion level
        /// </summary>
        public float Compassion;
        /// <summary>
        /// Represents the person's humor level
        /// </summary>
        public float Humor;
        /// <summary>
        /// Represents how emotional the person is
        /// </summary>
        public float Emotion;
        /// <summary>
        /// Represents how optimistic the person is
        /// </summary>
        public float Optimism;
        /// <summary>
        /// Represents how well a peson can adapt
        /// </summary>
        public float Adaptibility;
        /// <summary>
        /// Represents how intelligent the person is
        /// </summary>
        public float Intelligence;
        /// <summary>
        /// Represents how confident the person is
        /// </summary>
        public float Confidence;
        /// <summary>
        /// Represents the ingenuity level of this person
        /// </summary>
        public float Ingenuity;
        #endregion

        #region Constructors
        /// <summary>
        /// Creates a new personality profile with all average stats
        /// </summary>
        /// <param name="gender">The profile's gender</param>
        /// <param name="sexuality">The profile's sexuality</param>
        public ProfileInfo(Gender gender, Sexuality sexuality = Sexuality.Heterosexual)
        {
            Gender = gender;
            Sexuality = sexuality;

            Courage = 50;
            Empathy = 50;
            Greed = 50;
            Motivation = 50;
            Charisma = 50;
            Compassion = 50;
            Humor = 50;
            Emotion = 50;
            Optimism = 50;
            Adaptibility = 50;
            Intelligence = 50;
            Confidence = 50;
            Ingenuity = 50;
        }
        #endregion
    }
}
