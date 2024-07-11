using Renci.SshNet;
using Renci.SshNet.Common;

var client = new SshClient("192.168.100.9", "aa", "13");

client.Connect();
var element = client.IsConnected;

var modes = new Dictionary<TerminalModes, uint>();

using (var stream = client.CreateShellStream("xterm", 255, 50, 800, 600, 1024, modes))
{
	var Reader = new StreamReader(stream);
	var Writer = new StreamWriter(stream);

	Writer.AutoFlush = true;

	Writer.Write("passwd\n");
	Thread.Sleep(2000);
	Writer.Write("13\n");
	Thread.Sleep(2000);
	Writer.Write("Ant673014\n");
	Thread.Sleep(2000);
	Writer.Write("Ant673014\n");
}

client.Disconnect();

