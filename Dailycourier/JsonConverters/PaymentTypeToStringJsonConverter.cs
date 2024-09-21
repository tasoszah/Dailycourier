using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Dailycourier
{
    /// <summary>
    /// A <see cref="JsonConverter{T}"/> for converting a <see cref="PaymentType"/> to a <see cref="string"/>
    /// </summary>
    public class PaymentTypeToStringJsonConverter : BaseEnumToStringJsonConverter<PaymentType>
    {
        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public PaymentTypeToStringJsonConverter()
        { }

        #endregion

        #region Public Methods

        /// <inheritdoc/>
        protected override Dictionary<PaymentType, string> GetMapper()
        {
            return DailycourierConstants.PaymentTypeToStringMapper;
        }

        #endregion
    }
}
