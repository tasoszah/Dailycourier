using System;
using System.Linq;

namespace Dailycourier
{
    /// <summary>
    /// Represents a phone number
    /// </summary>
    public class PhoneNumber
    {
        #region Constants

        /// <summary>
        /// The valid phone number characters
        /// </summary>
        private static readonly char[] ValidCharacters = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        #endregion

        #region Public Properties

        /// <summary>
        /// The country code
        /// </summary>
        public int CountryCode { get; }

        /// <summary>
        /// The phone
        /// </summary>
        public string Phone { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PhoneNumber(int countryCode, string phone) : base()
        {
            if (string.IsNullOrEmpty(phone))
                throw new ArgumentException($"'{nameof(phone)}' cannot be null or empty.", nameof(phone));

            foreach (var character in phone)
                if (!ValidCharacters.Contains(character))
                    throw new InvalidOperationException($"The character '{character}' can not be contained in a phone number.");

            CountryCode = countryCode;
            Phone = phone;
        }

        #endregion
    }
}
