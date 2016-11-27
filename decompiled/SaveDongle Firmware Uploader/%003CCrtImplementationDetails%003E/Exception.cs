// Decompiled with JetBrains decompiler
// Type: <CrtImplementationDetails>.Exception
// Assembly: HIDBootLoader, Version=1.0.4350.28629, Culture=neutral, PublicKeyToken=null
// MVID: C2ABEB73-C84E-41BA-807E-B4913B3F1A22
// Assembly location: C:\Temp\SaveDongle Firmware Uploader.exe

using System;
using System.Runtime.Serialization;

namespace \u003CCrtImplementationDetails\u003E
{
  [Serializable]
  internal class Exception : System.Exception
  {
    protected Exception(SerializationInfo info, StreamingContext context)
      : base(info, context)
    {
    }

    public Exception(string message, System.Exception innerException)
      : base(message, innerException)
    {
    }

    public Exception(string message)
      : base(message)
    {
    }
  }
}
