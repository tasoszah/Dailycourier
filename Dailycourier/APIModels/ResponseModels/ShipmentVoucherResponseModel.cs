using Newtonsoft.Json;

namespace Dailycourier
{
    /// <summary>
    /// Represents a shipment voucher
    /// </summary>
    public class ShipmentVoucherResponseModel
    {
        #region Public Properties

        /// <summary>
        /// The content type
        /// </summary>
        [JsonProperty("content-type")]
        public string ContentType { get; set; }

        /// <summary>
        /// The content
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentVoucherResponseModel() : base()
        {

        }

        #endregion
    }
}
