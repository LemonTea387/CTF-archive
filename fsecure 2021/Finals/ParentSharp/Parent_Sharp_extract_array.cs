// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.

// /home/b1temy/Desktop/FSecureFinals/ParentSharp/Parent_Sharp.exe
// Parent_Sharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// Global type: <Module>
// Entry point: Parent_Sharp.Program.Main
// Architecture: x64
// Runtime: v4.0.30319
// Hash algorithm: SHA1

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;

//[assembly: CompilationRelaxations(8)]
//[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
//[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
//[assembly: AssemblyTitle("Parent_Sharp")]
//[assembly: AssemblyDescription("")]
//[assembly: AssemblyConfiguration("")]
//[assembly: AssemblyCompany("")]
//[assembly: AssemblyProduct("Parent_Sharp")]
//[assembly: AssemblyCopyright("Copyright ©  2020")]
//[assembly: AssemblyTrademark("")]
//[assembly: ComVisible(false)]
//[assembly: Guid("3fa909ab-b0c6-430f-a0d5-698d12c1284b")]
//[assembly: AssemblyFileVersion("1.0.0.0")]
//[assembly: TargetFramework(".NETFramework,Version=v4.7.2", FrameworkDisplayName = ".NET Framework 4.7.2")]
//[assembly: SecurityPermission(8, SkipVerification = true)]
//[assembly: AssemblyVersion("1.0.0.0")]
//[module: UnverifiableCode]
namespace Parent_Sharp
{
	internal class bsd
	{
		private char[] source;

		private int length;

		private int length2;

		private int length3;

		private int blockCount;

		private int paddingCount;

		public bsd(char[] input)
		{
			int num = 0;
			source = input;
			length = input.Length;
			for (int i = 0; i < 2; i++)
			{
				if (input[length - i - 1] == '=')
				{
					num++;
				}
			}
			paddingCount = num;
			blockCount = length / 4;
			length2 = blockCount * 3;
		}

		public byte[] gdgdgd()
		{
			byte[] array = new byte[length];
			byte[] array2 = new byte[length2];
			for (int i = 0; i < length; i++)
			{
				array[i] = c2sb(source[i]);
			}
			for (int j = 0; j < blockCount; j++)
			{
				byte b = array[j * 4];
				byte b2 = array[j * 4 + 1];
				byte b3 = array[j * 4 + 2];
				byte num = array[j * 4 + 3];
				byte b4 = (byte)(b << 2);
				byte b5 = (byte)((b2 & 0x30) >> 4);
				b5 = (byte)(b5 + b4);
				b4 = (byte)((b2 & 0xF) << 4);
				byte b6 = (byte)((b3 & 0x3C) >> 2);
				b6 = (byte)(b6 + b4);
				b4 = (byte)((b3 & 3) << 6);
				byte b7 = num;
				b7 = (byte)(b7 + b4);
				array2[j * 3] = b5;
				array2[j * 3 + 1] = b6;
				array2[j * 3 + 2] = b7;
			}
			length3 = length2 - paddingCount;
			byte[] array3 = new byte[length3];
			for (int k = 0; k < length3; k++)
			{
				array3[k] = array2[k];
			}
			return array3;
		}

		private byte c2sb(char c)
		{
			char[] array = KJASD.lol();
			if (c == '=')
			{
				return 0;
			}
			for (int i = 0; i < 64; i++)
			{
				if (array[i] == c)
				{
					return (byte)i;
				}
			}
			return 0;
		}
	}
	internal class hululu
	{
		private static int[] s = new int[64]
		{
			7, 12, 17, 22, 7, 12, 17, 22, 7, 12,
			17, 22, 7, 12, 17, 22, 5, 9, 14, 20,
			5, 9, 14, 20, 5, 9, 14, 20, 5, 9,
			14, 20, 4, 11, 16, 23, 4, 11, 16, 23,
			4, 11, 16, 23, 4, 11, 16, 23, 6, 10,
			15, 21, 6, 10, 15, 21, 6, 10, 15, 21,
			6, 10, 15, 21
		};

		private static uint[] K = new uint[64]
		{
			3614090360u, 3905402710u, 606105819u, 3250441966u, 4118548399u, 1200080426u, 2821735955u, 4249261313u, 1770035416u, 2336552879u,
			4294925233u, 2304563134u, 1804603682u, 4254626195u, 2792965006u, 1236535329u, 4129170786u, 3225465664u, 643717713u, 3921069994u,
			3593408605u, 38016083u, 3634488961u, 3889429448u, 568446438u, 3275163606u, 4107603335u, 1163531501u, 2850285829u, 4243563512u,
			1735328473u, 2368359562u, 4294588738u, 2272392833u, 1839030562u, 4259657740u, 2763975236u, 1272893353u, 4139469664u, 3200236656u,
			681279174u, 3936430074u, 3572445317u, 76029189u, 3654602809u, 3873151461u, 530742520u, 3299628645u, 4096336452u, 1126891415u,
			2878612391u, 4237533241u, 1700485571u, 2399980690u, 4293915773u, 2240044497u, 1873313359u, 4264355552u, 2734768916u, 1309151649u,
			4149444226u, 3174756917u, 718787259u, 3951481745u
		};

		private static int hmm = 256;

		public static uint leftRotate(uint x, int c)
		{
			return (x << c) | (x >> 32 - c);
		}

		public static string cHululu(byte[] input)
		{
			uint num = 1732584193u;
			uint num2 = 4023233417u;
			uint num3 = 2562383102u;
			uint num4 = 271733878u;
			int num5 = (56 - (input.Length + 1) % 64) % 64;
			byte[] array = new byte[input.Length + 1 + num5 + 8];
			KJASD.tkrtkr(input);
			Array.Copy(input, array, input.Length);
			array[input.Length] = 128;
			Array.Copy(BitConverter.GetBytes(input.Length * 8), 0, array, array.Length - 8, 4);
			for (int i = 0; i < array.Length / 64; i++)
			{
				uint[] array2 = new uint[16];
				for (int j = 0; j < 16; j++)
				{
					array2[j] = BitConverter.ToUInt32(array, i * 64 + j * 4);
				}
				uint num6 = num;
				uint num7 = num2;
				uint num8 = num3;
				uint num9 = num4;
				uint num10 = 0u;
				uint num11 = 0u;
				uint num12 = 0u;
				while (true)
				{
					switch (num12)
					{
					case 0u:
					case 1u:
					case 2u:
					case 3u:
					case 4u:
					case 5u:
					case 6u:
					case 7u:
					case 8u:
					case 9u:
					case 10u:
					case 11u:
					case 12u:
					case 13u:
					case 14u:
					case 15u:
						num10 = (num7 & num8) | (~num7 & num9);
						num11 = num12;
						goto IL_013e;
					case 16u:
					case 17u:
					case 18u:
					case 19u:
					case 20u:
					case 21u:
					case 22u:
					case 23u:
					case 24u:
					case 25u:
					case 26u:
					case 27u:
					case 28u:
					case 29u:
					case 30u:
					case 31u:
					case 32u:
					case 33u:
					case 34u:
					case 35u:
					case 36u:
					case 37u:
					case 38u:
					case 39u:
					case 40u:
					case 41u:
					case 42u:
					case 43u:
					case 44u:
					case 45u:
					case 46u:
					case 47u:
					case 48u:
					case 49u:
					case 50u:
					case 51u:
					case 52u:
					case 53u:
					case 54u:
					case 55u:
					case 56u:
					case 57u:
					case 58u:
					case 59u:
					case 60u:
					case 61u:
					case 62u:
					case 63u:
						if (num12 >= 16 && num12 <= 31)
						{
							num10 = (num9 & num7) | (~num9 & num8);
							num11 = (5 * num12 + 1) % 16u;
						}
						else if (num12 >= 32 && num12 <= 47)
						{
							num10 = num7 ^ num8 ^ num9;
							num11 = (3 * num12 + 5) % 16u;
						}
						else if (num12 >= 48)
						{
							num10 = num8 ^ (num7 | ~num9);
							num11 = 7 * num12 % 16u;
						}
						goto IL_013e;
					}
					break;
					IL_013e:
					uint num13 = num9;
					num9 = num8;
					num8 = num7;
					num7 += leftRotate(num6 + num10 + K[num12] + array2[num11], s[num12]);
					num6 = num13;
					num12++;
				}
				num += num6;
				num2 += num7;
				num3 += num8;
				num4 += num9;
			}
			return GetByteString(num) + GetByteString(num2) + GetByteString(num3) + GetByteString(num4);
		}

		private static string GetByteString(uint x)
		{
			return string.Join("", Enumerable.Select<byte, string>((IEnumerable<byte>)BitConverter.GetBytes(x), (Func<byte, string>)((byte y) => y.ToString("x2"))));
		}

		public static byte[] STBA(string hex)
		{
			return Enumerable.ToArray<byte>(Enumerable.Select<int, byte>(Enumerable.Where<int>(Enumerable.Range(0, hex.Length), (Func<int, bool>)((int x) => x % 2 == 0)), (Func<int, byte>)((int x) => Convert.ToByte(hex.Substring(x, 2), 16))));
		}

		public static byte[] cHalala(byte[] pwd, byte[] data)
		{
			int[] array = new int[hmm];
			int[] array2 = new int[hmm];
			byte[] array3 = new byte[data.Length];
			int i;
			for (i = 0; i < hmm; i++)
			{
				array[i] = pwd[i % pwd.Length];
				array2[i] = i;
			}
			int num = (i = 0);
			for (; i < hmm; i++)
			{
				num = (num + array2[i] + array[i]) % hmm;
				int num2 = array2[i];
				array2[i] = array2[num];
				array2[num] = num2;
			}
			int num3 = (num = (i = 0));
			for (; i < data.Length; i++)
			{
				num3++;
				num3 %= hmm;
				num += array2[num3];
				num %= hmm;
				int num2 = array2[num3];
				array2[num3] = array2[num];
				array2[num] = num2;
				int num4 = array2[(array2[num3] + array2[num]) % hmm];
				array3[i] = (byte)(data[i] ^ num4);
			}
			return array3;
		}

		public static byte[] Decrypt(byte[] pwd, byte[] data)
		{
			return cHalala(pwd, data);
		}
	}
	internal class KJASD
	{
		public static byte[] Compress(byte[] data)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Expected O, but got Unknown
			MemoryStream memoryStream = new MemoryStream();
			DeflateStream val = new DeflateStream((Stream)memoryStream, (CompressionLevel)0);
			try
			{
				((Stream)(object)val).Write(data, 0, data.Length);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return memoryStream.ToArray();
		}

		public static byte[] Decompress(byte[] data)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			MemoryStream memoryStream = new MemoryStream(data);
			MemoryStream memoryStream2 = new MemoryStream();
			DeflateStream val = new DeflateStream((Stream)memoryStream, (CompressionMode)0);
			try
			{
				((Stream)(object)val).CopyTo((Stream)memoryStream2);
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			return memoryStream2.ToArray();
		}

		public static void cMR(IntPtr m, UIntPtr l, uint i)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			if (!Native.VirtualProtect(m, l, i, out var _))
			{
				throw new Win32Exception();
			}
		}

		public unsafe static void tkrtkr(byte[] byby)
		{
			byte[] array = new byte[1] { 51 };
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			byte[] array2 = new byte[num2];
			for (int i = 0; i < num2; i++)
			{
				if (i < num)
				{
					array2[i] = array[i];
				}
				else
				{
					array2[i] = 0;
				}
			}
			byte[] array3 = new byte[num3 * 4];
			_ = new char[num3 * 4];
			for (int j = 0; j < num3; j++)
			{
				byte b = array2[j * 3];
				byte b2 = array2[j * 3 + 1];
				byte num4 = array2[j * 3 + 2];
				byte b3 = (byte)((b & 0xFC) >> 2);
				byte b4 = (byte)((b & 3) << 4);
				byte b5 = (byte)((b2 & 0xF0) >> 4);
				b5 = (byte)(b5 + b4);
				b4 = (byte)((b2 & 0xF) << 2);
				byte b6 = (byte)((num4 & 0xC0) >> 6);
				b6 = (byte)(b6 + b4);
				byte b7 = (byte)(num4 & 0x3Fu);
				array3[j * 4] = b3;
				array3[j * 4 + 1] = b5;
				array3[j * 4 + 2] = b6;
				array3[j * 4 + 3] = b7;
			}
			fixed (byte* ptr = byby)
			{
				IntPtr intPtr = (IntPtr)ptr;
				cMR(intPtr, (UIntPtr)(ulong)byby.Length, 64u);
				Marshal.WriteByte(intPtr, 5, 58);
			}
		}

		public static char[] lol()
		{
			char[] array = new char[64];
			char[] array2 = new char[64];
			int num = 0;
			for (int i = 65; i <= 90; i++)
			{
				array[num] = Convert.ToChar(i);
				num++;
			}
			for (int j = 97; j <= 122; j++)
			{
				array[num] = Convert.ToChar(j);
				num++;
			}
			for (int k = 48; k <= 57; k++)
			{
				array[num] = Convert.ToChar(k);
				num++;
			}
			array[num] = Convert.ToChar(43);
			array[num + 1] = Convert.ToChar(47);
			for (int l = 0; l < array.Length; l++)
			{
				array2[l] = array[array.Length - l - 1];
			}
			return array2;
		}

		public static byte[] cHalala(byte[] pwx, byte[] dada)
		{
			int num = 256;
			int[] array = new int[num];
			int[] array2 = new int[num];
			byte[] array3 = new byte[dada.Length];
			int i;
			for (i = 0; i < num; i++)
			{
				array[i] = pwx[i % pwx.Length];
				array2[i] = i;
			}
			int num2 = (i = 0);
			for (; i < num; i++)
			{
				num2 = (num2 + array2[i] + array[i]) % num;
				int num3 = array2[i];
				array2[i] = array2[num2];
				array2[num2] = num3;
			}
			int num4 = (num2 = (i = 0));
			for (; i < dada.Length; i++)
			{
				num4++;
				num4 %= num;
				num2 += array2[num4];
				num2 %= num;
				int num3 = array2[num4];
				array2[num4] = array2[num2];
				array2[num2] = num3;
				int num5 = array2[(array2[num4] + array2[num2]) % num];
				array3[i] = (byte)(dada[i] ^ num5);
			}
			return array3;
		}
	}
	internal class Native
	{
		public enum NTSTATUS : uint
		{
			Success = 0u,
			Wait0 = 0u,
			Wait1 = 1u,
			Wait2 = 2u,
			Wait3 = 3u,
			Wait63 = 0x3Fu,
			Abandoned = 0x80u,
			AbandonedWait0 = 0x80u,
			AbandonedWait1 = 129u,
			AbandonedWait2 = 130u,
			AbandonedWait3 = 131u,
			AbandonedWait63 = 191u,
			UserApc = 192u,
			KernelApc = 0x100u,
			Alerted = 257u,
			Timeout = 258u,
			Pending = 259u,
			Reparse = 260u,
			MoreEntries = 261u,
			NotAllAssigned = 262u,
			SomeNotMapped = 263u,
			OpLockBreakInProgress = 264u,
			VolumeMounted = 265u,
			RxActCommitted = 266u,
			NotifyCleanup = 267u,
			NotifyEnumDir = 268u,
			NoQuotasForAccount = 269u,
			PrimaryTransportConnectFailed = 270u,
			PageFaultTransition = 272u,
			PageFaultDemandZero = 273u,
			PageFaultCopyOnWrite = 274u,
			PageFaultGuardPage = 275u,
			PageFaultPagingFile = 276u,
			CrashDump = 278u,
			ReparseObject = 280u,
			NothingToTerminate = 290u,
			ProcessNotInJob = 291u,
			ProcessInJob = 292u,
			ProcessCloned = 297u,
			FileLockedWithOnlyReaders = 298u,
			FileLockedWithWriters = 299u,
			Informational = 0x40000000u,
			ObjectNameExists = 0x40000000u,
			ThreadWasSuspended = 1073741825u,
			WorkingSetLimitRange = 1073741826u,
			ImageNotAtBase = 1073741827u,
			RegistryRecovered = 1073741833u,
			Warning = 0x80000000u,
			GuardPageViolation = 2147483649u,
			DatatypeMisalignment = 2147483650u,
			Breakpoint = 2147483651u,
			SingleStep = 2147483652u,
			BufferOverflow = 2147483653u,
			NoMoreFiles = 2147483654u,
			HandlesClosed = 2147483658u,
			PartialCopy = 2147483661u,
			DeviceBusy = 2147483665u,
			InvalidEaName = 2147483667u,
			EaListInconsistent = 2147483668u,
			NoMoreEntries = 2147483674u,
			LongJump = 2147483686u,
			DllMightBeInsecure = 2147483691u,
			Error = 3221225472u,
			Unsuccessful = 3221225473u,
			NotImplemented = 3221225474u,
			InvalidInfoClass = 3221225475u,
			InfoLengthMismatch = 3221225476u,
			AccessViolation = 3221225477u,
			InPageError = 3221225478u,
			PagefileQuota = 3221225479u,
			InvalidHandle = 3221225480u,
			BadInitialStack = 3221225481u,
			BadInitialPc = 3221225482u,
			InvalidCid = 3221225483u,
			TimerNotCanceled = 3221225484u,
			InvalidParameter = 3221225485u,
			NoSuchDevice = 3221225486u,
			NoSuchFile = 3221225487u,
			InvalidDeviceRequest = 3221225488u,
			EndOfFile = 3221225489u,
			WrongVolume = 3221225490u,
			NoMediaInDevice = 3221225491u,
			NoMemory = 3221225495u,
			NotMappedView = 3221225497u,
			UnableToFreeVm = 3221225498u,
			UnableToDeleteSection = 3221225499u,
			IllegalInstruction = 3221225501u,
			AlreadyCommitted = 3221225505u,
			AccessDenied = 3221225506u,
			BufferTooSmall = 3221225507u,
			ObjectTypeMismatch = 3221225508u,
			NonContinuableException = 3221225509u,
			BadStack = 3221225512u,
			NotLocked = 3221225514u,
			NotCommitted = 3221225517u,
			InvalidParameterMix = 3221225520u,
			ObjectNameInvalid = 3221225523u,
			ObjectNameNotFound = 3221225524u,
			ObjectNameCollision = 3221225525u,
			ObjectPathInvalid = 3221225529u,
			ObjectPathNotFound = 3221225530u,
			ObjectPathSyntaxBad = 3221225531u,
			DataOverrun = 3221225532u,
			DataLate = 3221225533u,
			DataError = 3221225534u,
			CrcError = 3221225535u,
			SectionTooBig = 3221225536u,
			PortConnectionRefused = 3221225537u,
			InvalidPortHandle = 3221225538u,
			SharingViolation = 3221225539u,
			QuotaExceeded = 3221225540u,
			InvalidPageProtection = 3221225541u,
			MutantNotOwned = 3221225542u,
			SemaphoreLimitExceeded = 3221225543u,
			PortAlreadySet = 3221225544u,
			SectionNotImage = 3221225545u,
			SuspendCountExceeded = 3221225546u,
			ThreadIsTerminating = 3221225547u,
			BadWorkingSetLimit = 3221225548u,
			IncompatibleFileMap = 3221225549u,
			SectionProtection = 3221225550u,
			EasNotSupported = 3221225551u,
			EaTooLarge = 3221225552u,
			NonExistentEaEntry = 3221225553u,
			NoEasOnFile = 3221225554u,
			EaCorruptError = 3221225555u,
			FileLockConflict = 3221225556u,
			LockNotGranted = 3221225557u,
			DeletePending = 3221225558u,
			CtlFileNotSupported = 3221225559u,
			UnknownRevision = 3221225560u,
			RevisionMismatch = 3221225561u,
			InvalidOwner = 3221225562u,
			InvalidPrimaryGroup = 3221225563u,
			NoImpersonationToken = 3221225564u,
			CantDisableMandatory = 3221225565u,
			NoLogonServers = 3221225566u,
			NoSuchLogonSession = 3221225567u,
			NoSuchPrivilege = 3221225568u,
			PrivilegeNotHeld = 3221225569u,
			InvalidAccountName = 3221225570u,
			UserExists = 3221225571u,
			NoSuchUser = 3221225572u,
			GroupExists = 3221225573u,
			NoSuchGroup = 3221225574u,
			MemberInGroup = 3221225575u,
			MemberNotInGroup = 3221225576u,
			LastAdmin = 3221225577u,
			WrongPassword = 3221225578u,
			IllFormedPassword = 3221225579u,
			PasswordRestriction = 3221225580u,
			LogonFailure = 3221225581u,
			AccountRestriction = 3221225582u,
			InvalidLogonHours = 3221225583u,
			InvalidWorkstation = 3221225584u,
			PasswordExpired = 3221225585u,
			AccountDisabled = 3221225586u,
			NoneMapped = 3221225587u,
			TooManyLuidsRequested = 3221225588u,
			LuidsExhausted = 3221225589u,
			InvalidSubAuthority = 3221225590u,
			InvalidAcl = 3221225591u,
			InvalidSid = 3221225592u,
			InvalidSecurityDescr = 3221225593u,
			ProcedureNotFound = 3221225594u,
			InvalidImageFormat = 3221225595u,
			NoToken = 3221225596u,
			BadInheritanceAcl = 3221225597u,
			RangeNotLocked = 3221225598u,
			DiskFull = 3221225599u,
			ServerDisabled = 3221225600u,
			ServerNotDisabled = 3221225601u,
			TooManyGuidsRequested = 3221225602u,
			GuidsExhausted = 3221225603u,
			InvalidIdAuthority = 3221225604u,
			AgentsExhausted = 3221225605u,
			InvalidVolumeLabel = 3221225606u,
			SectionNotExtended = 3221225607u,
			NotMappedData = 3221225608u,
			ResourceDataNotFound = 3221225609u,
			ResourceTypeNotFound = 3221225610u,
			ResourceNameNotFound = 3221225611u,
			ArrayBoundsExceeded = 3221225612u,
			FloatDenormalOperand = 3221225613u,
			FloatDivideByZero = 3221225614u,
			FloatInexactResult = 3221225615u,
			FloatInvalidOperation = 3221225616u,
			FloatOverflow = 3221225617u,
			FloatStackCheck = 3221225618u,
			FloatUnderflow = 3221225619u,
			IntegerDivideByZero = 3221225620u,
			IntegerOverflow = 3221225621u,
			PrivilegedInstruction = 3221225622u,
			TooManyPagingFiles = 3221225623u,
			FileInvalid = 3221225624u,
			InstanceNotAvailable = 3221225643u,
			PipeNotAvailable = 3221225644u,
			InvalidPipeState = 3221225645u,
			PipeBusy = 3221225646u,
			IllegalFunction = 3221225647u,
			PipeDisconnected = 3221225648u,
			PipeClosing = 3221225649u,
			PipeConnected = 3221225650u,
			PipeListening = 3221225651u,
			InvalidReadMode = 3221225652u,
			IoTimeout = 3221225653u,
			FileForcedClosed = 3221225654u,
			ProfilingNotStarted = 3221225655u,
			ProfilingNotStopped = 3221225656u,
			NotSameDevice = 3221225684u,
			FileRenamed = 3221225685u,
			CantWait = 3221225688u,
			PipeEmpty = 3221225689u,
			CantTerminateSelf = 3221225691u,
			InternalError = 3221225701u,
			InvalidParameter1 = 3221225711u,
			InvalidParameter2 = 3221225712u,
			InvalidParameter3 = 3221225713u,
			InvalidParameter4 = 3221225714u,
			InvalidParameter5 = 3221225715u,
			InvalidParameter6 = 3221225716u,
			InvalidParameter7 = 3221225717u,
			InvalidParameter8 = 3221225718u,
			InvalidParameter9 = 3221225719u,
			InvalidParameter10 = 3221225720u,
			InvalidParameter11 = 3221225721u,
			InvalidParameter12 = 3221225722u,
			MappedFileSizeZero = 3221225758u,
			TooManyOpenedFiles = 3221225759u,
			Cancelled = 3221225760u,
			CannotDelete = 3221225761u,
			InvalidComputerName = 3221225762u,
			FileDeleted = 3221225763u,
			SpecialAccount = 3221225764u,
			SpecialGroup = 3221225765u,
			SpecialUser = 3221225766u,
			MembersPrimaryGroup = 3221225767u,
			FileClosed = 3221225768u,
			TooManyThreads = 3221225769u,
			ThreadNotInProcess = 3221225770u,
			TokenAlreadyInUse = 3221225771u,
			PagefileQuotaExceeded = 3221225772u,
			CommitmentLimit = 3221225773u,
			InvalidImageLeFormat = 3221225774u,
			InvalidImageNotMz = 3221225775u,
			InvalidImageProtect = 3221225776u,
			InvalidImageWin16 = 3221225777u,
			LogonServer = 3221225778u,
			DifferenceAtDc = 3221225779u,
			SynchronizationRequired = 3221225780u,
			DllNotFound = 3221225781u,
			IoPrivilegeFailed = 3221225783u,
			OrdinalNotFound = 3221225784u,
			EntryPointNotFound = 3221225785u,
			ControlCExit = 3221225786u,
			PortNotSet = 3221226323u,
			DebuggerInactive = 3221226324u,
			CallbackBypass = 3221226755u,
			PortClosed = 3221227264u,
			MessageLost = 3221227265u,
			InvalidMessage = 3221227266u,
			RequestCanceled = 3221227267u,
			RecursiveDispatch = 3221227268u,
			LpcReceiveBufferExpected = 3221227269u,
			LpcInvalidConnectionUsage = 3221227270u,
			LpcRequestsNotAllowed = 3221227271u,
			ResourceInUse = 3221227272u,
			ProcessIsProtected = 3221227282u,
			VolumeDirty = 3221227526u,
			FileCheckedOut = 3221227777u,
			CheckOutRequired = 3221227778u,
			BadFileType = 3221227779u,
			FileTooLarge = 3221227780u,
			FormsAuthRequired = 3221227781u,
			VirusInfected = 3221227782u,
			VirusDeleted = 3221227783u,
			TransactionalConflict = 3222863873u,
			InvalidTransaction = 3222863874u,
			TransactionNotActive = 3222863875u,
			TmInitializationFailed = 3222863876u,
			RmNotActive = 3222863877u,
			RmMetadataCorrupt = 3222863878u,
			TransactionNotJoined = 3222863879u,
			DirectoryNotRm = 3222863880u,
			CouldNotResizeLog = 3222863881u,
			TransactionsUnsupportedRemote = 3222863882u,
			LogResizeInvalidSize = 3222863883u,
			RemoteFileVersionMismatch = 3222863884u,
			CrmProtocolAlreadyExists = 3222863887u,
			TransactionPropagationFailed = 3222863888u,
			CrmProtocolNotFound = 3222863889u,
			TransactionSuperiorExists = 3222863890u,
			TransactionRequestNotValid = 3222863891u,
			TransactionNotRequested = 3222863892u,
			TransactionAlreadyAborted = 3222863893u,
			TransactionAlreadyCommitted = 3222863894u,
			TransactionInvalidMarshallBuffer = 3222863895u,
			CurrentTransactionNotValid = 3222863896u,
			LogGrowthFailed = 3222863897u,
			ObjectNoLongerExists = 3222863905u,
			StreamMiniversionNotFound = 3222863906u,
			StreamMiniversionNotValid = 3222863907u,
			MiniversionInaccessibleFromSpecifiedTransaction = 3222863908u,
			CantOpenMiniversionWithModifyIntent = 3222863909u,
			CantCreateMoreStreamMiniversions = 3222863910u,
			HandleNoLongerValid = 3222863912u,
			NoTxfMetadata = 3222863913u,
			LogCorruptionDetected = 3222863920u,
			CantRecoverWithHandleOpen = 3222863921u,
			RmDisconnected = 3222863922u,
			EnlistmentNotSuperior = 3222863923u,
			RecoveryNotNeeded = 3222863924u,
			RmAlreadyStarted = 3222863925u,
			FileIdentityNotPersistent = 3222863926u,
			CantBreakTransactionalDependency = 3222863927u,
			CantCrossRmBoundary = 3222863928u,
			TxfDirNotEmpty = 3222863929u,
			IndoubtTransactionsExist = 3222863930u,
			TmVolatile = 3222863931u,
			RollbackTimerExpired = 3222863932u,
			TxfAttributeCorrupt = 3222863933u,
			EfsNotAllowedInTransaction = 3222863934u,
			TransactionalOpenNotAllowed = 3222863935u,
			TransactedMappingUnsupportedRemote = 3222863936u,
			TxfMetadataAlreadyPresent = 3222863937u,
			TransactionScopeCallbacksNotSet = 3222863938u,
			TransactionRequiredPromotion = 3222863939u,
			CannotExecuteFileInTransaction = 3222863940u,
			TransactionsNotFrozen = 3222863941u,
			MaximumNtStatus = uint.MaxValue
		}

		[Flags]
		public enum ACCESS_MASK : uint
		{
			DELETE = 0x10000u,
			READ_CONTROL = 0x20000u,
			WRITE_DAC = 0x40000u,
			WRITE_OWNER = 0x80000u,
			SYNCHRONIZE = 0x100000u,
			STANDARD_RIGHTS_REQUIRED = 0xF0000u,
			STANDARD_RIGHTS_READ = 0x20000u,
			STANDARD_RIGHTS_WRITE = 0x20000u,
			STANDARD_RIGHTS_EXECUTE = 0x20000u,
			STANDARD_RIGHTS_ALL = 0x1F0000u,
			SPECIFIC_RIGHTS_ALL = 0xFFFFu,
			ACCESS_SYSTEM_SECURITY = 0x1000000u,
			MAXIMUM_ALLOWED = 0x2000000u,
			GENERIC_READ = 0x80000000u,
			GENERIC_WRITE = 0x40000000u,
			GENERIC_EXECUTE = 0x20000000u,
			GENERIC_ALL = 0x10000000u,
			DESKTOP_READOBJECTS = 0x1u,
			DESKTOP_CREATEWINDOW = 0x2u,
			DESKTOP_CREATEMENU = 0x4u,
			DESKTOP_HOOKCONTROL = 0x8u,
			DESKTOP_JOURNALRECORD = 0x10u,
			DESKTOP_JOURNALPLAYBACK = 0x20u,
			DESKTOP_ENUMERATE = 0x40u,
			DESKTOP_WRITEOBJECTS = 0x80u,
			DESKTOP_SWITCHDESKTOP = 0x100u,
			WINSTA_ENUMDESKTOPS = 0x1u,
			WINSTA_READATTRIBUTES = 0x2u,
			WINSTA_ACCESSCLIPBOARD = 0x4u,
			WINSTA_CREATEDESKTOP = 0x8u,
			WINSTA_WRITEATTRIBUTES = 0x10u,
			WINSTA_ACCESSGLOBALATOMS = 0x20u,
			WINSTA_EXITWINDOWS = 0x40u,
			WINSTA_ENUMERATE = 0x100u,
			WINSTA_READSCREEN = 0x200u,
			WINSTA_ALL_ACCESS = 0x37Fu
		}

		[Flags]
		public enum FileAccess : uint
		{
			AccessSystemSecurity = 0x1000000u,
			MaximumAllowed = 0x2000000u,
			Delete = 0x10000u,
			ReadControl = 0x20000u,
			WriteDAC = 0x40000u,
			WriteOwner = 0x80000u,
			Synchronize = 0x100000u,
			StandardRightsRequired = 0xF0000u,
			StandardRightsRead = 0x20000u,
			StandardRightsWrite = 0x20000u,
			StandardRightsExecute = 0x20000u,
			StandardRightsAll = 0x1F0000u,
			SpecificRightsAll = 0xFFFFu,
			FILE_READ_DATA = 0x1u,
			FILE_LIST_DIRECTORY = 0x1u,
			FILE_WRITE_DATA = 0x2u,
			FILE_ADD_FILE = 0x2u,
			FILE_APPEND_DATA = 0x4u,
			FILE_ADD_SUBDIRECTORY = 0x4u,
			FILE_CREATE_PIPE_INSTANCE = 0x4u,
			FILE_READ_EA = 0x8u,
			FILE_WRITE_EA = 0x10u,
			FILE_EXECUTE = 0x20u,
			FILE_TRAVERSE = 0x20u,
			FILE_DELETE_CHILD = 0x40u,
			FILE_READ_ATTRIBUTES = 0x80u,
			FILE_WRITE_ATTRIBUTES = 0x100u,
			GenericRead = 0x80000000u,
			GenericWrite = 0x40000000u,
			GenericExecute = 0x20000000u,
			GenericAll = 0x10000000u,
			SPECIFIC_RIGHTS_ALL = 0xFFFFu,
			FILE_ALL_ACCESS = 0x1F01FFu,
			FILE_GENERIC_READ = 0x120089u,
			FILE_GENERIC_WRITE = 0x120116u,
			FILE_GENERIC_EXECUTE = 0x1200A0u
		}

		[Flags]
		public enum FileShare : uint
		{
			None = 0x0u,
			Read = 0x1u,
			Write = 0x2u,
			Delete = 0x4u
		}

		[Flags]
		internal enum CreationDisposition : uint
		{
			FILE_SUPERSEDE = 0x0u,
			FILE_OPEN = 0x1u,
			FILE_CREATE = 0x2u,
			FILE_OPEN_IF = 0x3u,
			FILE_OVERWRITE = 0x4u,
			FILE_OVERWRITE_IF = 0x5u
		}

		[Flags]
		public enum CreateOption : uint
		{
			FILE_WRITE_THROUGH = 0x2u,
			FILE_SEQUENTIAL_ONLY = 0x4u,
			FILE_NO_INTERMEDIATE_BUFFERING = 0x8u,
			FILE_SYNCHRONOUS_IO_NONALERT = 0x20u,
			FILE_RANDOM_ACCESS = 0x800u
		}

		[Flags]
		public enum FileAttributes : uint
		{
			ReadOnly = 0x1u,
			Hidden = 0x2u,
			System = 0x4u,
			Directory = 0x10u,
			Archive = 0x20u,
			Device = 0x40u,
			Normal = 0x80u,
			Temporary = 0x100u,
			SparseFile = 0x200u,
			ReparsePoint = 0x400u,
			Compressed = 0x800u,
			Offline = 0x1000u,
			NotContentIndexed = 0x2000u,
			Encrypted = 0x4000u,
			Write_Through = 0x80000000u,
			Overlapped = 0x40000000u,
			NoBuffering = 0x20000000u,
			RandomAccess = 0x10000000u,
			SequentialScan = 0x8000000u,
			DeleteOnClose = 0x4000000u,
			BackupSemantics = 0x2000000u,
			PosixSemantics = 0x1000000u,
			OpenReparsePoint = 0x200000u,
			OpenNoRecall = 0x100000u,
			FirstPipeInstance = 0x80000u
		}

		public enum AllocationProtect : uint
		{
			PAGE_EXECUTE = 0x10u,
			PAGE_EXECUTE_READ = 0x20u,
			PAGE_EXECUTE_READWRITE = 0x40u,
			PAGE_EXECUTE_WRITECOPY = 0x80u,
			PAGE_NOACCESS = 1u,
			PAGE_READONLY = 2u,
			PAGE_READWRITE = 4u,
			PAGE_WRITECOPY = 8u,
			PAGE_GUARD = 0x100u,
			PAGE_NOCACHE = 0x200u,
			PAGE_WRITECOMBINE = 0x400u
		}

		public struct IO_STATUS_BLOCK
		{
			public uint status;

			public IntPtr information;
		}

		public struct OBJECT_ATTRIBUTES
		{
			public int Length;

			public IntPtr RootDirectory;

			public IntPtr ObjectName;

			public uint Attributes;

			public IntPtr SecurityDescriptor;

			public IntPtr SecurityQualityOfService;
		}

		public struct UNICODE_STRING
		{
			public ushort Length;

			public ushort MaximumLength;

			public IntPtr Buffer;
		}

		public delegate bool EnumWindowsProc(IntPtr hwnd, IntPtr lParam);

		[DllImport("kernel32.dll")]
		public static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

		[DllImport("ntdll.dll")]
		public static extern void RtlInitUnicodeString(ref UNICODE_STRING DestinationString, [MarshalAs(UnmanagedType.LPWStr)] string SourceString);

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		private static extern int GetWindowText(IntPtr hWnd, StringBuilder strText, int maxCount);

		[DllImport("user32.dll", CharSet = CharSet.Unicode)]
		private static extern int GetWindowTextLength(IntPtr hWnd);

		[DllImport("user32.dll")]
		private static extern int EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

		[DllImport("kernel32.dll", EntryPoint = "LoadLibrary", SetLastError = true)]
		public static extern IntPtr KLKOKLKL(string xzxc);

		[DllImport("kernel32.dll", CharSet = CharSet.Ansi, EntryPoint = "GetProcAddress", ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr KMKLNBX(IntPtr asd, string xzxc);

		[DllImport("kernel32.dll", EntryPoint = "FreeLibrary", SetLastError = true)]
		public static extern bool JASDBASD(IntPtr asdasd);

		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool WriteFile(IntPtr hFile, byte[] lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, [In] ref NativeOverlapped lpOverlapped);

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseHandle(IntPtr hObject);

		[DllImport("kernel32.dll", EntryPoint = "IsDebuggerPresent", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool system_shark();
	}
	internal class Program
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate Native.NTSTATUS ascsasc(string FNFNFN, uint DADADA, uint SMSMSM, IntPtr SASASA, uint CDCDCD, uint FAFAFA, IntPtr TFTFTF);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate bool csaasczxc(IntPtr HFHFHF, byte[] LBLBLB, uint NBTW, out uint NBW, [In] ref NativeOverlapped OLOLOL);

		private static byte[] bsbsbs = new byte[6] { 58, 190, 90, 244, 190, 59 };

		public static readonly string app_location = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

		private unsafe static void Main(string[] args)
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			byte[] pwx = new byte[7] { 66, 105, 98, 105, 115, 117, 112 };
			byte[] dada = new byte[12]
			{
				168, 67, 19, 121, 221, 127, 192, 223, 162, 198,
				81, 12
			};
			byte[] dada2 = new byte[11]
			{
				128, 84, 4, 118, 204, 118, 181, 132, 224, 199,
				124
			};
			byte[] dada3 = new byte[23]
			{
				237, 122, 44, 114, 203, 96, 146, 138, 233, 228,
				79, 15, 17, 39, 254, 153, 47, 163, 114, 83,
				49, 18, 4
			};
			byte[] dada4 = new byte[39]
			{
				129, 71, 3, 110, 152, 64, 155, 140, 254, 201,
				29, 4, 19, 2, 228, 137, 40, 168, 111, 93,
				7, 11, 18, 69, 14, 150, 146, 76, 147, 125,
				214, 164, 5, 37, 211, 92, 249, 216, 199
			};
			Stopwatch val = new Stopwatch();
			string @string = Encoding.UTF8.GetString(KJASD.cHalala(pwx, dada));
			string string2 = Encoding.UTF8.GetString(KJASD.cHalala(pwx, dada2));
			string string3 = Encoding.UTF8.GetString(KJASD.cHalala(pwx, dada3));
			string string4 = Encoding.UTF8.GetString(KJASD.cHalala(pwx, dada4));
			IntPtr asd = Native.KLKOKLKL(@string);
			IntPtr intPtr = (IntPtr)(long)((ascsasc)Marshal.GetDelegateForFunctionPointer(Native.KMKLNBX(asd, string2), typeof(ascsasc)))(string3, 3221225472u, 2u, (IntPtr)(void*)null, 1u, 128u, (IntPtr)(void*)null);
			val.Start();
			try
			{
				byte[] dada5 = new byte[9] { 148, 84, 8, 99, 221, 85, 154, 129, 233 };
				string string5 = Encoding.UTF8.GetString(KJASD.cHalala(pwx, dada5));
				csaasczxc obj = (csaasczxc)Marshal.GetDelegateForFunctionPointer(Native.KMKLNBX(asd, string5), typeof(csaasczxc));
				NativeOverlapped OLOLOL = default(NativeOverlapped);
				obj(intPtr, Encoding.ASCII.GetBytes(string4), (uint)Encoding.ASCII.GetBytes(string4).Length, out var _, ref OLOLOL);
				Native.CloseHandle(intPtr);
			}
			catch (Exception)
			{
			}
			byte[] array = hululu.STBA(hululu.cHululu(bsbsbs));
            File.WriteAllBytes("./array.bin", array);
            
            return ;
            
		}
	}
}
