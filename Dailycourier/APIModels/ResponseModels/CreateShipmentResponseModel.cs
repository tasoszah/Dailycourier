using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailycourier
{
    /// <summary>
    /// Represents a created shipment
    /// </summary>
    public class CreateShipmentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Id"/> property
        /// </summary>
        private string? mId;

        /// <summary>
        /// The member of the <see cref="Number"/> property
        /// </summary>
        private string? mNumber;

        /// <summary>
        /// The member of the <see cref="Comments"/> property
        /// </summary>
        private string? mComments;

        /// <summary>
        /// The member of the <see cref="CollectionPointFullName"/> property
        /// </summary>
        private string? mCollectionPointFullName;

        /// <summary>
        /// The member of the <see cref="CollectionPointAddress"/> property
        /// </summary>
        private string? mCollectionPointAddress;

        /// <summary>
        /// The member of the <see cref="CollectionPointPostalCode"/> property
        /// </summary>
        private string? mCollectionPointPostalCode;

        /// <summary>
        /// The member of the <see cref="DeliveryPointFullName"/> property
        /// </summary>
        private string? mDeliveryPointFullName;

        /// <summary>
        /// The member of the <see cref="DeliveryPointAddress"/> property
        /// </summary>
        private string? mDeliveryPointAddress;

        /// <summary>
        /// The member of the <see cref="DeliveryPointPostalCode"/> property
        /// </summary>
        private string? mDeliveryPointPostalCode;

        #endregion

        #region Public Properties

        /// <summary>
        /// The UUID
        /// </summary>
        [AllowNull]
        [JsonProperty("id")]
        public string Id
        {
            get => mId ?? String.Empty;

            set => mId = value;
        }

        /// <summary>
        /// The voucher number
        /// </summary>
        [AllowNull]
        [JsonProperty("number")]
        public string Number
        {
            get => mNumber ?? String.Empty;

            set => mNumber = value;
        }

        /// <summary>
        /// The shipment status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(ShipmentStatusToStringJsonConverter))]
        public ShipmentStatus Status { get; set; }

        /// <summary>
        /// Cash On Delivery amount;
        /// </summary>
        /// <remarks>
        /// <para>
        /// 1. in case of non-COD(eg prepaid), this value shall be null or the cod_amount parameter, shall not be included in the call
        /// </para>
        /// <para>
        /// 2. use dot '.' for decimals and no other symbol for thousands eg 1024.64
        /// </para>
        /// </remarks>
        [JsonProperty("cod_amount")]
        public decimal CODAmount { get; set; }
        
        /// <summary>
        /// The payment type
        /// </summary>
        [JsonProperty("payment_type")]
        [JsonConverter (typeof(PaymentTypeToStringJsonConverter))]
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// Comments
        /// </summary>
        [AllowNull]
        [JsonProperty("comments")]
        public string Comments
        {
            get => mComments ?? String.Empty;

            set => mComments = value;
        }

        /// <summary>
        /// The full name of the collection point
        /// </summary>
        [AllowNull]
        [JsonProperty("collection_point_full_name")]
        public string CollectionPointFullName
        {
            get => mCollectionPointFullName ?? String.Empty;

            set => mCollectionPointFullName = value;
        }

        /// <summary>
        /// The phone of the collection points
        /// </summary>
        [JsonProperty("collection_point_phone")]
        public string? CollectionPointPhone { get; set; }

        /// <summary>
        /// The address of the collection point
        /// </summary>
        [AllowNull]
        [JsonProperty("collection_point_address")]
        public string CollectionPointAddress
        {
            get => mCollectionPointAddress ?? String.Empty;

            set => mCollectionPointAddress = value;
        }

        /// <summary>
        /// The postal code of the collection point
        /// </summary>
        [AllowNull]
        [JsonProperty("collection_point_postal_code")]
        public string CollectionPointPostalCode
        {
            get => mCollectionPointPostalCode ?? String.Empty;

            set => mCollectionPointPostalCode = value;
        }

        /// <summary>
        /// The email of the collection point
        /// </summary>
        [JsonProperty("collection_point_email")]
        public string? CollectionPointEmail { get; set; }

        /// <summary>
        /// The full name of the delivery point
        /// </summary>
        [AllowNull]
        [JsonProperty("delivery_point_full_name")]
        public string DeliveryPointFullName
        {
            get => mDeliveryPointFullName ?? String.Empty;

            set => mDeliveryPointFullName = value;
        }

        /// <summary>
        /// The phone of the delivery point
        /// </summary>
        [JsonProperty("delivery_point_phone")]
        public string? DeliveryPointPhone { get; set; }

        /// <summary>
        /// The address of the delivery point
        /// </summary>
        [AllowNull]
        [JsonProperty("delivery_point_address")]
        public string DeliveryPointAddress
        {
            get => mDeliveryPointAddress ?? String.Empty;

            set => mDeliveryPointAddress = value;
        }

        /// <summary>
        /// The postal code of the delivery point
        /// </summary>
        [AllowNull]
        [JsonProperty("delivery_point_postal_code")]
        public string DeliveryPointPostalCode
        {
            get => mDeliveryPointPostalCode ?? String.Empty;

            set => mDeliveryPointPostalCode = value;
        }

        /// <summary>
        /// The email of the delivery point
        /// </summary>
        [JsonProperty("delivery_point_email")]
        public string? DeliveryPointEmail { get; set; }

        /// <summary>
        /// A flag indicating whether the shipment can be returned or not
        /// </summary>
        [JsonProperty("return_shipment")]
        public bool CanReturnShipment { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor
        /// </summary>
        public CreateShipmentResponseModel()
        {

        }

        #endregion
    }
}
