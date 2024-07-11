using Renci.SshNet;

namespace Remote;

class Program
{
	static void Main(string[] args)
	{
		//var connectionInfo = new ConnectionInfo("192.168.100.1", "Administrator",
		//	new PasswordAuthenticationMethod("Administrator", "Ant67")
		//	//,
		//	//new PrivateKeyAuthenticationMethod("rsa.key")
		//	);

		var connectionInfo = new ConnectionInfo("192.168.100.11", 22, "Administrator", new PasswordAuthenticationMethod("Administrator", "Ant67"));

		using var client = new SshClient(connectionInfo);

		client.Connect();

		var element = client.IsConnected;

		client.Disconnect();
	}
}