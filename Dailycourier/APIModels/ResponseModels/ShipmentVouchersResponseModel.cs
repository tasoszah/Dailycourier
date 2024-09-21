using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailycourier
{
    /// <summary>
    /// Represents a collection of shipment vouchers 
    /// </summary>
    public class ShipmentVouchersResponseModel : BaseDataResponseModel<ShipmentVoucherResponseModel>
    {
        #region Constructors
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public ShipmentVouchersResponseModel() : base()
        {

        }

        #endregion
    }
}
