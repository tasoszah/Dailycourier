using Newtonsoft.Json;
using System;

namespace Dailycourier
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for converting a <see cref="ShipmentStatus"/> to a <see cref="string"/>
    /// </summary>
    public class ShipmentStatusToStringJsonConverter : JsonConverter<ShipmentStatus>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentStatusToStringJsonConverter()
        {
                
        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override ShipmentStatus ReadJson(JsonReader reader, Type objectType, ShipmentStatus existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            var value = serializer.Deserialize<string>(reader);

            if (string.IsNullOrWhiteSpace(value))
                return ShipmentStatus.AwaitingPickup;

            foreach (var pair in DailycourierConstants.ShipmentStatusToStringMapper)
                if (pair.Value == value)
                    return pair.Key;

            return ShipmentStatus.AwaitingPickup;
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, ShipmentStatus value, JsonSerializer serializer)
        {
            writer.WriteValue(DailycourierConstants.ShipmentStatusToStringMapper[value]);
        }

        #endregion
    }
}
