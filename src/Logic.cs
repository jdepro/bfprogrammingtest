namespace blackfinch_test;

public static class Logic
{
	public static bool IsWithinValueThreshold(int loanAmount)
		=> loanAmount >= 1000000 && loanAmount <= 1500000;

	public static bool IsAcceptableLTV(
		int loanAmount,
		int creditScore,
		int collateral
	)
	{
		// Fail-fast guard condition
		if (!IsWithinValueThreshold(loanAmount)) { return false; }

		// Calculate LTV: the loan amount as a percentage of the collateral
		// asset's value
		var ltv = (double)loanAmount / collateral * 100;

		// If the loan requested is greater than one million:
		if (loanAmount >= 1000000)
		{
			if (creditScore >= 950 && ltv <= 60)
			{
				return true;
			}

			return false;
		}

		// If the loan requested is greater than one million:
		var lowValue = false;

		// Only accept loans meeting these conditions
		if (ltv < 60 && creditScore >= 750) { lowValue = true; }
		if (ltv < 80 && creditScore >= 800) { lowValue = true; }
		if (ltv < 90 && creditScore >= 900) { lowValue = true; }

		return lowValue;
	}
}