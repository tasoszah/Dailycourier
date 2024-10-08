using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dailycourier
{
    /// <summary>
    /// Request model used for retrieving shipments
    /// </summary>
    public class ShipmentsRequestModel
    {
        #region Public Methods

        /// <summary>
        /// The shipment numbers
        /// </summary>
        [JsonProperty("shipment_numbers")]
        public IEnumerable<string>? ShipmentNumbers { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentsRequestModel() 
        { 
        }

        #endregion
    }
}
