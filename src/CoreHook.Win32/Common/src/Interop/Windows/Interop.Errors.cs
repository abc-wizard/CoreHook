
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

public partial class Interop
{
    // https://msdn.microsoft.com/en-us/library/windows/desktop/ms681382.aspx
    public partial class Errors
    {
        public const int ERROR_SUCCESS = 0x0;
        public const int ERROR_INVALID_FUNCTION = 0x1;
        public const int ERROR_FILE_NOT_FOUND = 0x2;
        public const int ERROR_PATH_NOT_FOUND = 0x3;
        public const int ERROR_ACCESS_DENIED = 0x5;
        public const int ERROR_INVALID_HANDLE = 0x6;
        public const int ERROR_NOT_ENOUGH_MEMORY = 0x8;
        public const int ERROR_INVALID_DATA = 0xD;
        public const int ERROR_INVALID_DRIVE = 0xF;
        public const int ERROR_NO_MORE_FILES = 0x12;
        public const int ERROR_NOT_READY = 0x15;
        public const int ERROR_BAD_COMMAND = 0x16;
        public const int ERROR_BAD_LENGTH = 0x18;
        public const int ERROR_SHARING_VIOLATION = 0x20;
        public const int ERROR_LOCK_VIOLATION = 0x21;
        public const int ERROR_HANDLE_EOF = 0x26;
        public const int ERROR_BAD_NETPATH = 0x35;
        public const int ERROR_NETWORK_ACCESS_DENIED = 0x41;
        public const int ERROR_BAD_NET_NAME = 0x43;
        public const int ERROR_FILE_EXISTS = 0x50;
        public const int ERROR_INVALID_PARAMETER = 0x57;
        public const int ERROR_BROKEN_PIPE = 0x6D;
        public const int ERROR_SEM_TIMEOUT = 0x79;
        public const int ERROR_CALL_NOT_IMPLEMENTED  = 0x78;
        public const int ERROR_INSUFFICIENT_BUFFER = 0x7A;
        public const int ERROR_INVALID_NAME = 0x7B;
        public const int ERROR_NEGATIVE_SEEK = 0x83;
        public const int ERROR_DIR_NOT_EMPTY = 0x91;
        public const int ERROR_BAD_PATHNAME = 0xA1;
        public const int ERROR_LOCK_FAILED = 0xA7;
        public const int ERROR_BUSY = 0xAA;
        public const int ERROR_ALREADY_EXISTS = 0xB7;
        public const int ERROR_BAD_EXE_FORMAT = 0xC1;
        public const int ERROR_ENVVAR_NOT_FOUND = 0xCB;
        public const int ERROR_FILENAME_EXCED_RANGE = 0xCE;
        public const int ERROR_EXE_MACHINE_TYPE_MISMATCH = 0xD8;
        public const int ERROR_PIPE_BUSY = 0xE7;
        public const int ERROR_NO_DATA = 0xE8;
        public const int ERROR_PIPE_NOT_CONNECTED = 0xE9;
        public const int ERROR_MORE_DATA = 0xEA;
        public const int ERROR_NO_MORE_ITEMS = 0x103;
        public const int ERROR_DIRECTORY = 0x10B;
        public const int ERROR_PARTIAL_COPY = 0x12B;
        public const int ERROR_ARITHMETIC_OVERFLOW = 0x216;
        public const int ERROR_PIPE_CONNECTED = 0x217;
        public const int ERROR_PIPE_LISTENING = 0x218;
        public const int ERROR_OPERATION_ABORTED = 0x3E3;
        public const int ERROR_IO_INCOMPLETE = 0x3E4;
        public const int ERROR_IO_PENDING = 0x3E5;
        public const int ERROR_NO_TOKEN = 0x3f0;
        public const int ERROR_DLL_INIT_FAILED = 0x45A;
        public const int ERROR_COUNTER_TIMEOUT = 0x461;
        public const int ERROR_NO_ASSOCIATION = 0x483;
        public const int ERROR_DDE_FAIL = 0x484;
        public const int ERROR_DLL_NOT_FOUND = 0x485;
        public const int ERROR_NOT_FOUND = 0x490;
        public const int ERROR_NETWORK_UNREACHABLE = 0x4CF;
        public const int ERROR_NON_ACCOUNT_SID = 0x4E9;
        public const int ERROR_NOT_ALL_ASSIGNED = 0x514;
        public const int ERROR_UNKNOWN_REVISION = 0x519;
        public const int ERROR_INVALID_OWNER = 0x51B;
        public const int ERROR_INVALID_PRIMARY_GROUP = 0x51C;
        public const int ERROR_NO_SUCH_PRIVILEGE = 0x521;
        public const int ERROR_PRIVILEGE_NOT_HELD = 0x522;
        public const int ERROR_INVALID_ACL = 0x538;
        public const int ERROR_INVALID_SECURITY_DESCR = 0x53A;
        public const int ERROR_INVALID_SID = 0x539;
        public const int ERROR_BAD_IMPERSONATION_LEVEL = 0x542;
        public const int ERROR_CANT_OPEN_ANONYMOUS = 0x543;
        public const int ERROR_NO_SECURITY_ON_OBJECT = 0x546;
        public const int ERROR_CLASS_ALREADY_EXISTS = 0x582;
        public const int ERROR_TRUSTED_RELATIONSHIP_FAILURE = 0x6FD;
        public const int ERROR_RESOURCE_LANG_NOT_FOUND = 0x717;
        public const int EFail = unchecked((int)0x80004005);
        public const int E_FILENOTFOUND = unchecked((int)0x80070002);
    }
}