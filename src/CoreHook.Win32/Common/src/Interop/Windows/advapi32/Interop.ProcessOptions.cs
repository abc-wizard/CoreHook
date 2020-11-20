
public partial class Interop
{
    public partial class Advapi32
    {
        public partial class SEPrivileges
        {
            public const uint SE_PRIVILEGE_DISABLED = 0;
            public const int SE_PRIVILEGE_ENABLED = 2;
        }

        public partial class PerfCounterOptions
        {
            public const int NtPerfCounterSizeLarge = 0x00000100;
        }

        public partial class ProcessOptions
        {
            public const int PROCESS_TERMINATE = 0x0001;
            public const int PROCESS_CREATE_THREAD = 0x0002;
            public const int PROCESS_VM_OPERATION = 0x0008;
            public const int PROCESS_VM_READ = 0x0010;
            public const int PROCESS_VM_WRITE = 0x0020;
            public const int PROCESS_SET_QUOTA = 0x0100;
            public const int PROCESS_SET_INFORMATION = 0x0200;
            public const int PROCESS_QUERY_INFORMATION = 0x0400;
            public const int PROCESS_QUERY_LIMITED_INFORMATION = 0x1000;
            public const int PROCESS_ALL_ACCESS = STANDARD_RIGHTS_REQUIRED | SYNCHRONIZE | 0xFFF;


            public const int STANDARD_RIGHTS_REQUIRED = 0x000F0000;
            public const int SYNCHRONIZE = 0x00100000;
        }

        public partial class RPCStatus
        {
            public const int RPC_S_SERVER_UNAVAILABLE = 1722;
            public const int RPC_S_CALL_FAILED = 1726;
        }

        public partial class WaitOptions
        {
            public const int WAIT_TIMEOUT = 0x00000102;
        }

        public partial class StartupInfoOptions
        {
            public const int STARTF_USESTDHANDLES = 0x00000100;
            public const int CREATE_UNICODE_ENVIRONMENT = 0x00000400;
            public const int CREATE_NO_WINDOW = 0x08000000;
            public const uint STATUS_INFO_LENGTH_MISMATCH = 0xC0000004;
        }
    }
}
