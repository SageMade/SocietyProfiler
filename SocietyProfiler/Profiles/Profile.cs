using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SocietyProfiler.Tools;

namespace SocietyProfiler.Profiles
{
    /// <summary>
    /// Represents a person
    /// </summary>
    public class Profile : IComparable<Profile>
    {
        #region Private Variables
        /// <summary>
        /// This profile's initial info
        /// </summary>
        ProfileInfo _info;
        /// <summary>
        /// This profile's age in years
        /// </summary>
        float _age;

        /// <summary>
        /// This person's first name
        /// </summary>
        string _firstName;
        /// <summary>
        /// This person's middle name
        /// </summary>
        string _middleName;
        /// <summary>
        /// This person's filastrst name
        /// </summary>
        string _lastName;

        /// <summary>
        /// This profile's mother
        /// </summary>
        Profile _mother;
        /// <summary>
        /// This profile's father
        /// </summary>
        Profile _father;
        /// <summary>
        /// This profile's sexual partner
        /// </summary>
        Profile _partner;

        /// <summary>
        /// This profile's children
        /// </summary>
        Profile[] _children;
        #endregion

        #region Public Properties
        /// <summary>
        /// Gets this profile's full name
        /// </summary>
        public string Name
        {
            get { return _firstName + " " + _lastName; }
        }

        /// <summary>
        /// Gets this profile's information
        /// </summary>
        public ProfileInfo Info
        {
            get { return _info; }
        }
        #endregion

        #region Constructors
        /// <summary>
        /// Generates a random profile
        /// </summary>
        public Profile()
        {
            _info = new ProfileInfo(StaticRandom.Chance(50) ? Gender.Male : Gender.Female, Sexuality.Heterosexual);
            _age = 0;

            _firstName = _info.Gender == Gender.Male ? NameProvider.GetBoysName() : NameProvider.GetGirlsName();
            _lastName = NameProvider.GetLastName();

            FixName();
            _children = new Profile[0];
        }

        /// <summary>
        /// Creates a new person ;) (bow chicka wow wow)
        /// </summary>
        /// <param name="gender">The person's gender</param>
        /// <param name="sexuality">The person's sexual orientation</param>
        public Profile(Gender gender, Sexuality sexuality = Sexuality.Heterosexual)
        {
            _info = new ProfileInfo(gender, sexuality);
            _age = 0;

            _firstName = _info.Gender == Gender.Male ? NameProvider.GetBoysName() : NameProvider.GetGirlsName();
            _lastName = NameProvider.GetLastName();

            FixName();
            _children = new Profile[0];
        }

        /// <summary>
        /// Creates a new person from a mother and father
        /// </summary>
        /// <param name="mother">The mother</param>
        /// <param name="father">The father</param>
        public Profile(Profile mother, Profile father)
        {
            if (mother._info.Gender != Gender.Female || father._info.Gender != Gender.Male)
                throw new ArgumentException("The mother and father need to be male and female.");

            _mother = mother;
            _father = father;
            _age = 0;
            
            _info = new ProfileInfo(StaticRandom.Chance(50) ? Gender.Male : Gender.Female, 
                Sexuality.Heterosexual);
            
            _firstName = _info.Gender == Gender.Male ? NameProvider.GetBoysName() : NameProvider.GetGirlsName();
            _lastName = father._lastName;

            FixName();
            _children = new Profile[0];
        }
        #endregion

        /// <summary>
        /// Fixes the profiles names
        /// </summary>
        private void FixName()
        {
            _firstName = Capitalize(_firstName).Replace("\r", "");
            _lastName = Capitalize(_lastName).Replace("\r", "");
            _middleName = Capitalize(_middleName).Replace("\r", "");
        }

        /// <summary>
        /// Capitalizes a string
        /// </summary>
        /// <param name="s">The string to capitalize</param>
        /// <returns>The capitalized version of <i>s</i></returns>
        private string Capitalize(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        #region External Functions
        /// <summary>
        /// Marries this profile to another
        /// </summary>
        /// <param name="other">The other profile to marry</param>
        public void Marry(Profile other)
        {
            if (other.Info.Gender != Info.Gender & Info.Sexuality == Sexuality.Heterosexual)
            {
                _partner = other;

                _lastName = _info.Gender == Gender.Male ? _lastName : other._lastName;
                other._lastName = other.Info.Gender == Gender.Female ? _lastName : other._lastName;
            }
        }

        /// <summary>
        /// Makes this profile have a child with their partner and returns that child
        /// </summary>
        /// <returns>The child, or null if this profile does not have a partner</returns>
        public Profile HaveChild()
        {
            if (_partner != null && Info.Sexuality == Sexuality.Heterosexual)
            {
                Profile child = new Profile(this, _partner);

                child._firstName = GetChildName(child);
                SetChildStats(child);

                if (child.Name == "Kale Stephens" || child.Name == "Paul Pietsch" || child.Name == "Eric Pietsch")
                    child._info.Sexuality = Sexuality.Homosexual;

                if (StaticRandom.Chance(3.0F))
                    child._info.Sexuality = Sexuality.Homosexual;

                Profile[] temp = new Profile[_children.Length + 1];
                _children.CopyTo(temp,0);
                temp[temp.Length - 1] = child;
                _children = temp;

                _partner._children = _children;

                return child;
            }
            return null;
        }

        /// <summary>
        /// Gets a child's name which deos not exist with it's siblings
        /// </summary>
        /// <param name="child">The child to name</param>
        /// <returns>A name for the child</returns>
        private string GetChildName(Profile child)
        {
            string name = child.Info.Gender == Gender.Male ? NameProvider.GetBoysName() :
                NameProvider.GetGirlsName();
            name.Replace(" ", "");

            int i = 0;
            while (SearchChildren(name) != null & i < 100)
            {
                i++; 

                name = child.Info.Gender == Gender.Male ? NameProvider.GetBoysName() :
                    NameProvider.GetGirlsName();

                name.Replace(" ", "");
            }

            return name;
        }

        private void SetChildStats(Profile child)
        {
            child._info.Adaptibility = (_info.Adaptibility + _partner._info.Adaptibility) / 2.0F + StaticRandom.Next(-5, 5);
            child._info.Charisma = (_info.Charisma + _partner._info.Charisma) / 2.0F + StaticRandom.Next(-5, 5) - StaticRandom.Next(_children.Length * 5);
            child._info.Compassion = (_info.Compassion + _partner._info.Compassion) / 2.0F + StaticRandom.Next(-5, 5) + StaticRandom.Next(_children.Length * 2);
            child._info.Confidence = (_info.Confidence + _partner._info.Confidence) / 2.0F + StaticRandom.Next(-5, 5) - StaticRandom.Next(_children.Length * 4);
            child._info.Courage = (_info.Courage + _partner._info.Courage) / 2.0F + StaticRandom.Next(-10, 10);
            child._info.Emotion = (_info.Emotion + _partner._info.Emotion) / 2.0F + StaticRandom.Next(-5, 5) + StaticRandom.Next(_children.Length * 4);
            child._info.Empathy = (_info.Empathy + _partner._info.Empathy) / 2.0F + StaticRandom.Next(-5, 5) + StaticRandom.Next(_children.Length * 3);
            child._info.Greed = (_info.Greed + _partner._info.Greed) / 2.0F + StaticRandom.Next(-20, 20);
            child._info.Humor = (_info.Humor + _partner._info.Humor) / 2.0F + StaticRandom.Next(-20, 20);
            child._info.Intelligence = (_info.Intelligence + _partner._info.Intelligence) / 2.0F + StaticRandom.Next(-10, 10);
            child._info.Ingenuity = child._info.Intelligence + StaticRandom.Next(-10, 10);
            child._info.Motivation = (_info.Motivation + _partner._info.Motivation) / 2.0F + StaticRandom.Next(-5, 5);
            child._info.Optimism = (_info.Optimism + _partner._info.Optimism) / 2.0F + StaticRandom.Next(-5, 5);
        }

        /// <summary>
        /// Gets the first child with the given first name
        /// </summary>
        /// <param name="firstName">The name to search for</param>
        /// <returns>The first child with the given name, or null</returns>
        public Profile SearchChildren(string firstName)
        {
            Profile p = Array.Find<Profile>(_children, X => X._firstName == firstName);
            return p;
        }

        /// <summary>
        /// Compares this profile to another
        /// </summary>
        /// <param name="obj">The object to compare to</param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Profile otherProfile = obj as Profile;
            if (otherProfile != null)
                return this.Name.CompareTo(otherProfile.Name);
            else
                throw new ArgumentException("Object is not a Profile");
        }

        /// <summary>
        /// Compares this profile to another
        /// </summary>
        /// <param name="obj">The profile to compare to</param>
        /// <returns></returns>
        public int CompareTo(Profile obj)
        {
            if (obj != null)
                return this.Name.CompareTo(obj.Name);
            else
                throw new ArgumentException("Object is not a Profile");
        }
        #endregion
    }
}
