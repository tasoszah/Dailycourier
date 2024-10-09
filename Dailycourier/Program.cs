using Dailycourier;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");

var jsonToDeserialize =
    """
    {
      "cod_amount": 1.00,
      "payment_type": "Μετρητά",
      "comments": "string",
      "collection_point_full_name": "TEST",
      "collection_point_phone": "+306983456781",
      "collection_point_address": "Park Lane 13",
      "collection_point_postal_code": "17676",
      "collection_point_email": "test@example.com",
      "delivery_point_full_name": "TEST",
      "delivery_point_phone": "+306984114756",
      "delivery_point_address": "Monart Av. 22",
      "delivery_point_postal_code": "17124",
      "delivery_point_email": "test@example.com",
      "return_shipment": 0
    }
    """;

var request = JsonConvert.DeserializeObject<CreateShipmentRequestModel>(jsonToDeserialize)!;

var token = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DailyCourierToken.txt"));

var client = new DailycourierClient(token, true);

var createResponse = await client.CreateShipmentAsync(request);
var createResponse2 = await client.CreateShipmentAsync(request);

if (!createResponse.IsSuccessful)
{
    // Show error

    return;
}

var trackResponse = await client.GetShipmentTrackingAsync(createResponse.Result.Number);

var multipleTracksResponse = await client.GetShipmentTrackingsAsync(new ShipmentsRequestModel() { ShipmentNumbers = new List<string>() { createResponse.Result.Number } });

//var vouchersResponse = await client.GetShipmentVouchersAsync(Dailycourier.PrintType.Waybill, new ShipmentsRequestModel() { ShipmentNumbers = new List<string>() { createResponse.Result.Number, createResponse2.Result.Number } });

var voucherResponse = await client.GetShipmentVoucherAsync(createResponse.Result.Number, PrintType.Invoice);



byte[] bytes = Convert.FromBase64String(voucherResponse.Result.Content);

File.WriteAllBytes(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "voucher.pdf"), bytes);

Console.ReadLine();
