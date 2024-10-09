using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace Dailycourier
{
    /// <summary>
    /// An internal wrapper for the <see cref="ShipmentTrackingResponseModel"/>
    /// </summary>
    internal class InternalShipmentTrackingResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Data"/> property
        /// </summary>
        private ShipmentTrackingResponseModel? mData;

        #endregion

        #region Public Properties

        /// <summary>
        /// The data
        /// </summary>
        [AllowNull]
        [JsonProperty("data")]
        public ShipmentTrackingResponseModel Data
        {
            get => mData ??= new ShipmentTrackingResponseModel();

            set => mData = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InternalShipmentTrackingResponseModel() : base()
        {

        }

        #endregion
    }
}
