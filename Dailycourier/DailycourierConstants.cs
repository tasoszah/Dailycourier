using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailycourier
{
    /// <summary>
    /// Constants related to Dailycourier
    /// </summary>
    public static class DailycourierConstants
    {
        /// <summary>
        /// Maps the <see cref="ShipmentStatus"/>es to their related <see cref="string"/>s
        /// </summary>
        public static Dictionary<ShipmentStatus, string> ShipmentStatusToStringMapper { get; } = new Dictionary<ShipmentStatus, string>() 
        {
            { ShipmentStatus.AwaitingPickup, "Aναμονή παραλαβής" },
            { ShipmentStatus.PickedUpFromDailycourier, "Παρελήφθηκε από Dailycourier.gr" },
            { ShipmentStatus.SortingCenter, "Aναμονή παραλαβής" },
            { ShipmentStatus.ToBeDelivered, "Aναμονή παραλαβής" },
        };

    }
}
