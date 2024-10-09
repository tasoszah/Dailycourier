using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Dailycourier
{
    /// <summary>
    /// Represents the result of a shipment tracking operation
    /// </summary>
    public class ShipmentTrackingResponseModel
    {
        #region Private Members

        /// <summary>
        /// The members of the <see cref="Number"/> property
        /// </summary>
        private string? mNumber;

        /// <summary>
        /// The members of the <see cref="CollectionPointFullName"/> property
        /// </summary>
        private string? mCollectionPointFullName;

        /// <summary>
        /// The members of the <see cref="DeliveryPointFullName"/> property
        /// </summary>
        private string? mDeliveryPointFullName;

        /// <summary>
        /// The members of the <see cref="DeliveryPointAddress"/> property
        /// </summary>
        private string? mDeliveryPointAddress;

        /// <summary>
        /// The members of the <see cref="DeliveryPointPostalCode"/> property
        /// </summary>
        private string? mDeliveryPointPostalCode;

        /// <summary>
        /// The members of the <see cref="History"/> property
        /// </summary>
        private IEnumerable<ShipmentTrackingHistoryResponseModel>? mHistory;

        #endregion

        #region Public Properties

        /// <summary>
        /// The number of the shipment
        /// </summary>
        [AllowNull]
        [JsonProperty("number")]
        public string Number
        {
            get => mNumber ?? string.Empty;

            set => mNumber = value;
        }

        /// <summary>
        /// The full name of the collection point
        /// </summary>
        [AllowNull]
        [JsonProperty("collection_point_full_name")]
        public string CollectionPointFullName
        {
            get => mCollectionPointFullName ?? string.Empty;

            set => mCollectionPointFullName = value;
        }

        /// <summary>
        /// The full name of the delivery point
        /// </summary>
        [AllowNull]
        [JsonProperty("delivery_point_full_name")]
        public string DeliveryPointFullName
        {
            get => mDeliveryPointFullName ?? string.Empty;

            set => mDeliveryPointFullName = value;
        }
        /// <summary>
        /// The address of the delivery point
        /// </summary>
        [AllowNull]
        [JsonProperty("delivery_point_address")]
        public string DeliveryPointAddress
        {
            get => mDeliveryPointAddress ?? string.Empty;

            set => mDeliveryPointAddress = value;
        }

        /// <summary>
        /// The postal code of the delivery point
        /// </summary>
        [AllowNull]
        [JsonProperty("delivery_point_postal_code")]
        public string DeliveryPointPostalCode
        {
            get => mDeliveryPointPostalCode ?? string.Empty;

            set => mDeliveryPointPostalCode = value;
        }

        /// <summary>
        /// The history array
        /// </summary>
        [AllowNull]
        [JsonProperty("history")]
        public IEnumerable<ShipmentTrackingHistoryResponseModel> History
        {
            get => mHistory ?? Enumerable.Empty<ShipmentTrackingHistoryResponseModel>();

            set => mHistory = value;
        }

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
