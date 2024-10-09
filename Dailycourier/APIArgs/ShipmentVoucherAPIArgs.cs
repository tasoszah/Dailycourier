namespace Dailycourier
{
    /// <summary>
    /// Arguments used for retrieving a shipment voucher
    /// </summary>
    public class ShipmentVoucherAPIArgs
    {
        #region Public Methods

        /// <summary>
        /// The print type
        /// </summary>
        public PrintType? PrintType { get; set; }

        /// <summary>
        /// The shipment number
        /// </summary>
        public string? ShipmentNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentVoucherAPIArgs() : base()
        {

        }

        #endregion
    }
}
