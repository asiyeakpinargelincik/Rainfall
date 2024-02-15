namespace Rainfall.Steps;

[Binding]
public class LimitStepDefs
{
    [Then(@"the response status code should be (.*)")]
    public void ThenTheResponseStatusCodeShouldBe(int p0)
    {
        ScenarioContext.StepIsPending();
    }
}