using CalculatorLib;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly Calculator cal;
        private int res;

        public CalculatorStepDefinitions(Calculator calculator)
        {
            cal = calculator;
        }


        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
           cal.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
           cal.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            res = cal.Add();
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            res = cal.Subtract();
        }       

        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            res = cal.Divide();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            res = cal.Multiply();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            res.Should().Be(result);
        }
    }
}