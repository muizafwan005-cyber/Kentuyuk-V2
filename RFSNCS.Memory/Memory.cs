using System;
using System.Diagnostics;

namespace RFSNCS.Memory;

public class Memory
{
	private Process m_ReadProcess = null;

	private IntPtr m_hProcess = IntPtr.Zero;

	public Process ReadProcess
	{
		get
		{
			return m_ReadProcess;
		}
		set
		{
			m_ReadProcess = value;
		}
	}

	public void Open()
	{
		m_hProcess = MemoryAPI.OpenProcess(56u, 1, (uint)m_ReadProcess.Id);
	}

	public void CloseHandle()
	{
		if (MemoryAPI.CloseHandle(m_hProcess) == 0)
		{
			throw new Exception("CloseHandle Failed");
		}
	}

	public byte[] Read(IntPtr MemoryAddress, uint bytesToRead, out int bytesRead)
	{
		byte[] array = new byte[bytesToRead];
		MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, array, bytesToRead, out var lpNumberOfBytesRead);
		bytesRead = lpNumberOfBytesRead.ToInt32();
		return array;
	}

	public byte[] PointerRead(IntPtr MemoryAddress, uint bytesToRead, int[] Offset, out int bytesRead)
	{
		int num = Offset.Length - 1;
		bytesRead = 0;
		byte[] array = new byte[4];
		int num2 = 0;
		IntPtr lpNumberOfBytesRead;
		if (num == 0)
		{
			MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, array, 4u, out lpNumberOfBytesRead);
			num2 = Addr.ToDec(Addr.Make(array)) + Offset[0];
			array = new byte[bytesToRead];
			MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)num2, array, bytesToRead, out lpNumberOfBytesRead);
			bytesRead = lpNumberOfBytesRead.ToInt32();
			return array;
		}
		for (int i = 0; i <= num; i++)
		{
			if (i == num)
			{
				MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)num2, array, 4u, out lpNumberOfBytesRead);
				num2 = Addr.ToDec(Addr.Make(array)) + Offset[i];
				array = new byte[bytesToRead];
				MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)num2, array, bytesToRead, out lpNumberOfBytesRead);
				bytesRead = lpNumberOfBytesRead.ToInt32();
				return array;
			}
			if (i == 0)
			{
				MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, array, 4u, out lpNumberOfBytesRead);
				num2 = Addr.ToDec(Addr.Make(array)) + Offset[1];
			}
			else
			{
				MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)num2, array, 4u, out lpNumberOfBytesRead);
				num2 = Addr.ToDec(Addr.Make(array)) + Offset[i];
			}
		}
		return array;
	}

	public void Write(IntPtr MemoryAddress, byte[] bytesToWrite, out int bytesWritten)
	{
		MemoryAPI.WriteProcessMemory(m_hProcess, MemoryAddress, bytesToWrite, (uint)bytesToWrite.Length, out var lpNumberOfBytesWritten);
		bytesWritten = lpNumberOfBytesWritten.ToInt32();
	}

	public void WriteWithString(IntPtr address, string stringWritten)
	{
		stringWritten = stringWritten.Replace(" ", "");
		int num = 0;
		int num2 = 0;
		byte[] array = new byte[stringWritten.Length / 2];
		for (int i = 0; (double)i < Math.Round((double)stringWritten.Length / 2.0); i++)
		{
			array[num] = Convert.ToByte("0x" + stringWritten.Substring(num2, 2), 16);
			num++;
			num2 += 2;
		}
		Write(address, array, out var _);
	}

	public string PointerWrite(IntPtr MemoryAddress, byte[] bytesToWrite, int[] Offset, out int bytesWritten)
	{
		int num = Offset.Length - 1;
		bytesWritten = 0;
		byte[] buffer = new byte[4];
		int num2 = 0;
		IntPtr lpNumberOfBytesRead;
		if (num == 0)
		{
			MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4u, out lpNumberOfBytesRead);
			num2 = Addr.ToDec(Addr.Make(buffer)) + Offset[0];
			MemoryAPI.WriteProcessMemory(m_hProcess, (IntPtr)num2, bytesToWrite, (uint)bytesToWrite.Length, out lpNumberOfBytesRead);
			bytesWritten = lpNumberOfBytesRead.ToInt32();
			return Addr.ToHex(num2);
		}
		for (int i = 0; i <= num; i++)
		{
			if (i == num)
			{
				MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)num2, buffer, 4u, out lpNumberOfBytesRead);
				num2 = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
				MemoryAPI.WriteProcessMemory(m_hProcess, (IntPtr)num2, bytesToWrite, (uint)bytesToWrite.Length, out lpNumberOfBytesRead);
				bytesWritten = lpNumberOfBytesRead.ToInt32();
				return Addr.ToHex(num2);
			}
			if (i == 0)
			{
				MemoryAPI.ReadProcessMemory(m_hProcess, MemoryAddress, buffer, 4u, out lpNumberOfBytesRead);
				num2 = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
			}
			else
			{
				MemoryAPI.ReadProcessMemory(m_hProcess, (IntPtr)num2, buffer, 4u, out lpNumberOfBytesRead);
				num2 = Addr.ToDec(Addr.Make(buffer)) + Offset[i];
			}
		}
		return Addr.ToHex(num2);
	}

	public static IntPtr VirtualAllocEx(IntPtr intptr_0, int int_10)
	{
		return MemoryAPI.VirtualAllocEx(intptr_0, IntPtr.Zero, int_10, 4096u, 64u);
	}

	public int PID()
	{
		return m_ReadProcess.Id;
	}

	public string BaseAddressH()
	{
		return Addr.ToHex(m_ReadProcess.MainModule.BaseAddress.ToInt32());
	}

	public int BaseAddressD()
	{
		return m_ReadProcess.MainModule.BaseAddress.ToInt32();
	}
}
