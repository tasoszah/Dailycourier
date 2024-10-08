using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dailycourier
{
    /// <summary>
    /// API routes related to the Dailicourier
    /// </summary>
    public static class APIRoutes
    {
        public const string ProductionRoute = "https://erp.dailycourier.gr/api/v2";

        public const string TestingRoute = "https://stoplight.io/mocks/dailycourier/web-services/247413813";

        public static string GetBaseRoute(bool shouldUseTestEnvironment)
        {
            if (shouldUseTestEnvironment)
                return TestingRoute;

            return ProductionRoute;
        }

        public static string CreateShipmentRoute(bool shouldUseTestEnvironment) => $"{GetBaseRoute(shouldUseTestEnvironment)}/shipments";

        public static string GetShipmentsTracking(bool shouldUseTestEnvironment) => $"{GetBaseRoute(shouldUseTestEnvironment)}/shipments/tracking";

        public static string GetShipmentTrackingRoute(bool shouldUseTestEnvironment, string shipmentNumber) => $"{GetBaseRoute(shouldUseTestEnvironment)}/shipments/tracking/{shipmentNumber}";

        public static string GetShipmentVoucherRoute(bool shouldUseTestEnvironment, string shipmentNumber, PrintType printType) => $"{GetBaseRoute(shouldUseTestEnvironment)}/shipments/voucher/{shipmentNumber}/{DailycourierConstants.PrintTypeToStringMapper[printType]}";

        public static string GetShipmentVouchersRoute(bool shouldUseTestEnvironment, PrintType printType) => $"{GetBaseRoute(shouldUseTestEnvironment)}/shipments/vouchers/{DailycourierConstants.PrintTypeToStringMapper[printType]}";
    }
}
