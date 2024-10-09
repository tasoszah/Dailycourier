using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dailycourier
{
    /// <summary>
    /// An agent capable for making API requests to the Dailycourier web API
    /// </summary>
    public class DailycourierClient
    {
        #region Public Properties 

        /// <summary>
        /// The API key
        /// </summary>
        public string APIKey { get; }

        /// <summary>
        /// A flag indicating whether the test environment should be used or not
        /// </summary>
        public bool ShouldUseTestEnvironment { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public DailycourierClient(string apiKey, bool shouldUseTestEnvironment) : base()
        {
            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentException($"'{nameof(apiKey)}' cannot be null or empty.", nameof(apiKey));
            }

            APIKey = apiKey;

            ShouldUseTestEnvironment = shouldUseTestEnvironment;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Creates a new shipment
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<CreateShipmentResponseModel>> CreateShipmentAsync(CreateShipmentRequestModel model)
        {
            var response = await WebRequestsClient.Instance.PostAsync<InternalCreateShipmentResponseModel>(APIRoutes.CreateShipmentRoute(ShouldUseTestEnvironment), model, APIKey);

            if (!response.IsSuccessful)
                return response.ToUnsuccessfulWebRequestResult<CreateShipmentResponseModel>();

            if (response.Result.Status != 200)
                return response.ToUnsuccessfulWebRequestResult<CreateShipmentResponseModel>(response.Result.Message);

            return response.ToSuccessfulWebRequestResult<CreateShipmentResponseModel>(x => x.Data);
        }

        /// <summary>
        /// Tracks the shipment with the specified <paramref name="shipmentNumber"/>
        /// </summary>
        /// <param name="shipmentNumber">The shipment number</param>
        /// <returns></returns>
        public async Task<WebRequestResult<ShipmentTrackingResponseModel>> GetShipmentTrackingAsync(string shipmentNumber)
        {
            var response = await WebRequestsClient.Instance.GetAsync<InternalShipmentTrackingResponseModel>(APIRoutes.GetShipmentTrackingRoute(ShouldUseTestEnvironment, shipmentNumber), APIKey);

            if (!response.IsSuccessful)
                return response.ToUnsuccessfulWebRequestResult<ShipmentTrackingResponseModel>();

            return response.ToSuccessfulWebRequestResult<ShipmentTrackingResponseModel>(x => x.Data);
        }

        /// <summary>
        /// Tracks multiple shipments
        /// </summary>
        /// <param name="model">The model</param>
        /// <returns></returns>
        public async Task<WebRequestResult<IEnumerable<ShipmentTrackingResponseModel>>> GetShipmentTrackingsAsync(ShipmentsRequestModel model)
        {
            var response = await WebRequestsClient.Instance.PostAsync<InternalShipmentTrackingsResponseModel>(APIRoutes.GetShipmentsTrackingRoute(ShouldUseTestEnvironment), model, APIKey);

            if (!response.IsSuccessful)
                return response.ToUnsuccessfulWebRequestResult<IEnumerable<ShipmentTrackingResponseModel>>();

            return response.ToSuccessfulWebRequestResult<IEnumerable<ShipmentTrackingResponseModel>>(x => x.Data);
        }

        /// <summary>
        /// Gets the shipment voucher of the shipment with the specified <paramref name="shipmentNumber"/>
        /// </summary>
        /// <param name="shipmentNumber">The shipment number</param>
        /// <param name="printType">The print type</param>
        /// <returns></returns>
        public async Task<WebRequestResult<ShipmentVoucherResponseModel>> GetShipmentVoucherAsync(string shipmentNumber, PrintType printType)
        {
            return await WebRequestsClient.Instance.GetAsync<ShipmentVoucherResponseModel>(APIRoutes.GetShipmentVoucherRoute(ShouldUseTestEnvironment, shipmentNumber, printType), APIKey);
        }

        ///// <summary>
        ///// Gets multiple shipment vouchers
        ///// </summary>
        ///// <param name="printType">The print type</param>
        ///// <param name="model">The model</param>
        ///// <returns></returns>
        //public async Task<WebRequestResult<IEnumerable<ShipmentVoucherResponseModel>>> GetShipmentVouchersAsync(PrintType printType, ShipmentsRequestModel model)
        //{
        //    return await WebRequestsClient.Instance.PostAsync<IEnumerable<ShipmentVoucherResponseModel>>(APIRoutes.GetShipmentVouchersRoute(ShouldUseTestEnvironment, printType), model, APIKey);
        //}

        #endregion
    }
}
