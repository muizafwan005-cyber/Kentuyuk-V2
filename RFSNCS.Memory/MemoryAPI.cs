using System;
using System.Runtime.InteropServices;

namespace RFSNCS.Memory;

public class MemoryAPI
{
	[Flags]
	public enum ProcessAccessType
	{
		PROCESS_TERMINATE = 1,
		PROCESS_CREATE_THREAD = 2,
		PROCESS_SET_SESSIONID = 4,
		PROCESS_VM_OPERATION = 8,
		PROCESS_VM_READ = 0x10,
		PROCESS_VM_WRITE = 0x20,
		PROCESS_DUP_HANDLE = 0x40,
		PROCESS_CREATE_PROCESS = 0x80,
		PROCESS_SET_QUOTA = 0x100,
		PROCESS_SET_INFORMATION = 0x200,
		PROCESS_QUERY_INFORMATION = 0x400
	}

	public enum KeyModifier
	{
		None = 0,
		Alt = 1,
		Control = 2,
		Shift = 4,
		WinKey = 8
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr OpenProcess(uint dwDesiredAccess, bool bInheritHandle, uint dwProcessId);

	[DllImport("kernel32.dll")]
	public static extern int CloseHandle(IntPtr hObject);

	[DllImport("kernel32.dll")]
	public static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesRead);

	[DllImport("kernel32.dll")]
	public static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

	[DllImport("kernel32.dll")]
	public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] buffer, uint size, uint uint_2);

	[DllImport("user32.dll")]
	public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

	[DllImport("user32.dll")]
	public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, int int_10, uint uint_1, uint uint_2);
}
