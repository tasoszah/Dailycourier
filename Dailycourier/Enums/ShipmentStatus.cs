using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailycourier
{
    /// <summary>
    /// Provides enumeration over the statuses of the shipment
    /// </summary>
    public enum ShipmentStatus
    {
        AwaitingPickup,

        PickedUpFromDailycourier,

        SortingCenter,

        ToBeDelivered,

        Delivered,

        AbsenceOfRecipient,

        DeliveryFailure,

        SortingCenterOfRecepientLocation,

        StayByArrangement,

        DeliveredPA,

        InabilityToReceive,

        AbsentNote,

        DeniedReceival,

        ReturnToSender,

        IsReturnedToSender,

        ReceivalFromSortingCnter,

        UnkownReceipient,

        ShipmentRedirection,

        ShipmentRouting  
      
    }
}
