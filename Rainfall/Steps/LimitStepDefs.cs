using NUnit.Framework;
using RestSharp;
using System;
using Rainfall.Services;
using TechTalk.SpecFlow;

namespace Rainfall.Steps
{
    [Binding]
    public class LimitStepDefs
    {
        private SizeLimit sizeLimit;

        public LimitStepDefs()
        {
            sizeLimit = new SizeLimit();
        }
        

        [When(
            @"User send a GET request is made for an individual station ""(.*)"" for ""(.*)"" parameter with a limit parameter set to (.*)")]
        public void WhenUserSendAgetRequestIsMadeForAnIndividualStationForParameterWithALimitParameterSetTo(string stationId,
            string rainfall, int limitSize)
        {

         sizeLimit.GetMeasurementWithSizeLimit(stationId,rainfall,limitSize);

        }
        
        [Then(@"the response status code should be (.*)")]
        public void ThenTheResponseStatusCodeShouldBe(int statusCode)
        {

         sizeLimit.VerifyStatusCode(statusCode);

        }

        [Then(@"the API should respond with a list containing no more than (.*) rainfall measurements")]
        public void ThenTheApiShouldRespondWithAListContainingNoMoreThanRainfallMeasurements(int limit)
        {
         sizeLimit.VerifySizeLimit(limit);
         
        }
        
        [Then(@"each measurement should have (.*) relevant information")]
        public void ThenEachMeasurementShouldHaveRelevantInformation(int itemsSize)
        {
         sizeLimit.CheckItemsSize(itemsSize);
         
        }



    }
}
