namespace blackfinch_test;

public static class RoutingDefinitions
{
	/// <summary>
	/// Define names of acceptable commands
	/// </summary>
	public enum Commands
	{
		add,
		exit,
		get,
		help
	}

	/// <summary>
	/// For routing subsequent commands to a logical subset (IO)
	/// </summary>
	public enum RouteCommands
	{
		add,
		get
	}

	/// <summary>
	/// Defines a set of expected subcommands
	/// </summary>
	public enum SubCommands
	{
		application,
		avg,
		decision,
		total,
		user,
		wtd
	}
}