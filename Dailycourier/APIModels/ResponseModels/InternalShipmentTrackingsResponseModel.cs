using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Dailycourier
{
    /// <summary>
    /// An internal wrapper for a collection of  <see cref="ShipmentTrackingResponseModel"/>
    /// </summary>
    internal class InternalShipmentTrackingsResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Data"/> property
        /// </summary>
        private IEnumerable<ShipmentTrackingResponseModel>? mData;

        #endregion

        #region Public Properties

        /// <summary>
        /// The data
        /// </summary>
        [AllowNull]
        [JsonProperty("data")]
        public IEnumerable<ShipmentTrackingResponseModel> Data
        {
            get => mData ?? Enumerable.Empty<ShipmentTrackingResponseModel>();

            set => mData = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InternalShipmentTrackingsResponseModel() : base()
        {

        }

        #endregion
    }
}
