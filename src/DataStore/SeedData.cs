using Microsoft.EntityFrameworkCore;
using blackfinch_test.DataStore.Entities;

namespace blackfinch_test.DataStore;

public static class Seed
{
	public static ModelBuilder InitialDataSeed(this ModelBuilder modelBuilder)
	{
		// Seed initial user data
		modelBuilder.Entity<User>().HasData(
			new User
			{
				Id = 1,
				Email = "userA@test.com",
				Name = "Joe Bloggs",
				Address = "5 Ham Drive",
				CreditScore = 581
			},
			new User
			{
				Id = 2,
				Email = "userB@test.com",
				Name = "Jane Smith",
				Address = "12 Oak Lane",
				CreditScore = 720
			},
			new User
			{
				Id = 3,
				Email = "userC@test.com",
				Name = "Alice Johnson",
				Address = "33 Maple Street",
				CreditScore = 650
			},
			new User
			{
				Id = 4,
				Email = "userD@test.com",
				Name = "Bob Brown",
				Address = "7 Pine Avenue",
				CreditScore = 590
			},
			new User
			{
				Id = 5,
				Email = "userE@test.com",
				Name = "Charlie Green",
				Address = "21 Elm Road",
				CreditScore = 705
			},
			new User
			{
				Id = 6,
				Email = "userF@test.com",
				Name = "Diana White",
				Address = "14 Cedar Court",
				CreditScore = 630
			}
		);

		modelBuilder.Entity<Application>().HasData(
			new Application
			{
				Id = 1,
				AccountId = 1,
				LoanAmount = 1205000,       // 1,205,000
				CollateralAssetValue = 2500
			},
			new Application
			{
				Id = 2,
				AccountId = 4,
				LoanAmount = 150000000,     // 150,000,000
				CollateralAssetValue = 100
			},
			new Application
			{
				Id = 3,
				AccountId = 2,
				LoanAmount = 150000001,     // 150,000,001
				CollateralAssetValue = 15000001
			},
			new Application
			{
				Id = 4,
				AccountId = 6,
				LoanAmount = 30000,         // 1,000,000
				CollateralAssetValue = 80000
			}
		);


		modelBuilder.Entity<Decision>().HasData(
			new Decision
			{
				ApplicationId = 3,
				IsApproved = false,
				SubmissionDate = DateTime.Now.AddMonths(-3),
				ApprovalDate = DateTime.Now
			}
		);

		return modelBuilder;
	}
}