using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Dailycourier
{
    /// <summary>
    /// Represents a shipment voucher
    /// </summary>
    public class ShipmentVoucherResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="ContentType"/> property
        /// </summary>
        private string? mContentType;

        /// <summary>
        /// The member of the <see cref="Content"/> property
        /// </summary>
        private string? mContent;

        #endregion

        #region Public Properties

        /// <summary>
        /// The content type
        /// </summary>
        [AllowNull]
        [JsonProperty("content-type")]
        public string ContentType
        {
            get => mContentType ?? string.Empty;

            set => mContentType = value;
        }

        /// <summary>
        /// The content
        /// </summary>
        [AllowNull]
        [JsonProperty("content")]
        public string Content
        {
            get => mContent ?? string.Empty;

            set => mContent = value;
        }

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
