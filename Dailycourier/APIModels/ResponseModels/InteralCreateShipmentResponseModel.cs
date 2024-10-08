using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailycourier
{
    public class InteralCreateShipmentResponseModel
    {
        #region Private Members

        /// <summary>
        /// The member of the <see cref="Message"/> property
        /// </summary>
        private string? mMessage;

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
            get => mMessage ?? String.Empty;

            set => mMessage = value;
        }

        /// <summary>
        /// The data as represented in the <see cref="CreateShipmentRequestModel"/>
        /// </summary>
        [JsonProperty("data")]
        public CreateShipmentResponseModel? Data { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public InteralCreateShipmentResponseModel() : base()
        {

        }

        #endregion
    }
}
