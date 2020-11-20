// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

public partial class Interop
{
    public partial class Kernel32
    {
        public partial class PipeOptions
        {
            public const int PIPE_ACCESS_INBOUND = 1;
            public const int PIPE_ACCESS_OUTBOUND = 2;
            public const int PIPE_ACCESS_DUPLEX = 3;
            public const int PIPE_TYPE_BYTE = 0;
            public const int PIPE_TYPE_MESSAGE = 4;
            public const int PIPE_READMODE_BYTE = 0;
            public const int PIPE_READMODE_MESSAGE = 2;
            public const int PIPE_UNLIMITED_INSTANCES = 255;
        }
    }
}