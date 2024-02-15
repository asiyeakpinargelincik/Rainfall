using Newtonsoft.Json.Linq;
using NUnit.Framework;
using RestSharp;
using System;
using Google.Protobuf.WellKnownTypes;
using Method = RestSharp.Method;

namespace Rainfall.Services
{

    public class SizeLimit
    {
        private string baseURI = "http://environment.data.gov.uk/flood-monitoring";
        private RestResponse response;

        public void GetMeasurementWithSizeLimit(string stationId, string parameterName, int size)
        {
            var client = new RestClient(baseURI);
            var request = new RestRequest($"/id/stations/{stationId}/readings", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("parameter", parameterName);
            request.AddParameter("_limit", size);
            
            response = (RestResponse)client.Execute<RestResponse>(request);
            Console.WriteLine(response.Content); // Print response for debugging
        }

        public void VerifyStatusCode(int statusCode)
        {
            Assert.AreEqual(statusCode, (int)response.StatusCode);
        }

        public void VerifySizeLimit(int size)
        {
            var jsonResponse = JObject.Parse(response.Content);
            Assert.AreEqual(size, (int)jsonResponse["meta"]["limit"]);
        }
        
        

        public void CheckItemsSize(int itemSize)
        {
            var jsonResponse = JObject.Parse(response.Content);
            Assert.AreEqual(itemSize, jsonResponse["items"].Count());
        }
    }
}