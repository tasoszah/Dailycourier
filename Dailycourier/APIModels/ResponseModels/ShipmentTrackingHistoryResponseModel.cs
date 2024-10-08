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
    /// Represents information related to a status change of a shipment tracking operation
    /// </summary>
    public class ShipmentTrackingHistoryResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="UpdatedBy"/> property
        /// </summary>
        private string? mUpdatedBy;

        /// <summary>
        /// The member of the <see cref="Comments"/> property
        /// </summary>
        private string? mComments;

        #endregion

        #region Public Properties

        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(ShipmentStatusToStringJsonConverter))]
        public ShipmentStatus Status { get; set; }

        /// <summary>
        /// The date the status changed
        /// </summary>
        [JsonProperty("datetime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// The entity that updated the status
        /// </summary>
        [AllowNull]
        [JsonProperty("updated_by")]
        public string UpdatedBy
        {
            get => mUpdatedBy ?? String.Empty;

            set => mUpdatedBy = value;
        }

        /// <summary>
        /// Additional information related to the change
        /// </summary>
        [AllowNull]
        [JsonProperty("comments")]
        public string Comments
        {
            get => mComments ?? String.Empty;

            set => mComments = value;
        }

        /// <summary>
        /// The file
        /// </summary>
        [JsonProperty("file")]
        public Uri? File { get; set; }

        /// <summary>
        /// The signature
        /// </summary>
        [JsonProperty("signature")]
        public Uri? Signature { get; set; }

        #endregion

        #region Constructors 
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentTrackingHistoryResponseModel()
        {

        }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        public override string ToString() => $"{Status} - {DateTime}";

        #endregion
    }
}
