// Decompiled with JetBrains decompiler
// Type: <CrtImplementationDetails>.ModuleLoadException
// Assembly: HIDBootLoader, Version=1.0.4350.28629, Culture=neutral, PublicKeyToken=null
// MVID: C2ABEB73-C84E-41BA-807E-B4913B3F1A22
// Assembly location: C:\Temp\SaveDongle Firmware Uploader.exe

using System;
using System.Runtime.Serialization;

namespace <CrtImplementationDetails>
{
  [Serializable]
  internal class ModuleLoadException : System.Exception
  {
    public const string Nested = "A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n";

    protected ModuleLoadException(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public ModuleLoadException(string message, System.Exception innerException)
      : base(message, innerException)
    {
    }

    public ModuleLoadException(string message)
      : base(message)
    {
    }
  }
}
