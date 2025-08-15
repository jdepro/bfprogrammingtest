using Microsoft.EntityFrameworkCore;
using blackfinch_test.DataStore;

namespace blackfinch_test;

class Program
{
	static void Main(string[] args)
	{
		var options = new DbContextOptionsBuilder<TempStorage>()
			.UseInMemoryDatabase("TestStore")
			.Options;
		using var derp = new TempStorage(options);
		var nl = Environment.NewLine;

		Console.WriteLine("Welcome!");

		var command = "";

		do
		{
			Console.WriteLine($"{nl}What would you like to do?");
			Console.WriteLine("\tOptions: [exit|help|add|get]");

			Console.Write("> ");
			command = Console.ReadLine() ?? string.Empty;
			var routecommand = GetSubCommand(command);

			switch (command.ToLowerInvariant())
			{
				case nameof(RoutingDefinitions.Commands.exit):
					return;
				case nameof(RoutingDefinitions.Commands.add):
					break;
				case nameof(RoutingDefinitions.Commands.get):
					break;
				default:
					DisplayHelp();
					break;
			}
		}
		while (command != "exit");
	}

	private static void DisplayHelp()
	{
		var nl = Environment.NewLine;

		Console.WriteLine($"add [user|application|decision]{nl}" +
			$"\tuser:\t\tWill prompt to add a new user account.{nl}" +
			$"\tapplication:\tWill prompt to add a new loan application.{nl}" +
			"\tdecision:\tWill prompt to save a loan decision."
		);

		Console.WriteLine($"get [decision|total|wtd|avg]{nl}" +
			$"\tdecision [id]:\tDisplays a loan decision for a loan ID.{nl}" +
			$"\ttotal:\t\tDisplays the total number of applicants to date{nl}" +
			$"\twtd:\t\tShows the total number of loans written to date{nl}" +
			$"\tavg:\t\tDisplays the mean average loan-to-value (LTV)"
		);
	}

	private static void DisplayCommandHelp()
	{
		var nl = Environment.NewLine;

	}



	/// <summary>
	/// Provides routing logic based on a user's coimmand input
	/// </summary>
	private static void ProcessCommand(string input)
	{
		var subcommand = GetSubCommand(input);


	}

	/// <summary>
	/// Extracts the subcommand from the user's input
	/// </summary>
	private static string GetSubCommand(string input)
	{
		if (string.IsNullOrWhiteSpace(input) || input.IndexOf(' ') <= 0)
		{
			return string.Empty;
		}

		return input[..(input.IndexOf(' ') + 1)];
	}
}
