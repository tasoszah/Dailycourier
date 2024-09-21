using Newtonsoft.Json;
using System.Collections.Generic;

namespace Dailycourier
{
    /// <summary>
    /// Represents the result of multiple shipments tracking operation
    /// </summary>
    public class ShipmentTrackingsResponseModel : BaseDataResponseModel<ShipmentTrackingResponseModel>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentTrackingsResponseModel() : base()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString()
        {
            var strings = new List<string>();
            foreach(var d in Data)
                strings.Add(d.ToString());

            return string.Join(", ", strings);
        }

        #endregion
    }
}
