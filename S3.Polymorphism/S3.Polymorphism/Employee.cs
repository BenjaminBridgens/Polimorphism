using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S3.Polymorphism
{
    /// <summary>
    /// Represent an Employee.
    /// </summary>
    class Employee : Person
    {
        #region Fields
        /// <summary>
        /// The base salary of the employee.
        /// </summary>
        protected decimal baseSalary;

        /// <summary>
        /// The bonus that may be added to the employee's base salary for christmas.
        /// </summary>
        protected decimal christmasBonus;
        #endregion


        #region Constructors
        /// <summary>
        /// Creates a new instance of this class.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="firstname">The firstname.</param>
        /// <param name="lastname">The lastname.</param>
        /// <param name="ssn">The social security number.</param>
        /// <param name="baseSalary">The base salary.</param>
        /// <param name="christmasBonus">The christmas bonus.</param>
        public Employee(string username, string password, string firstname, string lastname, string ssn, decimal baseSalary, decimal christmasBonus)
        {
            try
            {
                Username = username;
                Password = password;
                Firstname = firstname;
                Password = password;
                Ssn = ssn;
                BaseSalary = baseSalary;
                ChristmasBonus = christmasBonus;
            }
        }
        #endregion


        #region Methods

        public decimal GetYearlySalary()
        {
            decimal yearlySalary = 0.0m;
            

        }
        #endregion


        #region Properties
        /// <summary>
        /// Gets or sets the base salary.
        /// </summary>
        public decimal BaseSalary
        {
            get
            {
                return baseSalary;
            }

            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("A base salary cannot be negative.");
                }
                else if (baseSalary != value)
                {
                    baseSalary = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the christmas bonus.
        /// </summary>
        public decimal ChristmasBonus
        {
            get
            {
                return christmasBonus;
            }

            set
            {
                if (value < 0.0m)
                {
                    throw new ArgumentOutOfRangeException("A bonus salary cannot be negative.");
                }
                else if (christmasBonus != value)
                {
                    christmasBonus = value;
                }
            }
        }
        #endregion
    }
}
