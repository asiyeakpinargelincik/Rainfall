namespace Rainfall.Steps;

[Binding]
public class LimitStepDefs
{
    [When(@"User send a GET request is made for an individual station ""(.*)"" for ""(.*)"" parameter with a limit parameter set to (.*)")]
    public void WhenUserSendAgetRequestIsMadeForAnIndividualStationForParameterWithALimitParameterSetTo(string p0, string rainfall, int p2)
    {
        
        
        
    }
    
    
    [Then(@"the response status code should be (.*)")]
    public void ThenTheResponseStatusCodeShouldBe(int p0)
    {
        
        
       
    }
    
    [Then(@"the API should respond with a list containing no more than (.*) rainfall measurements")]
    public void ThenTheApiShouldRespondWithAListContainingNoMoreThanRainfallMeasurements(int p0)
    {
        
        
        
    }
    
    

    [Then(@"each measurement should have (.*) relevant information")]
    public void ThenEachMeasurementShouldHaveRelevantInformation(int p0)
    {
        
        
       
    }


    
}