using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Dailycourier
{
    /// <summary>
    /// The base for all the response models that contains a <see cref="Data"/> property
    /// </summary>
    /// <typeparam name="T">The type of the data</typeparam>
    public class BaseDataResponseModel<T>
    {
        #region Private Members

        /// <summary>
        /// The members of the <see cref="Data"/> property
        /// </summary>
        private IEnumerable<T>? mData;

        #endregion

        #region Public Properties

        /// <summary>
        /// The data
        /// </summary>
        [AllowNull]
        [JsonProperty("data")]
        public IEnumerable<T> Data
        {
            get => mData ?? Enumerable.Empty<T>();

            set => mData = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseDataResponseModel() : base()
        {

        }

        #endregion
    }
}
