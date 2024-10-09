using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace Dailycourier
{
    /// <summary>
    /// An internal wrapper for the <see cref="CreateShipmentResponseModel"/>
    /// </summary>
    internal class InternalCreateShipmentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Message"/> property
        /// </summary>
        private string? mMessage;

        /// <summary>
        /// The member of the <see cref="Data"/> property
        /// </summary>
        private CreateShipmentResponseModel? mData;

        #endregion

        #region Public Properties

        /// <summary>
        /// The status
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// The message
        /// </summary>
        [AllowNull]
        [JsonProperty("message")]
        public string Message
        {
            get => mMessage ?? string.Empty;

            set => mMessage = value;
        }

        /// <summary>
        /// The data as represented in the <see cref="CreateShipmentRequestModel"/>
        /// </summary>
        [AllowNull]
        [JsonProperty("data")]
        public CreateShipmentResponseModel Data
        {
            get => mData ??= new CreateShipmentResponseModel();

            set => mData = value;
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InternalCreateShipmentResponseModel() : base()
        {
            
        }

        #endregion
    }
}
