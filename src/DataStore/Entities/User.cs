using System.ComponentModel.DataAnnotations;

namespace blackfinch_test.DataStore.Entities;

public class User
{
	public int Id { get; set; }
	public string Name { get; set; } = string.Empty;
	public string Email { get; set; } = string.Empty;
	public string Address { get; set; } = string.Empty;
	[Range(0, 999)]
	public int CreditScore { get; set; }
}