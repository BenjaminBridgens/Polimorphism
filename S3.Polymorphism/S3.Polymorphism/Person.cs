using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.Polymorphism
{
    /// <summary>
    /// Represents a Person.
    /// </summary>
    public class Person : User
    {
        #region Fields
        /// <summary>
        /// The firstname of the person.
        /// </summary>
        protected string firstname;

        /// <summary>
        /// The lastname of the person.
        /// </summary>
        protected string lastname;

        /// <summary>
        /// The social sercurity number of the person.
        /// </summary>
        protected string ssn;
        #endregion


        #region Constructors
        /// <summary>
        /// Creates a new instance of this class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password. Must be at least 8 characters long and  at most 16, and contain 4-6 letters.</param>
        /// <param name="firstname">The firstname.</param>
        /// <param name="lastname">The lastname.</param>
        /// <param name="ssn">The social security number.</param>
        public Person(string username, string password, string firstname, string lastname, string ssn)
        {
            try
            {
                Username = username;
                Password = password;
                Firstname = firstname;
                Password = password;
                Ssn = ssn;
            }
            catch (ArgumentOutOfRangeException) { throw; }
            catch (ArithmeticException) { throw; }
        }
        #endregion


        #region Methods
        /// <summary>
        /// Validates the format of the ssn.
        /// </summary>
        /// <param name="ssn">The ssn to be validated.</param>
        /// <param name="error">The error message for the user, if an error occurred.</param>
        /// <exception cref="System.ArgumentException">Thrown when the ssn parameter is null, empty or whitespace.</exception>
        /// <returns>wether or not the validation was successfull.</returns>
        public static bool IsSsnValid(string ssn, out string error)
        {
            bool correctlyFormatted = false;
            if (String.IsNullOrWhiteSpace(ssn))
            {
                error = "Something went wrong";
                throw new ArgumentException();
            }
            else
            {
                error = String.Empty;
                correctlyFormatted = true;
            }
            return correctlyFormatted;
        }
        #endregion


        #region Properties        
        /// <summary>
        /// Gets or sets the firstname.
        /// </summary>
        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(firstname))
                {
                    throw new ArgumentException();
                }
                firstname = value;
            }
        }

        /// <summary>
        /// Gets or sets the lastname.
        /// </summary>
        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
            }
        }

        /// <summary>
        /// Gets or sets the social security number.
        /// </summary>
        public string Ssn
        {
            get
            {
                return ssn;
            }
            set
            {
                ssn = value;
            }
        }
        #endregion
    }
}
