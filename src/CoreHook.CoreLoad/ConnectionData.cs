﻿using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Diagnostics;

namespace CoreHook.CoreLoad
{
    internal class ConnectionData
    {
        public enum ConnectionState
        {
            Invalid = 0,
            NoChannel = 1,
            Valid = int.MaxValue
        }

        /// <summary>
        /// Gets the state of the current <see cref="HostConnectionData"/>.
        /// </summary>
        public ConnectionState State { get; private set; }

        /// <summary>
        /// Gets the unmanaged data containing the pointer to the memory block containing <see cref="RemoteInfo"/>;
        /// </summary>
        public RemoteEntryInfo UnmanagedInfo { get; private set; }

        public ManagedRemoteInfo RemoteInfo { get; private set; }

        private ConnectionData()
        {
            State = ConnectionState.Invalid;
            RemoteInfo = null;
            UnmanagedInfo = null;
        }
        /// <summary>
        /// Loads <see cref="HostConnectionData"/> from the <see cref="IntPtr"/> specified.
        /// </summary>
        /// <param name="unmanagedInfoPointer"></param>
        public static ConnectionData LoadData(IntPtr unmanagedInfoPointer)
        {
            var data = new ConnectionData
            {
                State = ConnectionState.Valid,
                UnmanagedInfo = new RemoteEntryInfo()
            };
            try
            {
                // Get the unmanaged data
                Marshal.PtrToStructure(unmanagedInfoPointer, data.UnmanagedInfo);
                using (Stream passThruStream = new MemoryStream())
                {
                    byte[] passThruBytes = new byte[data.UnmanagedInfo.UserDataSize];
                    BinaryFormatter format = new BinaryFormatter();
                    // Workaround for deserialization when not using GAC registration
                    format.Binder = new AllowAllAssemblyVersionsDeserializationBinder();
                    Marshal.Copy(data.UnmanagedInfo.UserData, passThruBytes, 0, data.UnmanagedInfo.UserDataSize);
                    passThruStream.Write(passThruBytes, 0, passThruBytes.Length);
                    passThruStream.Position = 0;
                    data.RemoteInfo = (ManagedRemoteInfo)format.Deserialize(passThruStream);
                }
            }
            catch (Exception ExtInfo)
            {
                Debug.WriteLine(ExtInfo.ToString());
            }
            return data;
        }

    }
}