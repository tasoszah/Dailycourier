// See https://aka.ms/new-console-template for more information

using Dailycourier;
using Newtonsoft.Json;
using System;

Console.WriteLine("Hello, World!");


var requestModel = new CreateShipmentRequestModel()
{
    PaymentType = PaymentType.Payment,
    CollectionPointAddress = "Zakinthou 35, Patra",
    CollectionPointPhone = new PhoneNumber(30, "6977594432"),
    CanReturnShipment = true,
    CODAmount = 34,
    CollectionPointEmail = "paplabros@gmail.com"
};

var json = JsonConvert.SerializeObject(requestModel, Formatting.Indented);

var jsonToDeserialize =
    """
    {
        "id": "9a31e785-f5fb-47e0-9ce0-abc1e41e5cba",
        "number": "2201773926",
        "status": "Aναμονή παραλαβής",
        "cod_amount": 16.67,
        "payment_type": "Μετρητά",
        "comments": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
        "collection_point_full_name": "Michael Walker",
        "collection_point_phone": "+306983456781",
        "collection_point_address": "Park Lane 13",
        "collection_point_postal_code": "17676",
        "collection_point_email": "sales@example.com",
        "delivery_point_full_name": "George Best",
        "delivery_point_phone": "+306984114756",
        "delivery_point_address": "Monart Av. 22",
        "delivery_point_postal_code": "17124",
        "delivery_point_email": "client@example.com",
        "return_shipment": true
    }
    """;

var response = JsonConvert.DeserializeObject<CreateShipmentResponseModel>(jsonToDeserialize);

var test = string.Empty;
