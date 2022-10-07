using HelloWorldLibrary.BusinessLogic;

namespace UltimateHelloWorld;

public class App
{
	private readonly IMessages _messages;

	public App(IMessages messages)
	{
		_messages = messages ?? throw new ArgumentNullException(nameof(messages));
	}

	// UltimateHelloWorld.exe -lang=es
	public void Run(string[] args)
	{
		string lang = "en";

		for (int i = 0; i < args.Length; i++)
		{
			if (args[i].StartsWith("lang=", StringComparison.InvariantCultureIgnoreCase))
			{
				lang = args[i].Substring(5);
				break;
			}
		}

		string message = _messages.Greeting(lang);

		Console.WriteLine(message);
	}
}
