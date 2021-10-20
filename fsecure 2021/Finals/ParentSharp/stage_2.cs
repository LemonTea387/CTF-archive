// Warning: Some assembly references could not be resolved automatically. This might lead to incorrect decompilation of some parts,
// for ex. property getter/setter access. To get optimal decompilation results, please manually add the missing references to the list of loaded assemblies.

// /home/b1temy/CTF-archive/fsecure 2021/Finals/ParentSharp/stage_2.exe
// Baby_Sharp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// Global type: <Module>
// Architecture: x64
// Runtime: v4.0.30319
// Hash algorithm: SHA1

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;

[assembly: CompilationRelaxations(8)]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyTitle("Baby_Sharp")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Baby_Sharp")]
[assembly: AssemblyCopyright("Copyright ©  2020")]
[assembly: AssemblyTrademark("")]
[assembly: ComVisible(false)]
[assembly: Guid("fb606b60-dd42-4ac9-9e27-ccb67b7f829b")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: TargetFramework(".NETFramework,Version=v4.7.2", FrameworkDisplayName = ".NET Framework 4.7.2")]
[assembly: SecurityPermission(8, SkipVerification = true)]
[assembly: AssemblyVersion("1.0.0.0")]
[module: UnverifiableCode]
namespace Baby_Sharp
{
	public class Native
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

		[DllImport("kernel32.dll")]
		public static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);
	}
	public class shark_call
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate Native.NTSTATUS ascsasc(string FNFNFN, uint DADADA, uint SMSMSM, IntPtr SASASA, uint CDCDCD, uint FAFAFA, IntPtr TFTFTF);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		public delegate bool csaasczxc(IntPtr HFHFHF, byte[] LBLBLB, uint NBTW, out uint NBW, [In] ref NativeOverlapped OLOLOL);

		private static byte[] dada = new byte[17]
		{
			31, 249, 35, 98, 100, 19, 78, 84, 135, 102,
			221, 186, 35, 149, 197, 79, 242
		};

		public static byte[] cHalala(byte[] pwd, byte[] data)
		{
			int num = pwd.Length * 2 * 8;
			int[] array = new int[num];
			int[] array2 = new int[num];
			byte[] array3 = new byte[data.Length];
			int i;
			for (i = 0; i < num; i++)
			{
				array[i] = pwd[i % pwd.Length];
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
			for (; i < data.Length; i++)
			{
				num4++;
				num4 %= num;
				num2 += array2[num4];
				num2 %= num;
				int num3 = array2[num4];
				array2[num4] = array2[num2];
				array2[num2] = num3;
				int num5 = array2[(array2[num4] + array2[num2]) % num];
				array3[i] = (byte)(data[i] ^ num5);
			}
			return array3;
		}

		public static void cmr(IntPtr m, UIntPtr l, uint i)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			if (!Native.VirtualProtect(m, l, i, out var _))
			{
				throw new Win32Exception();
			}
		}

		public unsafe static void rktrkt(byte[] byby)
		{
			fixed (byte* ptr = byby)
			{
				IntPtr intPtr = (IntPtr)ptr;
				if (byby.Length > 32)
				{
					cmr(intPtr, (UIntPtr)(ulong)byby.Length, 64u);
					Marshal.WriteByte(intPtr, 9, 105);
					Marshal.WriteByte(intPtr, 5, 28);
					Marshal.WriteByte(intPtr, 2, 46);
					return;
				}
				cmr(intPtr, (UIntPtr)(ulong)byby.Length, 64u);
				Marshal.WriteByte(intPtr, 9, 98);
				Marshal.WriteByte(intPtr, 2, 45);
				Marshal.WriteByte(intPtr, 3, 103);
				Marshal.WriteByte(intPtr, 4, 108);
				Marshal.WriteByte(intPtr, 5, 43);
				Marshal.WriteByte(intPtr, 6, 94);
				Marshal.WriteByte(intPtr, 7, 100);
			}
		}

		public string Sharp(byte[] kay)
		{
			if (File.Exists(".\\MessageFromAuthor.txt"))
			{
				return "fsdududududucyberx is not the flag dududu";
			}
			rktrkt(dada);
			byte[] bytes = cHalala(kay, dada);
			return Encoding.UTF8.GetString(bytes);
		}

		public string dudu()
		{
			return "Baby Shark dududududu\nFind the mini shark dododododo\nFind the naugthy shark dadadadada\nNo author, instant win?\nNot so easy heh";
		}
	}
}
