using System;
using System.Runtime.InteropServices;

namespace LPTMonitor
{
	public class PortAccess
	{
		[DllImport("inpout32.dll", EntryPoint="Out32")]
		public static extern void Output(int address, int value);

		[DllImport("inpout32.dll", EntryPoint="Inp32")]
		public static extern int Input(int address);
	}
}