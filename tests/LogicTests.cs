using System;
using Xunit;
using blackfinch_test;

namespace tests;

public class Test_BusinessLogic
{
	[Theory(DisplayName = "Test IsWithinValueThreshold")]
	[InlineData("Far Below Lower Threshold", 10, false)]
	[InlineData("Within Upper Threshold", 999999, false)]
	[InlineData("Within Upper Threshold", 1000000, true)]
	[InlineData("Within Upper Threshold", 1500000, true)]
	[InlineData("Exeeds Upper Threshold", 1500001, false)]
	[InlineData("Far Exceeds Upper Threshold", int.MaxValue, false)]
	public void Test_LoanAmountIsWithinValueThreshold(
		string desciption,
		int loanAmount,
		bool expectedResult
	)
	{
		// Arrange

		// Act
		var result = Logic.IsWithinValueThreshold(loanAmount);

		// Assert
		Assert.True(
			result == expectedResult,
			string.Format(
				"{0} - Expected {1} but got {2}",
				desciption,
				expectedResult,
				result
			)
		);
	}
}