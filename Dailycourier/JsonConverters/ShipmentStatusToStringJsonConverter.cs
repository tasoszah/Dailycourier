using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Dailycourier
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for converting a <see cref="ShipmentStatus"/> to a <see cref="string"/>
    /// </summary>
    public class ShipmentStatusToStringJsonConverter : BaseEnumToStringJsonConverter<ShipmentStatus>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentStatusToStringJsonConverter()
        {
                
        }

        #endregion

        #region Protected Methods

        /// <inheritdoc/>
        protected override Dictionary<ShipmentStatus, string> GetMapper()
        {
            return DailycourierConstants.ShipmentStatusToStringMapper;
        }

        #endregion
    }
}
