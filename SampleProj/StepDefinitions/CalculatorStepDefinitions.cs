using NUnit.Framework;

namespace SampleProj.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private int firstNumber, SecondNumber, Sum, difference;
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
          this.firstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            this.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            this.Sum = this.firstNumber + this.SecondNumber;
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            Assert.AreEqual(this.Sum, result);
        }

        [When(@"the second number is subtracted from the frist number")]
        public void WhenTheSecondNumberIsSubtractedFromTheFristNumber()
        {

            this.difference = this.firstNumber - this.SecondNumber;
        }

        [Then(@"the difference should be (.*)")]
        public void ThenTheDifferenceShouldBe(int result)
        {
            Assert.AreEqual(this.difference, result);  
        }

    }
}