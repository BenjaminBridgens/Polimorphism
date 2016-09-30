using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.Polymorphism
{
    /// <summary>
    /// Represents a user.
    /// </summary>
    public class User
    {
        #region Fields
        /// <summary>
        /// The username of a user.
        /// </summary>
        protected string username;

        /// <summary>
        /// The password of a user.
        /// </summary>
        protected string password;
        #endregion;


        #region Contructors
        /// <summary>
        /// Creates a new instance of this class. Use this class to enable a user to login, then downcast the object to the appropriate derived type.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password. Must be at least 8 characters long and  at most 16, and contain 4-6 letters.</param>        
        public User(string username, string password)
        {
            try
            {
                Username = username;
                Password = password;
            }
            catch (ArgumentOutOfRangeException) { throw; }
            catch (ArithmeticException) { throw; }
        }
        #endregion


        #region Methods
        /// <summary>
        /// Validates the format of the password.
        /// </summary>
        /// <param name="password">The password to be validated.</param>
        /// <param name="error">The error message for the user, if an error occurred.</param>
        /// <exception cref="System.ArgumentException">Thrown when the password parameter is null, empty or whitespace.</exception>
        /// <returns>wether or not the validation was successfull.</returns>
        public static bool IsValidPassword(string password, out string error)
        {
            bool correctlyFormatted = false;
            if (String.IsNullOrWhiteSpace(password))
            {
                error = "Something went wrong";
                throw new ArgumentException();
            }
            else if (password.Length < 8)
            {
                correctlyFormatted = false;
                error = "Password is too short, please try again.";
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
        /// Gets or sets the username.
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                if (String.IsNullOrWhiteSpace(username))
                {
                    throw new ArgumentException();
                }
                username = value;
            }
        }

        /// <summary>
        /// Gets or sets the password. Setter should only be called from non-UI code.
        /// </summary>
        /// <exception cref="System.ArgumentException">Thrown when the password parameter is null, empty or whitespace</exception>
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                // We need the output variable, but it is not used:
                string error = String.Empty;
                bool validationSuccess = false;

                // Attempt to validate the 'value' argument:
                try
                {
                    validationSuccess = IsValidPassword(value, out error);
                }
                catch (Exception)
                {
                    throw;
                }

                // Ifvalidation fails, log the error message, and throw an exeption:
                if (!validationSuccess)
                {
                    // log error message.
                    throw new ArgumentException();
                }
                else
                {
                    password = value;
                }
            }
        }
        #endregion
    }
}
