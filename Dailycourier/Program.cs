// See https://aka.ms/new-console-template for more information

using Dailycourier;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

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

var converter = new PaymentTypeToStringJsonConverter();

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


var jsonToDeserialize2 =
    """
     {
      "data": [
        {
          "number": "2201773926",
          "collection_point_full_name": "Michael Walker",
          "delivery_point_full_name": "George Best",
          "delivery_point_address": "Monart Av. 22",
          "delivery_point_postal_code": "17124",
          "history": [
            {
              "status": "Aναμονή παραλαβής",
              "datetime": "05/03/2024 12:28",
              "updated_by": "Dailybot",
              "comments": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",
              "file": "https://track.dailycourier.gr/signature.jpg",
              "signature": "https://track.dailycourier.gr/signature.png"
            }
          ]
        },
        {
              "number": "12354123",
              "collection_point_full_name": "Michael Walker",
              "delivery_point_full_name": "George Best",
              "delivery_point_address": "Monart Av. 22",
              "delivery_point_postal_code": "17124",
              "history": [
                {
                  "status": "Aναμονή παραλαβής",
                  "datetime": "05/03/2024 12:28",
                  "updated_by": "Dailybot",
                  "comments": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",
                  "file": "https://track.dailycourier.gr/signature.jpg",
                  "signature": "https://track.dailycourier.gr/signature.png"
                }
              ]
        },
        {
              "number": "9856756896",
              "collection_point_full_name": "Michael Walker",
              "delivery_point_full_name": "George Best",
              "delivery_point_address": "Monart Av. 22",
              "delivery_point_postal_code": "17124",
              "history": [
                {
                  "status": "Aναμονή παραλαβής",
                  "datetime": "05/03/2024 12:28",
                  "updated_by": "Dailybot",
                  "comments": "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua",
                  "file": "https://track.dailycourier.gr/signature.jpg",
                  "signature": "https://track.dailycourier.gr/signature.png"
                }
              ]
            }
      ]
    }

    """;

//var response = JsonConvert.DeserializeObject<CreateShipmentResponseModel>(jsonToDeserialize);

var response = JsonConvert.DeserializeObject<ShipmentTrackingsResponseModel>(jsonToDeserialize2);

var s = response.ToString();

var test = string.Empty;


public class StaffMember
{
    #region Public Properties

    public string Username { get; }

    public string Password { get; }

    public string FirstName { get; }

    public string LastName { get; }

    public string Address { get; set; }

    #endregion

    #region Constructors

    /// <summary>
    /// Default constructor
    /// </summary>
    public StaffMember(string username, string password, string firstName, string lastName) : base()
    {
        if (string.IsNullOrEmpty(username))
        {
            throw new ArgumentException($"'{nameof(username)}' cannot be null or empty.", nameof(username));
        }

        if (string.IsNullOrEmpty(password))
        {
            throw new ArgumentException($"'{nameof(password)}' cannot be null or empty.", nameof(password));
        }

        if (string.IsNullOrEmpty(firstName))
        {
            throw new ArgumentException($"'{nameof(firstName)}' cannot be null or empty.", nameof(firstName));
        }

        if (string.IsNullOrEmpty(lastName))
        {
            throw new ArgumentException($"'{nameof(lastName)}' cannot be null or empty.", nameof(lastName));
        }

        Username = username;
        Password = password;
        FirstName = firstName;
        LastName = lastName;
    }

    #endregion
}