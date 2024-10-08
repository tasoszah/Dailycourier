using Dailycourier;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");



var token = File.ReadAllText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "DailyCourierToken.txt"));


var converter = new PaymentTypeToStringJsonConverter();

//var json = JsonConvert.SerializeObject(requestModel, Formatting.Indented);

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

CreateShipment(token, JsonConvert.DeserializeObject<CreateShipmentRequestModel>(jsonToDeserialize));

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

Console.ReadLine();

async void CreateShipment(string token, CreateShipmentRequestModel requestModel)
{
    //var httpClient = new HttpClient();
    //httpClient.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
    //httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
    var json = JsonConvert.SerializeObject(requestModel);

    //var content = new StringContent(json, Encoding.UTF8, "application/json");
    //var url = APIRoutes.CreateShipmentRoute(false);

    //var requestMessage = new HttpRequestMessage(HttpMethod.Post, url) 
    //{
    //    Content = content
    //};

    //var response = await httpClient.SendAsync(requestMessage);

    //var jsonResponse = await response.Content.ReadAsStringAsync();

    var client = new HttpClient();
    var request = new HttpRequestMessage
    {
        Method = HttpMethod.Post,
        RequestUri = new Uri(APIRoutes.CreateShipmentRoute(true)),
        Headers =
    {
        { "Accept", "application/json, application/xml, multipart/form-data" },
        { "Authorization", "Bearer " + token },
    },
        Content = new StringContent("{\n  \"cod_amount\": 18.67,\n  \"payment_type\": \"Μετρητά\",\n  \"comments\": \"string\",\n  \"collection_point_full_name\": \"Michael Walker\",\n  \"collection_point_phone\": \"+306983456781\",\n  \"collection_point_address\": \"Park Lane 13\",\n  \"collection_point_postal_code\": \"17676\",\n  \"collection_point_email\": \"sales@example.com\",\n  \"delivery_point_full_name\": \"George Best\",\n  \"delivery_point_phone\": \"+306984114756\",\n  \"delivery_point_address\": \"Monart Av. 22\",\n  \"delivery_point_postal_code\": \"17124\",\n  \"delivery_point_email\": \"client@example.com\",\n  \"return_shipment\": 0\n}") //new StringContent(json)
        {
            Headers =
        {
            ContentType = new MediaTypeHeaderValue("application/json")
        }
        }
    };
    using (var response = await client.SendAsync(request))
    {
        response.EnsureSuccessStatusCode();
        var body = await response.Content.ReadAsStringAsync();
        var result = JsonConvert.DeserializeObject<InteralCreateShipmentResponseModel>(body);
        Console.WriteLine(body);
    }

}
