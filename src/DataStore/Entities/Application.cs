namespace blackfinch_test.DataStore.Entities;

public class Application
{
	public int Id { get; set; }
	public int AccountId { get; set; }
	public uint LoanAmount { get; set; }
	public int CollateralAssetValue { get; set; }
}