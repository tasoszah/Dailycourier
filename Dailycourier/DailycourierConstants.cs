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
            { ShipmentStatus.SortingCenter, "Κέντρο διαλογής" },
            { ShipmentStatus.ToBeDelivered, "Προς Παράδοση" },
            { ShipmentStatus.Delivered, "Παραδόθηκε" },
            { ShipmentStatus.AbsenceOfRecipient, "Απουσία Παραλήπτη" },
            { ShipmentStatus.DeliveryFailure, "Αδυναμία Παράδοσης" },
            { ShipmentStatus.SortingCenterOfRecepientLocation, "Κέντρο διαλογής περιοχής παραλήπτη" },
            { ShipmentStatus.StayByArrangement, "Παραμονή με συνεννόηση" },
            { ShipmentStatus.DeliveredPA, "Παραδόθηκε Π.Α." },
            { ShipmentStatus.InabilityToReceive, "Αδυναμία Παραλαβής" },
            { ShipmentStatus.AbsentNote, "Απών - Σημείωμα" },
            { ShipmentStatus.DeniedReceival, "Άρνηση παραλαβής" },
            { ShipmentStatus.ReturnToSender, "Επιστροφή στον αποστολέα" },
            { ShipmentStatus.IsReturnedToSender, "Επιστράφηκε στον αποστολέα" },
            { ShipmentStatus.ReceivalFromSortingCnter, "Παραλαβή από κέντρο διαλογής" },
            { ShipmentStatus.UnkownReceipient, "Άγνωστος Παραλήπτης" },
            { ShipmentStatus.ShipmentRedirection, "Ανακατεύθυνση αποστολής" },
            { ShipmentStatus.ShipmentRouting, "Δρομολόγηση Αποστολής" }
        };

        /// <summary>
        /// Maps the <see cref="PaymentType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static Dictionary<PaymentType, string> PaymentTypeToStringMapper { get; } = new Dictionary<PaymentType, string>()
        {
            {PaymentType.Payment, "Πληρωμή" },
            {PaymentType.Cash, "Μετρητά" },
            {PaymentType.POS, "PoS" },
            {PaymentType.Check, "Αξιόγραφο" }
        };

        /// <summary>
        /// Maps the <see cref="PrintType"/>s to their related <see cref="string"/>s
        /// </summary>
        public static Dictionary<PrintType, string> PrintTypeToStringMapper { get; } = new Dictionary<PrintType, string>()
        {
            {PrintType.Label, "label" },
            {PrintType.Bol, "bol" },
            {PrintType.Invoice, "invoice" },
            {PrintType.Waybill, "waybill" }
        };
    }
}
