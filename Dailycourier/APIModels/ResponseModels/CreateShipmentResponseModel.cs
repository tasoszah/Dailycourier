using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
        #region Public Properties

        /// <summary>
        /// The UUID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The voucher number
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

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
        public PaymentType PaymentType { get; set; }

        /// <summary>
        /// Comments
        /// </summary>
        [JsonProperty("comments")]
        public string Comments { get; set; }

        /// <summary>
        /// The full name of the collection point
        /// </summary>
        [JsonProperty("collection_point_full_name")]
        public string CollectionPointFullName { get; set; }

        /// <summary>
        /// The phone of the collection points
        /// </summary>
        [JsonProperty("collection_point_phone")]
        public PhoneNumber CollectionPointPhone { get; set; }

        /// <summary>
        /// The address of the collection point
        /// </summary>
        [JsonProperty("collection_point_address")]
        public string CollectionPointAddress { get; set; }

        /// <summary>
        /// The postal code of the collection point
        /// </summary>
        [JsonProperty("collection_point_postal_code")]
        public string CollectionPointPostalCode { get; set; }

        /// <summary>
        /// The email of the collection point
        /// </summary>
        [JsonProperty("collection_point_email")]
        public string CollectionPointEmail { get; set; }

        /// <summary>
        /// The full name of the delivery point
        /// </summary>
        [JsonProperty("delivery_point_full_name")]
        public string DeliveryPointFullName { get; set; }

        /// <summary>
        /// The phone of the delivery point
        /// </summary>
        [JsonProperty("delivery_point_phone")]
        public PhoneNumber DeliveryPointPhone { get; set; }

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
        /// The email of the delivery point
        /// </summary>
        [JsonProperty("delivery_point_email")]
        public string DeliveryPointEmail { get; set; }

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
