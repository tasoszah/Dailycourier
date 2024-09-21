using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dailycourier
{
    /// <summary>
    /// Represents the result of a shipment tracking operation
    /// </summary>
    public class ShipmentTrackingResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The number of the shipment
        /// </summary>
        [JsonProperty("number")]
        public string Number {  get; set; }

        /// <summary>
        /// The full name of the collection point
        /// </summary>
        [JsonProperty("collection_point_full_name")]
        public string CollectionPointFullName { get; set; }

        /// <summary>
        /// The full name of the delivery point
        /// </summary>
        [JsonProperty("delivery_point_full_name")]
        public string DeliveryPointFullName { get; set; }

        /// <summary>
        /// The address of the delivery point
        /// </summary>
        [JsonProperty("delivery_point_address")]
        public string DeliveryPointAddress { get; set; }

        /// <summary>
        /// The postal code of the delivery point
        /// </summary>
        [JsonProperty("delivery_point_postal_code")]
        public string DeliveryPointPostalCode { get; set; }

        /// <summary>
        /// The history array
        /// </summary>
        [JsonProperty("history")]
        public List<ShipmentTrackingHistoryResponseModel> History { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentTrackingResponseModel()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => Number;

        #endregion
    }
}
