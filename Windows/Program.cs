using Renci.SshNet;
using Renci.SshNet.Common;

class Program
{
	static void Main(string[] args)
	{
		var client = new SshClient("192.168.100.11", "Administrator", "Ant67");

		try
		{
			client.Connect();
			if (client.IsConnected)
			{
				var command = client.CreateCommand("net user Administrator Ant6729");
				var result = command.Execute();

				Console.WriteLine("Command Result: " + result);

				if (!string.IsNullOrEmpty(command.Error))
				{
					Console.WriteLine("Error: " + command.Error);
				}

				var modes = new Dictionary<TerminalModes, uint>();
				using (var stream = client.CreateShellStream("xterm", 255, 50, 800, 600, 1024, modes))
				{
					var Reader = new StreamReader(stream);
					var Writer = new StreamWriter(stream);

					Writer.AutoFlush = true;

					Writer.Write("net user Administrator Ant6729\n");
					Thread.Sleep(2000);
				}
			}
			else
			{
				Console.WriteLine("Unable to connect.");
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("Exception: " + ex.Message);
		}
		finally
		{
			client.Disconnect();
		}
	}
}
