using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dailycourier
{
    /// <summary>
    /// The base for all the response models that contains a <see cref="Data"/> property
    /// </summary>
    /// <typeparam name="T">The type of the data</typeparam>
    public class BaseDataResponseModel<T>
    {
        #region Public Properties

        /// <summary>
        /// The data
        /// </summary>
        [JsonProperty("data")]
        public List<T> Data { get; set; }

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
