using Renci.SshNet;
using System;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace Test;
public class Program
{
	public static void Main()
	{
		var connectionInfo = new ConnectionInfo("192.168.100.4", "aa",
			new PasswordAuthenticationMethod("aa", "Ant67299"),
			new PrivateKeyAuthenticationMethod("rsa.key"));

		using var client = new SshClient(connectionInfo);
		client.Connect();
	}
}