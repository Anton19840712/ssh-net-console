using Renci.SshNet;

namespace Remote;

class Program
{
	static void Main(string[] args)
	{
		var connectionInfo = new ConnectionInfo("192.168.100.4", "aa",
			new PasswordAuthenticationMethod("aa", "Ant67299"),
			new PrivateKeyAuthenticationMethod("rsa.key"));

		using var client = new SshClient(connectionInfo);
		client.Connect();

		//var isPathContains = client.WorkingDirectory.Contains("aa");
		//client.DeleteFile("/home/aa/test.sh");
		//client.RenameFile("/home/aa/test1.sh", "/home/aa/test32.sh");
		//var isExists = client.Exists("/home/aa/test32.sh");
		//var files = client.ListDirectory("/home/aa/");
		//foreach (var item in files)
		//{
		//	Console.WriteLine(item.Name);
		//}
		//var term = client.RunCommand("ls /home/aa");
		//string output = term.Result;
		//Console.WriteLine(output);
	}
}