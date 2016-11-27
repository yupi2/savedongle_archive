// Decompiled with JetBrains decompiler
// Type: <Module>
// Assembly: HIDBootLoader, Version=1.0.4350.28629, Culture=neutral, PublicKeyToken=null
// MVID: C2ABEB73-C84E-41BA-807E-B4913B3F1A22
// Assembly location: C:\Temp\SaveDongle Firmware Uploader.exe

using <CppImplementationDetails>;
using <CrtImplementationDetails>;
using HIDBootLoader;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Windows.Forms;
using vc_attributes;

internal class <Module>
{
  [FixedAddressValueType]
  internal static int ?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.?Uninitialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;
  internal static $ArrayType$$$BY00Q6MPBXXZ ?A0xfd8b67b9.__xi_vt_a;
  [FixedAddressValueType]
  internal static double ?A0xfd8b67b9._HUGE;
  [FixedAddressValueType]
  internal static AccessType ?A0xfd8b67b9.SA_Write;
  internal static __FnPtr<void ()> ?A0xfd8b67b9._HUGE$initializer$;
  [FixedAddressValueType]
  internal static Progress.State ?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.?InitializedPerAppDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;
  [FixedAddressValueType]
  internal static double ?A0xfd8b67b9.HUGE;
  [FixedAddressValueType]
  internal static AccessType ?A0xfd8b67b9.SA_NoAccess;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.SA_NoAccess$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0xfd8b67b9.SA_ReadWrite;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.SA_ReadWrite$initializer$;
  [FixedAddressValueType]
  internal static bool ?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.?IsDefaultDomain$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xfd8b67b9.SA_Yes;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.HUGE$initializer$;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.SA_Write$initializer$;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.SA_Yes$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xfd8b67b9.SA_Maybe;
  internal static $ArrayType$$$BY00Q6MPBXXZ ?A0xfd8b67b9.__xc_ma_a;
  [FixedAddressValueType]
  internal static AccessType ?A0xfd8b67b9.SA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xfd8b67b9.SA_No;
  [FixedAddressValueType]
  internal static Progress.State ?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.?InitializedNative$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;
  [FixedAddressValueType]
  internal static int ?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.?Initialized$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;
  internal static $ArrayType$$$BY00Q6MPBXXZ ?A0xfd8b67b9.__xc_ma_z;
  [FixedAddressValueType]
  internal static Progress.State ?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.?InitializedVtables$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.SA_Read$initializer$;
  internal static $ArrayType$$$BY00Q6MPBXXZ ?A0xfd8b67b9.__xi_vt_z;
  [FixedAddressValueType]
  internal static Progress.State ?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.?InitializedPerProcess$initializer$@CurrentDomain@<CrtImplementationDetails>@@$$Q2P6MXXZA;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.SA_Maybe$initializer$;
  internal static __FnPtr<void ()> ?A0xfd8b67b9.SA_No$initializer$;
  [FixedAddressValueType]
  internal static uint __exit_list_size_app_domain;
  [FixedAddressValueType]
  internal static unsafe __FnPtr<void ()>* __onexitbegin_app_domain;
  [FixedAddressValueType]
  internal static AccessType ?A0xc9f6eb9e.SA_Write;
  [FixedAddressValueType]
  internal static AccessType ?A0xc9f6eb9e.SA_NoAccess;
  internal static __FnPtr<void ()> ?A0xc9f6eb9e.SA_NoAccess$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0xc9f6eb9e.SA_ReadWrite;
  internal static __FnPtr<void ()> ?A0xc9f6eb9e.SA_ReadWrite$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xc9f6eb9e.SA_Yes;
  internal static __FnPtr<void ()> ?A0xc9f6eb9e.SA_Write$initializer$;
  internal static __FnPtr<void ()> ?A0xc9f6eb9e.SA_Yes$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xc9f6eb9e.SA_Maybe;
  [FixedAddressValueType]
  internal static unsafe __FnPtr<void ()>* __onexitend_app_domain;
  [FixedAddressValueType]
  internal static AccessType ?A0xc9f6eb9e.SA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xc9f6eb9e.SA_No;
  internal static __FnPtr<void ()> ?A0xc9f6eb9e.SA_Read$initializer$;
  [FixedAddressValueType]
  internal static unsafe void* ?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA;
  [FixedAddressValueType]
  internal static int ?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;
  internal static __FnPtr<void ()> ?A0xc9f6eb9e.SA_Maybe$initializer$;
  internal static __FnPtr<void ()> ?A0xc9f6eb9e.SA_No$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0x8bd98b91.SA_Write;
  [FixedAddressValueType]
  internal static AccessType ?A0x8bd98b91.SA_NoAccess;
  internal static __FnPtr<void ()> ?A0x8bd98b91.SA_NoAccess$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0x8bd98b91.SA_ReadWrite;
  internal static __FnPtr<void ()> ?A0x8bd98b91.SA_ReadWrite$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0x8bd98b91.SA_Yes;
  internal static __FnPtr<void ()> ?A0x8bd98b91.SA_Write$initializer$;
  internal static __FnPtr<void ()> ?A0x8bd98b91.SA_Yes$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0x8bd98b91.SA_Maybe;
  [FixedAddressValueType]
  internal static AccessType ?A0x8bd98b91.SA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0x8bd98b91.SA_No;
  internal static __FnPtr<void ()> ?A0x8bd98b91.SA_Read$initializer$;
  internal static __FnPtr<void ()> ?A0x8bd98b91.SA_Maybe$initializer$;
  internal static __FnPtr<void ()> ?A0x8bd98b91.SA_No$initializer$;
  internal static ??_C@_0BA@NOJDBDJO@?4?$DPAVtype_info?$EA?$EA?$AA@$$BY0A@$$CBD ??_C@_0BA@NOJDBDJO@?4?$DPAVtype_info?$EA?$EA?$AA@;
  [FixedAddressValueType]
  internal static $_s__RTTIBaseClassArray$_extraBytes_4 ??_R2type_info@@8;
  internal static __FnPtr<void ()> ?A0xbdc48617.??_R2type_info@@8$initializer$;
  [FixedAddressValueType]
  internal static _s__RTTICompleteObjectLocator ??_R4type_info@@6B@;
  internal static __FnPtr<void ()> ?A0xbdc48617.??_R4type_info@@6B@$initializer$;
  [FixedAddressValueType]
  internal static $ArrayType$$$BY01Q6MXXZ ??_7type_info@@6B@;
  [FixedAddressValueType]
  internal static AccessType ?A0xbdc48617.SA_Write;
  [FixedAddressValueType]
  internal static _s__RTTIClassHierarchyDescriptor ??_R3type_info@@8;
  [FixedAddressValueType]
  internal static AccessType ?A0xbdc48617.SA_NoAccess;
  internal static __FnPtr<void ()> ?A0xbdc48617.SA_NoAccess$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0xbdc48617.SA_ReadWrite;
  internal static __FnPtr<void ()> ?A0xbdc48617.SA_ReadWrite$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xbdc48617.SA_Yes;
  internal static __FnPtr<void ()> ?A0xbdc48617.SA_Write$initializer$;
  internal static __FnPtr<void ()> ?A0xbdc48617.SA_Yes$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xbdc48617.SA_Maybe;
  internal static __FnPtr<void ()> ?A0xbdc48617.??_R3type_info@@8$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0xbdc48617.SA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xbdc48617.SA_No;
  internal static __FnPtr<void ()> ?A0xbdc48617.SA_Read$initializer$;
  [FixedAddressValueType]
  internal static $_TypeDescriptor$_extraBytes_16 ??_R0?AVtype_info@@@8;
  internal static __FnPtr<void ()> ?A0xbdc48617.??_R0?AVtype_info@@@8$initializer$;
  internal static __FnPtr<void ()> ?A0xbdc48617.SA_Maybe$initializer$;
  internal static __FnPtr<void ()> ?A0xbdc48617.??_7type_info@@6B@$initializer$;
  internal static __FnPtr<void ()> ?A0xbdc48617.SA_No$initializer$;
  [FixedAddressValueType]
  internal static _s__RTTIBaseClassDescriptor2 ??_R1A@?0A@EA@type_info@@8;
  [FixedAddressValueType]
  internal static __type_info_node __type_info_root_node;
  internal static __FnPtr<void ()> ?A0xbdc48617.??_R1A@?0A@EA@type_info@@8$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0xb174b438.SA_Write;
  [FixedAddressValueType]
  internal static AccessType ?A0xb174b438.SA_NoAccess;
  internal static __FnPtr<void ()> ?A0xb174b438.SA_NoAccess$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0xb174b438.SA_ReadWrite;
  internal static __FnPtr<void ()> ?A0xb174b438.SA_ReadWrite$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xb174b438.SA_Yes;
  internal static __FnPtr<void ()> ?A0xb174b438.SA_Write$initializer$;
  internal static __FnPtr<void ()> ?A0xb174b438.SA_Yes$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xb174b438.SA_Maybe;
  [FixedAddressValueType]
  internal static AccessType ?A0xb174b438.SA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0xb174b438.SA_No;
  internal static __FnPtr<void ()> ?A0xb174b438.SA_Read$initializer$;
  internal static __FnPtr<void ()> ?A0xb174b438.SA_Maybe$initializer$;
  internal static __FnPtr<void ()> ?A0xb174b438.SA_No$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0x9536fa44.SA_Write;
  [FixedAddressValueType]
  internal static AccessType ?A0x9536fa44.SA_NoAccess;
  internal static __FnPtr<void ()> ?A0x9536fa44.SA_NoAccess$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0x9536fa44.SA_ReadWrite;
  internal static __FnPtr<void ()> ?A0x9536fa44.SA_ReadWrite$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0x9536fa44.SA_Yes;
  internal static __FnPtr<void ()> ?A0x9536fa44.SA_Write$initializer$;
  internal static __FnPtr<void ()> ?A0x9536fa44.SA_Yes$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0x9536fa44.SA_Maybe;
  [FixedAddressValueType]
  internal static AccessType ?A0x9536fa44.SA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0x9536fa44.SA_No;
  internal static __FnPtr<void ()> ?A0x9536fa44.SA_Read$initializer$;
  internal static __FnPtr<void ()> ?A0x9536fa44.SA_Maybe$initializer$;
  internal static __FnPtr<void ()> ?A0x9536fa44.SA_No$initializer$;
  internal static ??_C@_07BNLNPKOB@c?3?2Temp?$AA@$$BY0A@$$CBD ??_C@_07BNLNPKOB@c?3?2Temp?$AA@;
  internal static ??_C@_02GMLFBBN@wb?$AA@$$BY0A@$$CBD ??_C@_02GMLFBBN@wb?$AA@;
  internal static ??_C@_0BA@BJPDJJDH@c?3?2Temp?2tmp?4tmp?$AA@$$BY0A@$$CBD ??_C@_0BA@BJPDJJDH@c?3?2Temp?2tmp?4tmp?$AA@;
  internal static ??_C@_02JDPG@rb?$AA@$$BY0A@$$CBD ??_C@_02JDPG@rb?$AA@;
  internal static ??_C@_0L@BKPAMLJP@WriteEvent?$AA@$$BY0A@$$CBD ??_C@_0L@BKPAMLJP@WriteEvent?$AA@;
  internal static ??_C@_0M@INNKCKGP@WriteEvent2?$AA@$$BY0A@$$CBD ??_C@_0M@INNKCKGP@WriteEvent2?$AA@;
  internal static ??_C@_09PIDNBOJN@ReadEvent?$AA@$$BY0A@$$CBD ??_C@_09PIDNBOJN@ReadEvent?$AA@;
  internal static ??_C@_04GJGMPLND@?4PAD?$AA@$$BY0A@$$CBD ??_C@_04GJGMPLND@?4PAD?$AA@;
  [FixedAddressValueType]
  internal static $_TypeDescriptor$_extraBytes_5 ??_R0PAD@8;
  internal static __FnPtr<void ()> ?A0x000256ae.??_R0PAD@8$initializer$;
  [FixedAddressValueType]
  internal static g_pszSourcePath$$BY0A@D HIDBootLoader.g_pszSourcePath;
  [FixedAddressValueType]
  internal static g_index$$BY0A@H HIDBootLoader.g_index;
  [FixedAddressValueType]
  internal static hexinfo$$BY0A@UHEX_INFO@HIDBootLoader@@ HIDBootLoader.hexinfo;
  [FixedAddressValueType]
  internal static hex_description$$BY1A@CAA@D HIDBootLoader.hex_description;
  [FixedAddressValueType]
  internal static int HIDBootLoader.g_id;
  internal static __FnPtr<void ()> HIDBootLoader.?A0x000256ae.g_id$initializer$;
  [FixedAddressValueType]
  internal static int HIDBootLoader.g_first_time;
  internal static __FnPtr<void ()> HIDBootLoader.?A0x000256ae.g_first_time$initializer$;
  [FixedAddressValueType]
  internal static int HIDBootLoader.g_number_of_version;
  internal static __FnPtr<void ()> HIDBootLoader.?A0x000256ae.g_number_of_version$initializer$;
  [FixedAddressValueType]
  internal static int HIDBootLoader.Status;
  internal static __FnPtr<void ()> HIDBootLoader.?A0x000256ae.Status$initializer$;
  [FixedAddressValueType]
  internal static uint HIDBootLoader.ErrorStatusRead;
  internal static __FnPtr<void ()> HIDBootLoader.?A0x000256ae.ErrorStatusRead$initializer$;
  [FixedAddressValueType]
  internal static uint HIDBootLoader.ErrorStatusWrite;
  internal static __FnPtr<void ()> HIDBootLoader.?A0x000256ae.ErrorStatusWrite$initializer$;
  [FixedAddressValueType]
  internal static int HIDBootLoader.MyDeviceAttachedStatus;
  internal static __FnPtr<void ()> HIDBootLoader.?A0x000256ae.MyDeviceAttachedStatus$initializer$;
  [FixedAddressValueType]
  internal static unsafe _SP_DEVICE_INTERFACE_DETAIL_DATA_W* HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt;
  internal static __FnPtr<void ()> HIDBootLoader.?A0x000256ae.MyStructureWithDetailedInterfaceDataInIt$initializer$;
  [FixedAddressValueType]
  internal static _GUID HIDBootLoader.InterfaceClassGuid;
  internal static __FnPtr<void ()> HIDBootLoader.?A0x000256ae.InterfaceClassGuid$initializer$;
  [FixedAddressValueType]
  internal static encryptedFF$$BY0A@E encryptedFF;
  [FixedAddressValueType]
  internal static byte encryptionBlockSize;
  [FixedAddressValueType]
  internal static AccessType ?A0x000256ae.SA_ReadWrite;
  internal static __FnPtr<void ()> ?A0x000256ae.SA_ReadWrite$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0x000256ae.SA_Write;
  internal static __FnPtr<void ()> ?A0x000256ae.SA_Write$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0x000256ae.SA_Read;
  internal static __FnPtr<void ()> ?A0x000256ae.SA_Read$initializer$;
  [FixedAddressValueType]
  internal static AccessType ?A0x000256ae.SA_NoAccess;
  internal static __FnPtr<void ()> ?A0x000256ae.SA_NoAccess$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0x000256ae.SA_Maybe;
  internal static __FnPtr<void ()> ?A0x000256ae.SA_Maybe$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0x000256ae.SA_No;
  internal static __FnPtr<void ()> ?A0x000256ae.SA_No$initializer$;
  [FixedAddressValueType]
  internal static YesNoMaybe ?A0x000256ae.SA_Yes;
  internal static __FnPtr<void ()> ?A0x000256ae.SA_Yes$initializer$;
  [FixedAddressValueType]
  internal static int __@@_PchSym_@00@UDwhUkDsfyUnrxilxsrkOyllgolzwviOfhyOsrwOeCOGySgsvLhlugdzivLuliLfhysrwxBILygoTUnrxilxsrkOyllgolzwviOfhyOsrwOeCOGyUivovzhvUhgwzucOlyq@;

  [SecurityCritical]
  [DebuggerStepThrough]
  static unsafe <Module>()
  {
    LanguageSupport languageSupport;
    <Module>.<CrtImplementationDetails>.LanguageSupport.{ctor}(&languageSupport);
    // ISSUE: fault handler
    try
    {
      <Module>.<CrtImplementationDetails>.LanguageSupport.Initialize(&languageSupport);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      <Module>.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(<CrtImplementationDetails>.LanguageSupport.{dtor}), (void*) &languageSupport);
    }
    <Module>.gcroot<System::String ^>.{dtor}((gcroot<System::String ^>*) &languageSupport);
  }

  internal static void ?A0xfd8b67b9.??__E?A0xfd8b67b9@SA_Yes@@YMXXZ()
  {
    <Module>.?A0xfd8b67b9.SA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void ?A0xfd8b67b9.??__E?A0xfd8b67b9@SA_No@@YMXXZ()
  {
    <Module>.?A0xfd8b67b9.SA_No = (YesNoMaybe) 268369921;
  }

  internal static void ?A0xfd8b67b9.??__E?A0xfd8b67b9@SA_Maybe@@YMXXZ()
  {
    <Module>.?A0xfd8b67b9.SA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void ?A0xfd8b67b9.??__E?A0xfd8b67b9@SA_NoAccess@@YMXXZ()
  {
    <Module>.?A0xfd8b67b9.SA_NoAccess = (AccessType) 0;
  }

  internal static void ?A0xfd8b67b9.??__E?A0xfd8b67b9@SA_Read@@YMXXZ()
  {
    <Module>.?A0xfd8b67b9.SA_Read = (AccessType) 1;
  }

  internal static void ?A0xfd8b67b9.??__E?A0xfd8b67b9@SA_Write@@YMXXZ()
  {
    <Module>.?A0xfd8b67b9.SA_Write = (AccessType) 2;
  }

  internal static void ?A0xfd8b67b9.??__E?A0xfd8b67b9@SA_ReadWrite@@YMXXZ()
  {
    <Module>.?A0xfd8b67b9.SA_ReadWrite = (AccessType) 3;
  }

  internal static void ?A0xfd8b67b9.??__E?A0xfd8b67b9@_HUGE@@YMXXZ()
  {
    <Module>.?A0xfd8b67b9._HUGE = double.PositiveInfinity;
  }

  internal static void ?A0xfd8b67b9.??__E?A0xfd8b67b9@HUGE@@YMXXZ()
  {
    <Module>.?A0xfd8b67b9.HUGE = <Module>.?A0xfd8b67b9._HUGE;
  }

  [SecurityCritical]
  internal static int _atexit_m(__FnPtr<void ()> _Function)
  {
    return <Module>._atexit_m_appdomain(_Function);
  }

  [SecurityCritical]
  internal static int atexit(__FnPtr<void ()> _Function)
  {
    return <Module>._atexit_m_appdomain(_Function);
  }

  internal static void <CrtImplementationDetails>.ThrowNestedModuleLoadException(Exception innerException, Exception nestedException)
  {
    throw new ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
  }

  internal static void <CrtImplementationDetails>.ThrowModuleLoadException(string errorMessage, Exception innerException)
  {
    throw new ModuleLoadException(errorMessage, innerException);
  }

  internal static void <CrtImplementationDetails>.RegisterModuleUninitializer(EventHandler handler)
  {
    ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
  }

  internal static void ?A0xfd8b67b9.??__E?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
  {
    <Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
  }

  internal static void ?A0xfd8b67b9.??__E?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA@@YMXXZ()
  {
    <Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 0;
  }

  internal static void ?A0xfd8b67b9.??__E?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA@@YMXXZ()
  {
    <Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = false;
  }

  internal static void ?A0xfd8b67b9.??__E?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
  {
    <Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State) 0;
  }

  internal static void ?A0xfd8b67b9.??__E?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
  {
    <Module>.?InitializedNative@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State) 0;
  }

  internal static void ?A0xfd8b67b9.??__E?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
  {
    <Module>.?InitializedPerProcess@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State) 0;
  }

  internal static void ?A0xfd8b67b9.??__E?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A@@YMXXZ()
  {
    <Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State) 0;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void <CrtImplementationDetails>.LanguageSupport.InitializeVtables([In] LanguageSupport* obj0)
  {
    <Module>.gcroot<System::String ^>.=((gcroot<System::String ^>*) obj0, "The C++ module failed to load during vtable initialization.\n");
    <Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State) 1;
    <Module>._initterm_m((__FnPtr<void* ()>*) &<Module>.?A0xfd8b67b9.__xi_vt_a, (__FnPtr<void* ()>*) &<Module>.?A0xfd8b67b9.__xi_vt_z);
    <Module>.?InitializedVtables@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State) 2;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void <CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain([In] LanguageSupport* obj0)
  {
    <Module>.gcroot<System::String ^>.=((gcroot<System::String ^>*) obj0, "The C++ module failed to load during appdomain initialization.\n");
    <Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State) 1;
    <Module>._initatexit_app_domain();
    <Module>._initterm_m((__FnPtr<void* ()>*) &<Module>.?A0xfd8b67b9.__xc_ma_a, (__FnPtr<void* ()>*) &<Module>.?A0xfd8b67b9.__xc_ma_z);
    <Module>.?InitializedPerAppDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2W4State@Progress@2@A = (Progress.State) 2;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void <CrtImplementationDetails>.LanguageSupport.InitializeUninitializer([In] LanguageSupport* obj0)
  {
    <Module>.gcroot<System::String ^>.=((gcroot<System::String ^>*) obj0, "The C++ module failed to load during registration for the unload events.\n");
    EventHandler handler = new EventHandler(<Module>.<CrtImplementationDetails>.LanguageSupport.DomainUnload);
    ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [DebuggerStepThrough]
  internal static unsafe void <CrtImplementationDetails>.LanguageSupport._Initialize([In] LanguageSupport* obj0)
  {
    <Module>.?IsDefaultDomain@CurrentDomain@<CrtImplementationDetails>@@$$Q2_NA = AppDomain.CurrentDomain.IsDefaultAppDomain();
    <Module>.<CrtImplementationDetails>.LanguageSupport.InitializeVtables(obj0);
    <Module>.<CrtImplementationDetails>.LanguageSupport.InitializePerAppDomain(obj0);
    <Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA = 1;
    <Module>.<CrtImplementationDetails>.LanguageSupport.InitializeUninitializer(obj0);
  }

  [SecurityCritical]
  internal static void <CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain()
  {
    <Module>._app_exit_callback();
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [PrePrepareMethod]
  internal static void <CrtImplementationDetails>.LanguageSupport.DomainUnload(object source, EventArgs arguments)
  {
    if (<Module>.?Initialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA == 0 || Interlocked.Exchange(ref <Module>.?Uninitialized@CurrentDomain@<CrtImplementationDetails>@@$$Q2HA, 1) != 0)
      return;
    <Module>._app_exit_callback();
  }

  [DebuggerStepThrough]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  internal static unsafe void <CrtImplementationDetails>.LanguageSupport.Cleanup([In] LanguageSupport* obj0, Exception innerException)
  {
    try
    {
      <Module>.<CrtImplementationDetails>.LanguageSupport.UninitializeAppDomain();
    }
    catch (Exception ex)
    {
      <Module>.<CrtImplementationDetails>.ThrowNestedModuleLoadException(innerException, ex);
    }
    catch
    {
      <Module>.<CrtImplementationDetails>.ThrowNestedModuleLoadException(innerException, (Exception) null);
    }
  }

  [SecurityCritical]
  internal static unsafe LanguageSupport* <CrtImplementationDetails>.LanguageSupport.{ctor}([In] LanguageSupport* obj0)
  {
    <Module>.gcroot<System::String ^>.{ctor}((gcroot<System::String ^>*) obj0);
    return obj0;
  }

  [SecurityCritical]
  internal static unsafe void <CrtImplementationDetails>.LanguageSupport.{dtor}([In] LanguageSupport* obj0)
  {
    <Module>.gcroot<System::String ^>.{dtor}((gcroot<System::String ^>*) obj0);
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [DebuggerStepThrough]
  internal static unsafe void <CrtImplementationDetails>.LanguageSupport.Initialize([In] LanguageSupport* obj0)
  {
    try
    {
      <Module>.gcroot<System::String ^>.=((gcroot<System::String ^>*) obj0, "The C++ module failed to load.\n");
      <Module>.<CrtImplementationDetails>.LanguageSupport._Initialize(obj0);
    }
    catch (Exception ex)
    {
      <Module>.<CrtImplementationDetails>.LanguageSupport.Cleanup(obj0, ex);
      throw new ModuleLoadException(<Module>.gcroot<System::String ^>..P$AAVString@System@@((gcroot<System::String ^>*) obj0), ex);
    }
    catch
    {
      <Module>.<CrtImplementationDetails>.LanguageSupport.Cleanup(obj0, (Exception) null);
      throw new ModuleLoadException(<Module>.gcroot<System::String ^>..P$AAVString@System@@((gcroot<System::String ^>*) obj0), (Exception) null);
    }
  }

  [DebuggerStepThrough]
  [SecuritySafeCritical]
  internal static unsafe gcroot<System::String ^>* gcroot<System::String ^>.{ctor}([In] gcroot<System::String ^>* obj0)
  {
    IntPtr num = (IntPtr) GCHandle.Alloc((object) null);
    *(int*) obj0 = (int) num.ToPointer();
    return obj0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void gcroot<System::String ^>.{dtor}([In] gcroot<System::String ^>* obj0)
  {
    (GCHandle) new IntPtr((void*) *(int*) obj0).Free();
    *(int*) obj0 = 0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe gcroot<System::String ^>* gcroot<System::String ^>.=([In] gcroot<System::String ^>* obj0, string t)
  {
    (GCHandle) new IntPtr((void*) *(int*) obj0).Target = (object) t;
    return obj0;
  }

  [SecuritySafeCritical]
  internal static unsafe string gcroot<System::String ^>..P$AAVString@System@@([In] gcroot<System::String ^>* obj0)
  {
    return (string) (GCHandle) new IntPtr((void*) *(int*) obj0).Target;
  }

  internal static void ?A0xc9f6eb9e.??__E?A0xc9f6eb9e@SA_Yes@@YMXXZ()
  {
    <Module>.?A0xc9f6eb9e.SA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void ?A0xc9f6eb9e.??__E?A0xc9f6eb9e@SA_No@@YMXXZ()
  {
    <Module>.?A0xc9f6eb9e.SA_No = (YesNoMaybe) 268369921;
  }

  internal static void ?A0xc9f6eb9e.??__E?A0xc9f6eb9e@SA_Maybe@@YMXXZ()
  {
    <Module>.?A0xc9f6eb9e.SA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void ?A0xc9f6eb9e.??__E?A0xc9f6eb9e@SA_NoAccess@@YMXXZ()
  {
    <Module>.?A0xc9f6eb9e.SA_NoAccess = (AccessType) 0;
  }

  internal static void ?A0xc9f6eb9e.??__E?A0xc9f6eb9e@SA_Read@@YMXXZ()
  {
    <Module>.?A0xc9f6eb9e.SA_Read = (AccessType) 1;
  }

  internal static void ?A0xc9f6eb9e.??__E?A0xc9f6eb9e@SA_Write@@YMXXZ()
  {
    <Module>.?A0xc9f6eb9e.SA_Write = (AccessType) 2;
  }

  internal static void ?A0xc9f6eb9e.??__E?A0xc9f6eb9e@SA_ReadWrite@@YMXXZ()
  {
    <Module>.?A0xc9f6eb9e.SA_ReadWrite = (AccessType) 3;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe ValueType <CrtImplementationDetails>.AtExitLock._handle()
  {
    if ((IntPtr) <Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA != IntPtr.Zero)
      return (ValueType) GCHandle.FromIntPtr(new IntPtr(<Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA));
    return (ValueType) null;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void <CrtImplementationDetails>.AtExitLock._lock_Construct(object value)
  {
    <Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = (void*) 0;
    <Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(value);
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void <CrtImplementationDetails>.AtExitLock._lock_Set(object value)
  {
    ValueType valueType = <Module>.<CrtImplementationDetails>.AtExitLock._handle();
    if (valueType == null)
      <Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = GCHandle.ToIntPtr(GCHandle.Alloc(value)).ToPointer();
    else
      ((GCHandle) valueType).Target = value;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static object <CrtImplementationDetails>.AtExitLock._lock_Get()
  {
    ValueType valueType = <Module>.<CrtImplementationDetails>.AtExitLock._handle();
    if (valueType != null)
      return ((GCHandle) valueType).Target;
    return (object) null;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void <CrtImplementationDetails>.AtExitLock._lock_Destruct()
  {
    ValueType valueType = <Module>.<CrtImplementationDetails>.AtExitLock._handle();
    if (valueType == null)
      return;
    ((GCHandle) valueType).Free();
    <Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = (void*) 0;
  }

  [DebuggerStepThrough]
  [SecuritySafeCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool <CrtImplementationDetails>.AtExitLock.IsInitialized()
  {
    return <Module>.<CrtImplementationDetails>.AtExitLock._lock_Get() != null;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void <CrtImplementationDetails>.AtExitLock.AddRef()
  {
    if (!<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized())
    {
      <Module>.?_lock@AtExitLock@<CrtImplementationDetails>@@$$Q0PAXA = (void*) 0;
      <Module>.<CrtImplementationDetails>.AtExitLock._lock_Set(new object());
      <Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA = 0;
    }
    ++<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void <CrtImplementationDetails>.AtExitLock.RemoveRef()
  {
    --<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;
    if (<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA != 0)
      return;
    <Module>.<CrtImplementationDetails>.AtExitLock._lock_Destruct();
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static void <CrtImplementationDetails>.AtExitLock.Enter()
  {
    Monitor.Enter(<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void <CrtImplementationDetails>.AtExitLock.Exit()
  {
    Monitor.Exit(<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool ?A0xc9f6eb9e.__global_lock()
  {
    bool flag = false;
    if (<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized())
    {
      Monitor.Enter(<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
      flag = true;
    }
    return flag;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool ?A0xc9f6eb9e.__global_unlock()
  {
    bool flag = false;
    if (<Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized())
    {
      Monitor.Exit(<Module>.<CrtImplementationDetails>.AtExitLock._lock_Get());
      flag = true;
    }
    return flag;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool ?A0xc9f6eb9e.__alloc_global_lock()
  {
    <Module>.<CrtImplementationDetails>.AtExitLock.AddRef();
    return <Module>.<CrtImplementationDetails>.AtExitLock.IsInitialized();
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static void ?A0xc9f6eb9e.__dealloc_global_lock()
  {
    --<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA;
    if (<Module>.?_ref_count@AtExitLock@<CrtImplementationDetails>@@$$Q0HA != 0)
      return;
    <Module>.<CrtImplementationDetails>.AtExitLock._lock_Destruct();
  }

  [SecurityCritical]
  internal static unsafe int _atexit_helper(__FnPtr<void ()> func, uint* __pexit_list_size, __FnPtr<void ()>** __ponexitend_e, __FnPtr<void ()>** __ponexitbegin_e)
  {
    // ISSUE: cast to a function pointer type
    __FnPtr<void ()> local1 = (__FnPtr<void ()>) 0;
    if (func == null)
      return -1;
    int num1;
    if (<Module>.?A0xc9f6eb9e.__global_lock())
    {
      try
      {
        __FnPtr<void ()>* local2 = (__FnPtr<void ()>*) <Module>.DecodePointer((void*) *(int*) __ponexitbegin_e);
        __FnPtr<void ()>* local3 = (__FnPtr<void ()>*) <Module>.DecodePointer((void*) *(int*) __ponexitend_e);
        int num2 = (int) ((IntPtr) local3 - (IntPtr) local2);
        if (*__pexit_list_size - 1U < (uint) num2 >> 2)
        {
          try
          {
            uint num3 = *__pexit_list_size * 4U;
            uint num4 = num3 >= 2048U ? 2048U : num3;
            IntPtr cb = new IntPtr((int) num3 + (int) num4);
            IntPtr num5 = Marshal.ReAllocHGlobal(new IntPtr((void*) local2), cb);
            local3 = (__FnPtr<void ()>*) ((IntPtr) num5.ToPointer() + num2);
            local2 = (__FnPtr<void ()>*) num5.ToPointer();
            uint num6 = *__pexit_list_size;
            uint num7 = 512U >= num6 ? num6 : 512U;
            *__pexit_list_size = num6 + num7;
          }
          catch (OutOfMemoryException ex)
          {
            IntPtr cb = new IntPtr((int) *__pexit_list_size * 4 + 8);
            IntPtr num3 = Marshal.ReAllocHGlobal(new IntPtr((void*) local2), cb);
            local3 = (__FnPtr<void ()>*) ((IntPtr) num3.ToPointer() - (IntPtr) local2 + (IntPtr) local3);
            local2 = (__FnPtr<void ()>*) num3.ToPointer();
            uint* numPtr = __pexit_list_size;
            int num4 = (int) *numPtr + 4;
            *numPtr = (uint) num4;
          }
        }
        *(int*) local3 = (int) func;
        __FnPtr<void ()>* local4 = (__FnPtr<void ()>*) ((IntPtr) local3 + 4);
        local1 = func;
        *(int*) __ponexitbegin_e = (int) <Module>.EncodePointer((void*) local2);
        *(int*) __ponexitend_e = (int) <Module>.EncodePointer((void*) local4);
      }
      catch (OutOfMemoryException ex)
      {
      }
      finally
      {
        <Module>.?A0xc9f6eb9e.__global_unlock();
      }
      if (local1 != null)
      {
        num1 = 0;
        goto label_12;
      }
    }
    num1 = -1;
label_12:
    return num1;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe int _initatexit_app_domain()
  {
    if (<Module>.?A0xc9f6eb9e.__alloc_global_lock())
    {
      <Module>.__onexitbegin_app_domain = (__FnPtr<void ()>*) <Module>.EncodePointer(Marshal.AllocHGlobal(128).ToPointer());
      <Module>.__onexitend_app_domain = <Module>.__onexitbegin_app_domain;
      <Module>.__exit_list_size_app_domain = 32U;
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      <Module>._atexit_m_appdomain((__FnPtr<void ()>) __methodptr(__clean_type_info_names));
    }
    return 1;
  }

  [HandleProcessCorruptedStateExceptions]
  [SecurityCritical]
  internal static unsafe void _app_exit_callback()
  {
    if ((int) <Module>.__exit_list_size_app_domain == 0)
      return;
    __FnPtr<void ()>* local1 = (__FnPtr<void ()>*) <Module>.DecodePointer((void*) <Module>.__onexitbegin_app_domain);
    __FnPtr<void ()>* local2 = (__FnPtr<void ()>*) <Module>.DecodePointer((void*) <Module>.__onexitend_app_domain);
    try
    {
      if ((IntPtr) local1 == new IntPtr(-1) || (IntPtr) local1 == IntPtr.Zero || (IntPtr) local2 == IntPtr.Zero)
        return;
      __FnPtr<void ()>* local3 = local1;
      __FnPtr<void ()>* local4 = local2;
      while (true)
      {
        __FnPtr<void ()>* local5;
        __FnPtr<void ()>* local6;
        do
        {
          do
          {
            local2 -= 4;
          }
          while (local2 >= local1 && (IntPtr) *(int*) local2 == (IntPtr) <Module>._encoded_null());
          if (local2 >= local1)
          {
            // ISSUE: cast to a function pointer type
            __FnPtr<void ()> local7 = (__FnPtr<void ()>) (IntPtr) <Module>.DecodePointer((void*) *(int*) local2);
            *(int*) local2 = (int) <Module>._encoded_null();
            // ISSUE: function pointer call
            __calli(local7)();
            local5 = (__FnPtr<void ()>*) <Module>.DecodePointer((void*) <Module>.__onexitbegin_app_domain);
            local6 = (__FnPtr<void ()>*) <Module>.DecodePointer((void*) <Module>.__onexitend_app_domain);
          }
          else
            goto label_12;
        }
        while (local3 == local5 && local4 == local6);
        local3 = local5;
        local1 = local5;
        local4 = local6;
        local2 = local6;
      }
label_12:;
    }
    finally
    {
      Marshal.FreeHGlobal(new IntPtr((void*) local1));
      <Module>.?A0xc9f6eb9e.__dealloc_global_lock();
    }
  }

  [SecurityCritical]
  internal static __FnPtr<int ()> _onexit_m_appdomain(__FnPtr<int ()> _Function)
  {
    // ISSUE: cast to a function pointer type
    if (<Module>._atexit_m_appdomain((__FnPtr<void ()>) _Function) != -1)
      return _Function;
    // ISSUE: cast to a function pointer type
    return (__FnPtr<int ()>) 0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe int _atexit_m_appdomain(__FnPtr<void ()> func)
  {
    // ISSUE: cast to a function pointer type
    return <Module>._atexit_helper((__FnPtr<void ()>) (IntPtr) <Module>.EncodePointer((void*) func), &<Module>.__exit_list_size_app_domain, &<Module>.__onexitend_app_domain, &<Module>.__onexitbegin_app_domain);
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SuppressUnmanagedCodeSecurity]
  [SecurityCritical]
  [DllImport("KERNEL32.dll")]
  public static extern unsafe void* DecodePointer(void* Ptr);

  [SuppressUnmanagedCodeSecurity]
  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern unsafe void* _encoded_null();

  [SuppressUnmanagedCodeSecurity]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [DllImport("KERNEL32.dll")]
  public static extern unsafe void* EncodePointer(void* Ptr);

  internal static void ?A0x8bd98b91.??__E?A0x8bd98b91@SA_Yes@@YMXXZ()
  {
    <Module>.?A0x8bd98b91.SA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void ?A0x8bd98b91.??__E?A0x8bd98b91@SA_No@@YMXXZ()
  {
    <Module>.?A0x8bd98b91.SA_No = (YesNoMaybe) 268369921;
  }

  internal static void ?A0x8bd98b91.??__E?A0x8bd98b91@SA_Maybe@@YMXXZ()
  {
    <Module>.?A0x8bd98b91.SA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void ?A0x8bd98b91.??__E?A0x8bd98b91@SA_NoAccess@@YMXXZ()
  {
    <Module>.?A0x8bd98b91.SA_NoAccess = (AccessType) 0;
  }

  internal static void ?A0x8bd98b91.??__E?A0x8bd98b91@SA_Read@@YMXXZ()
  {
    <Module>.?A0x8bd98b91.SA_Read = (AccessType) 1;
  }

  internal static void ?A0x8bd98b91.??__E?A0x8bd98b91@SA_Write@@YMXXZ()
  {
    <Module>.?A0x8bd98b91.SA_Write = (AccessType) 2;
  }

  internal static void ?A0x8bd98b91.??__E?A0x8bd98b91@SA_ReadWrite@@YMXXZ()
  {
    <Module>.?A0x8bd98b91.SA_ReadWrite = (AccessType) 3;
  }

  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static void ?A0x8bd98b91.__DestructExceptionObject_m(EHExceptionRecord* pExcept, byte fThrowNotAllowed)
  {
    // ISSUE: unable to decompile the method.
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  internal static unsafe int ___CxxExceptionFilter(void* ppExcept, void* pType, int adjectives, void* pBuildObj)
  {
    if ((IntPtr) ppExcept == IntPtr.Zero)
      return 0;
    EHExceptionRecord* pExcept = (EHExceptionRecord*) *(int*) ppExcept;
    if ((IntPtr) pType == IntPtr.Zero || (int) *(sbyte*) ((IntPtr) pType + 8) == 0)
    {
      uint num1 = (uint) *(int*) pExcept;
      switch (num1)
      {
        case 3762507597:
        case 3762504530:
          if ((int) num1 == -529697949 && *(int*) ((IntPtr) pExcept + 16) == 3 && (*(int*) ((IntPtr) pExcept + 20) == 26820608 || *(int*) ((IntPtr) pExcept + 28) == 0) && (*(int*) ((IntPtr) pExcept + 28) == 0 && *(int*) ((IntPtr) <Module>._getptd() + 136) == 0))
            return 0;
          IntPtr num2 = (IntPtr) <Module>._getptd() + 144;
          int num3 = *(int*) num2 + 1;
          *(int*) num2 = num3;
          return 1;
        default:
          if ((adjectives & 64) == 0)
            goto case 3762507597;
          else
            break;
      }
    }
    if (*(int*) pExcept == -529697949 && *(int*) ((IntPtr) pExcept + 16) == 3 && (*(int*) ((IntPtr) pExcept + 20) == 26820608 || *(int*) ((IntPtr) pExcept + 28) == 0))
    {
      if (*(int*) ((IntPtr) pExcept + 28) == 0)
      {
        if (*(int*) ((IntPtr) <Module>._getptd() + 136) == 0)
          return 0;
        pExcept = (EHExceptionRecord*) *(int*) ((IntPtr) <Module>._getptd() + 136);
      }
      _s_HandlerType sHandlerType;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) ((IntPtr) &sHandlerType + 4) = (int) pType;
      // ISSUE: explicit reference operation
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      ^(int&) @sHandlerType = adjectives | int.MinValue;
      int num1 = *(int*) (*(int*) ((IntPtr) pExcept + 28) + 12);
      _s_CatchableType** sCatchableTypePtr1 = (_s_CatchableType**) (num1 + 4);
      int num2 = *(int*) num1;
      if (num2 > 0)
      {
        _s_CatchableType* sCatchableTypePtr2;
        do
        {
          sCatchableTypePtr2 = (_s_CatchableType*) *(int*) sCatchableTypePtr1;
          if (<Module>.?A0x8bd98b91.TypeMatch<struct _s_HandlerType,struct _s_CatchableType const ,struct _s_ThrowInfo const >(&sHandlerType, sCatchableTypePtr2, (_s_ThrowInfo*) *(int*) ((IntPtr) pExcept + 28)) == 0)
          {
            --num2;
            sCatchableTypePtr1 += 4;
          }
          else
            goto label_13;
        }
        while (num2 > 0);
        goto label_16;
label_13:
        IntPtr num3 = (IntPtr) <Module>._getptd() + 144;
        int num4 = *(int*) num3 + 1;
        *(int*) num3 = num4;
        if ((IntPtr) pBuildObj != IntPtr.Zero)
          <Module>.?A0x8bd98b91.BuildCatchObject<struct _s_HandlerType,struct _s_CatchableType const >(pExcept, pBuildObj, &sHandlerType, sCatchableTypePtr2);
        return 1;
      }
    }
label_16:
    return 0;
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe int ___CxxRegisterExceptionObject(void* ppExcept, void* pStorage)
  {
    if ((IntPtr) ppExcept != IntPtr.Zero)
    {
      uint num = (uint) *(int*) ppExcept;
      if ((int) num != 0)
      {
        EHExceptionRecord* ehExceptionRecordPtr = (EHExceptionRecord*) num;
        if (*(int*) ehExceptionRecordPtr == -529697949 && *(int*) ((IntPtr) ehExceptionRecordPtr + 16) == 3 && (*(int*) ((IntPtr) ehExceptionRecordPtr + 20) == 26820608 || *(int*) ((IntPtr) ehExceptionRecordPtr + 28) == 0) && *(int*) ((IntPtr) ehExceptionRecordPtr + 28) == 0)
          ehExceptionRecordPtr = (EHExceptionRecord*) *(int*) ((IntPtr) <Module>._getptd() + 136);
        <Module>._CreateFrameInfo((FrameInfo*) pStorage, (void*) *(int*) ((IntPtr) ehExceptionRecordPtr + 24));
        *(int*) ((IntPtr) pStorage + 8) = *(int*) ((IntPtr) <Module>._getptd() + 136);
        *(int*) ((IntPtr) pStorage + 8 + 4) = *(int*) ((IntPtr) <Module>._getptd() + 140);
        *(int*) ((IntPtr) <Module>._getptd() + 136) = (int) ehExceptionRecordPtr;
        goto label_6;
      }
    }
    *(int*) ((IntPtr) pStorage + 8) = -1;
    *(int*) ((IntPtr) pStorage + 8 + 4) = -1;
label_6:
    IntPtr num1 = (IntPtr) <Module>._getptd() + 144;
    int num2 = *(int*) num1 - 1;
    *(int*) num1 = num2;
    if (*(int*) ((IntPtr) <Module>._getptd() + 144) < 0)
      *(int*) ((IntPtr) <Module>._getptd() + 144) = 0;
    return 1;
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static unsafe int ___CxxDetectRethrow(void* ppExcept)
  {
    if ((IntPtr) ppExcept == IntPtr.Zero)
      return 0;
    EHExceptionRecord* ehExceptionRecordPtr = (EHExceptionRecord*) *(int*) ppExcept;
    if (*(int*) ehExceptionRecordPtr != -529697949 || *(int*) ((IntPtr) ehExceptionRecordPtr + 16) != 3 || *(int*) ((IntPtr) ehExceptionRecordPtr + 20) != 26820608 && *(int*) ((IntPtr) ehExceptionRecordPtr + 28) != 0 || *(int*) ((IntPtr) ehExceptionRecordPtr + 28) != 0)
      return 0;
    IntPtr num1 = (IntPtr) <Module>._getptd() + 144;
    int num2 = *(int*) num1 + 1;
    *(int*) num1 = num2;
    return 1;
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ___CxxUnregisterExceptionObject(void* pStorage, int rethrow)
  {
    EHExceptionRecord** ehExceptionRecordPtr = (EHExceptionRecord**) ((IntPtr) pStorage + 8);
    _CONTEXT** contextPtr = (_CONTEXT**) ((IntPtr) ehExceptionRecordPtr + 4);
    if (*(int*) ehExceptionRecordPtr == -1)
      return;
    <Module>._FindAndUnlinkFrame((FrameInfo*) pStorage);
    if (rethrow == 0 && *(int*) *(int*) ((IntPtr) <Module>._getptd() + 136) == -529697949 && *(int*) (*(int*) ((IntPtr) <Module>._getptd() + 136) + 16) == 3 && ((*(int*) (*(int*) ((IntPtr) <Module>._getptd() + 136) + 20) == 26820608 || *(int*) (*(int*) ((IntPtr) <Module>._getptd() + 136) + 28) == 0) && <Module>._IsExceptionObjectToBeDestroyed((void*) *(int*) (*(int*) ((IntPtr) <Module>._getptd() + 136) + 24)) != 0))
      <Module>.?A0x8bd98b91.__DestructExceptionObject_m((EHExceptionRecord*) *(int*) ((IntPtr) <Module>._getptd() + 136), (byte) 1);
    if (*(int*) *(int*) ((IntPtr) <Module>._getptd() + 136) == -529697949 && *(int*) (*(int*) ((IntPtr) <Module>._getptd() + 136) + 16) == 3 && (*(int*) (*(int*) ((IntPtr) <Module>._getptd() + 136) + 20) == 26820608 || *(int*) (*(int*) ((IntPtr) <Module>._getptd() + 136) + 28) == 0) && rethrow != 0)
    {
      IntPtr num1 = (IntPtr) <Module>._getptd() + 144;
      int num2 = *(int*) num1 - 1;
      *(int*) num1 = num2;
    }
    *(int*) ((IntPtr) <Module>._getptd() + 136) = *(int*) ehExceptionRecordPtr;
    *(int*) ((IntPtr) <Module>._getptd() + 140) = *(int*) contextPtr;
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static int ___CxxQueryExceptionSize()
  {
    return 16;
  }

  [HandleProcessCorruptedStateExceptions]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ___CxxCallUnwindDtor(__FnPtr<void (void*)> pDtor, void* pThis)
  {
    try
    {
      void* voidPtr = pThis;
      // ISSUE: function pointer call
      __calli(pDtor)(voidPtr);
    }
    catch (Exception ex) when (<Module>.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ___CxxCallUnwindDelDtor(__FnPtr<void (void*)> pDtor, void* pThis)
  {
    try
    {
      void* voidPtr = pThis;
      // ISSUE: function pointer call
      __calli(pDtor)(voidPtr);
    }
    catch (Exception ex) when (<Module>.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ___CxxCallUnwindVecDtor(__FnPtr<void (void*, uint, int, __FnPtr<void (void*)>)> pVecDtor, void* ptr, uint size, int count, __FnPtr<void (void*)> pDtor)
  {
    try
    {
      void* voidPtr = ptr;
      int num1 = (int) size;
      int num2 = count;
      __FnPtr<void (void*)> local = pDtor;
      // ISSUE: cast to a function pointer type
      // ISSUE: function pointer call
      __calli(pVecDtor)((__FnPtr<void (void*)>) (IntPtr) voidPtr, num1, (uint) num2, (void*) local);
    }
    catch (Exception ex) when (<Module>.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecuritySafeCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe int ?A0x8bd98b91.TypeMatch<struct _s_HandlerType,struct _s_CatchableType const ,struct _s_ThrowInfo const >(_s_HandlerType* pCatch, _s_CatchableType* pCatchable, _s_ThrowInfo* pThrow)
  {
    uint num1 = (uint) *(int*) ((IntPtr) pCatch + 4);
    if ((int) num1 != 0)
    {
      int num2 = (int) num1 + 8;
      if ((int) *(sbyte*) num2 != 0)
      {
        uint num3 = (uint) *(int*) ((IntPtr) pCatchable + 4);
        if ((int) num1 != (int) num3 && <Module>.strcmp((sbyte*) num2, (sbyte*) ((int) num3 + 8)) != 0)
          return 0;
        int num4;
        if ((*(int*) pCatchable & 2) == 0 || (*(int*) pCatch & 8) != 0)
        {
          uint num5 = (uint) *(int*) pThrow;
          if ((((int) num5 & 1) == 0 || (*(int*) pCatch & 1) != 0) && (((int) num5 & 2) == 0 || (*(int*) pCatch & 2) != 0))
          {
            num4 = 1;
            goto label_8;
          }
        }
        num4 = 0;
label_8:
        return num4;
      }
    }
    return 1;
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [HandleProcessCorruptedStateExceptions]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void ?A0x8bd98b91.BuildCatchObject<struct _s_HandlerType,struct _s_CatchableType const >(EHExceptionRecord* pExcept, void* pRN, _s_HandlerType* pCatch, _s_CatchableType* pConv)
  {
    if ((*(int*) pCatch & int.MinValue) == 0)
      <Module>._inconsistency();
    try
    {
      switch (<Module>.?A0x8bd98b91.BuildCatchObjectHelper<struct _s_HandlerType,struct _s_CatchableType const >(pExcept, pRN, pCatch, pConv))
      {
        case 1:
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          __calli((__FnPtr<void (void*, void*)>) *(int*) ((IntPtr) pConv + 24))(pRN, <Module>.__AdjustPointer((void*) *(int*) ((IntPtr) pExcept + 24), (PMD*) ((IntPtr) pConv + 8)));
          break;
        case 2:
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          __calli((__FnPtr<void (void*, void*, int)>) *(int*) ((IntPtr) pConv + 24))((int) pRN, <Module>.__AdjustPointer((void*) *(int*) ((IntPtr) pExcept + 24), (PMD*) ((IntPtr) pConv + 8)), (void*) 1);
          break;
      }
    }
    catch (Exception ex) when (1 != 0)
    {
      <Module>.terminate();
    }
  }

  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe int ?A0x8bd98b91.BuildCatchObjectHelper<struct _s_HandlerType,struct _s_CatchableType const >(EHExceptionRecord* pExcept, void* pRN, _s_HandlerType* pCatch, _s_CatchableType* pConv)
  {
    int num1 = 0;
    uint num2 = (uint) *(int*) ((IntPtr) pCatch + 4);
    if ((int) num2 == 0 || (int) *(sbyte*) ((int) num2 + 8) == 0 || *(int*) ((IntPtr) pCatch + 8) == 0 && (*(int*) pCatch & int.MinValue) == 0)
      return 0;
    if ((*(int*) pCatch & int.MinValue) == 0)
      <Module>._inconsistency();
    try
    {
      if ((*(int*) pCatch & 8) != 0)
      {
        if (<Module>._ValidateRead((void*) *(int*) ((IntPtr) pExcept + 24), 1U) != 0 && <Module>._ValidateWrite(pRN, 1U) != 0)
        {
          int num3 = *(int*) ((IntPtr) pExcept + 24);
          *(int*) pRN = num3;
          *(int*) pRN = (int) <Module>.__AdjustPointer((void*) num3, (PMD*) ((IntPtr) pConv + 8));
        }
        else
          <Module>._inconsistency();
      }
      else if ((*(int*) pConv & 1) != 0)
      {
        if (<Module>._ValidateRead((void*) *(int*) ((IntPtr) pExcept + 24), 1U) != 0 && <Module>._ValidateWrite(pRN, 1U) != 0)
        {
          <Module>.memmove(pRN, (void*) *(int*) ((IntPtr) pExcept + 24), (uint) *(int*) ((IntPtr) pConv + 20));
          if (*(int*) ((IntPtr) pConv + 20) == 4)
          {
            uint num3 = (uint) *(int*) pRN;
            if ((int) num3 != 0)
              *(int*) pRN = (int) <Module>.__AdjustPointer((void*) num3, (PMD*) ((IntPtr) pConv + 8));
          }
        }
        else
          <Module>._inconsistency();
      }
      else if (*(int*) ((IntPtr) pConv + 24) == 0)
      {
        if (<Module>._ValidateRead((void*) *(int*) ((IntPtr) pExcept + 24), 1U) != 0 && <Module>._ValidateWrite(pRN, 1U) != 0)
          <Module>.memmove(pRN, <Module>.__AdjustPointer((void*) *(int*) ((IntPtr) pExcept + 24), (PMD*) ((IntPtr) pConv + 8)), (uint) *(int*) ((IntPtr) pConv + 20));
        else
          <Module>._inconsistency();
      }
      else
      {
        // ISSUE: cast to a function pointer type
        if (<Module>._ValidateRead((void*) *(int*) ((IntPtr) pExcept + 24), 1U) != 0 && <Module>._ValidateWrite(pRN, 1U) != 0 && <Module>._ValidateExecute((__FnPtr<int ()>) *(int*) ((IntPtr) pConv + 24)) != 0)
          num1 = (*(int*) pConv & 4) != 0 ? 2 : 1;
        else
          <Module>._inconsistency();
      }
    }
    catch (Exception ex) when (1 != 0)
    {
      <Module>.terminate();
    }
    return num1;
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern unsafe _tiddata* _getptd();

  internal static void ?A0xbdc48617.??__E?A0xbdc48617@SA_Yes@@YMXXZ()
  {
    <Module>.?A0xbdc48617.SA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void ?A0xbdc48617.??__E?A0xbdc48617@SA_No@@YMXXZ()
  {
    <Module>.?A0xbdc48617.SA_No = (YesNoMaybe) 268369921;
  }

  internal static void ?A0xbdc48617.??__E?A0xbdc48617@SA_Maybe@@YMXXZ()
  {
    <Module>.?A0xbdc48617.SA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void ?A0xbdc48617.??__E?A0xbdc48617@SA_NoAccess@@YMXXZ()
  {
    <Module>.?A0xbdc48617.SA_NoAccess = (AccessType) 0;
  }

  internal static void ?A0xbdc48617.??__E?A0xbdc48617@SA_Read@@YMXXZ()
  {
    <Module>.?A0xbdc48617.SA_Read = (AccessType) 1;
  }

  internal static void ?A0xbdc48617.??__E?A0xbdc48617@SA_Write@@YMXXZ()
  {
    <Module>.?A0xbdc48617.SA_Write = (AccessType) 2;
  }

  internal static void ?A0xbdc48617.??__E?A0xbdc48617@SA_ReadWrite@@YMXXZ()
  {
    <Module>.?A0xbdc48617.SA_ReadWrite = (AccessType) 3;
  }

  [SecurityCritical]
  internal static unsafe void _invoke_watson_if_error(int _ExpressionError, char* _Expression, char* _Function, char* _File, uint _Line, uint _Reserved)
  {
    if (_ExpressionError == 0)
      return;
    <Module>._invoke_watson(_Expression, _Function, _File, _Line, _Reserved);
  }

  [SecurityCritical]
  internal static unsafe sbyte* type_info.name([In] type_info* obj0, __type_info_node* __ptype_info_node)
  {
    return <Module>.type_info._Name_base(obj0, __ptype_info_node);
  }

  [SecurityCritical]
  internal static unsafe void type_info.{dtor}([In] type_info* obj0)
  {
    *(int*) obj0 = (int) ((IntPtr) &<Module>.??_7type_info@@6B@ + 4);
    <Module>.type_info._Type_info_dtor(obj0);
  }

  internal static unsafe void* type_info.__vecDelDtor([In] type_info* obj0, uint _param2)
  {
    if (((int) param1 & 2) != 0)
    {
      type_info* typeInfoPtr = (type_info*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      <Module>.__ehvec_dtor((void*) obj0, 12U, *(int*) typeInfoPtr, (__FnPtr<void (void*)>) __methodptr(type_info.{dtor}));
      if (((int) param1 & 1) != 0)
        <Module>.delete((void*) typeInfoPtr);
      return (void*) typeInfoPtr;
    }
    *(int*) obj0 = (int) ((IntPtr) &<Module>.??_7type_info@@6B@ + 4);
    <Module>.type_info._Type_info_dtor(obj0);
    if (((int) param1 & 1) != 0)
      <Module>.delete((void*) obj0);
    return (void*) obj0;
  }

  [SecuritySafeCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool type_info.==([In] type_info* obj0, type_info* _Rhs)
  {
    return <Module>.strcmp((sbyte*) ((IntPtr) _Rhs + 9), (sbyte*) ((IntPtr) obj0 + 9)) == 0;
  }

  [SecuritySafeCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool type_info.!=([In] type_info* obj0, type_info* _Rhs)
  {
    return <Module>.strcmp((sbyte*) ((IntPtr) _Rhs + 9), (sbyte*) ((IntPtr) obj0 + 9)) != 0;
  }

  [SecuritySafeCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe int type_info.before([In] type_info* obj0, type_info* _Rhs)
  {
    return <Module>.strcmp((sbyte*) ((IntPtr) _Rhs + 9), (sbyte*) ((IntPtr) obj0 + 9)) > 0 ? 1 : 0;
  }

  [SecuritySafeCritical]
  internal static unsafe sbyte* type_info.raw_name([In] type_info* obj0)
  {
    return (sbyte*) ((IntPtr) obj0 + 8);
  }

  [HandleProcessCorruptedStateExceptions]
  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void type_info._Type_info_dtor(type_info* _param1)
  {
    bool flag = false;
    RuntimeHelpers.PrepareConstrainedRegions();
    try
    {
      RuntimeHelpers.PrepareConstrainedRegions();
      try
      {
      }
      finally
      {
        Thread.BeginThreadAffinity();
        <Module>._lock(14);
        flag = true;
      }
      uint num = (uint) *(int*) ((IntPtr) param0 + 4);
      if ((int) num == 0)
        return;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      __type_info_node* typeInfoNodePtr1 = (__type_info_node*) ^(int&) ((IntPtr) &<Module>.__type_info_root_node + 4);
      __type_info_node* typeInfoNodePtr2 = &<Module>.__type_info_root_node;
      for (; (IntPtr) typeInfoNodePtr1 != IntPtr.Zero; typeInfoNodePtr1 = typeInfoNodePtr1)
      {
        if (*(int*) typeInfoNodePtr1 == (int) num)
        {
          *(int*) ((IntPtr) typeInfoNodePtr2 + 4) = *(int*) ((IntPtr) typeInfoNodePtr1 + 4);
          <Module>.free((void*) typeInfoNodePtr1);
          break;
        }
        typeInfoNodePtr2 = typeInfoNodePtr1;
      }
      <Module>.free((void*) *(int*) ((IntPtr) param0 + 4));
      *(int*) ((IntPtr) param0 + 4) = 0;
    }
    finally
    {
      if (flag)
      {
        <Module>._unlock(14);
        Thread.EndThreadAffinity();
      }
    }
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [HandleProcessCorruptedStateExceptions]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe sbyte* type_info._Name_base(type_info* __unnamed000, __type_info_node* __ptype_info_node)
  {
    if (*(int*) ((IntPtr) __unnamed000 + 4) == 0)
    {
      void* voidPtr1 = <Module>.__unDNameHelper((sbyte*) 0, (sbyte*) ((IntPtr) __unnamed000 + 9), 0, (ushort) 0);
      if ((IntPtr) voidPtr1 == IntPtr.Zero)
        return (sbyte*) 0;
      uint num = <Module>.strlen((sbyte*) voidPtr1);
      if (num > 0U)
      {
        do
        {
          --num;
          if ((int) *(sbyte*) ((IntPtr) voidPtr1 + (int) num) == 32)
            *(sbyte*) ((IntPtr) voidPtr1 + (int) num) = (sbyte) 0;
          else
            goto label_7;
        }
        while (num > 0U);
      }
      --num;
label_7:
      bool flag = false;
      RuntimeHelpers.PrepareConstrainedRegions();
      try
      {
        RuntimeHelpers.PrepareConstrainedRegions();
        try
        {
        }
        finally
        {
          Thread.BeginThreadAffinity();
          <Module>._lock(14);
          flag = true;
        }
        if (*(int*) ((IntPtr) __unnamed000 + 4) == 0)
        {
          __type_info_node* typeInfoNodePtr = (__type_info_node*) <Module>.malloc(8U);
          if ((IntPtr) typeInfoNodePtr != IntPtr.Zero)
          {
            void* voidPtr2 = <Module>.malloc(num + 2U);
            *(int*) ((IntPtr) __unnamed000 + 4) = (int) voidPtr2;
            if ((IntPtr) voidPtr2 != IntPtr.Zero)
            {
              if (<Module>.strcpy_s((sbyte*) voidPtr2, num + 2U, (sbyte*) voidPtr1) == 0)
              {
                *(int*) typeInfoNodePtr = *(int*) ((IntPtr) __unnamed000 + 4);
                *(int*) ((IntPtr) typeInfoNodePtr + 4) = *(int*) ((IntPtr) __ptype_info_node + 4);
                *(int*) ((IntPtr) __ptype_info_node + 4) = (int) typeInfoNodePtr;
                goto label_18;
              }
              else
                <Module>._invoke_watson((char*) 0, (char*) 0, (char*) 0, 0U, 0U);
            }
            <Module>.free((void*) typeInfoNodePtr);
          }
        }
label_18:
        <Module>.free(voidPtr1);
      }
      finally
      {
        if (flag)
        {
          <Module>._unlock(14);
          Thread.EndThreadAffinity();
        }
      }
    }
    return (sbyte*) *(int*) ((IntPtr) __unnamed000 + 4);
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [HandleProcessCorruptedStateExceptions]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void __clean_type_info_names_internal(__type_info_node* p_type_info_root_node)
  {
    bool flag = false;
    RuntimeHelpers.PrepareConstrainedRegions();
    try
    {
      RuntimeHelpers.PrepareConstrainedRegions();
      try
      {
      }
      finally
      {
        Thread.BeginThreadAffinity();
        <Module>._lock(14);
        flag = true;
      }
      __type_info_node* typeInfoNodePtr1 = (__type_info_node*) *(int*) ((IntPtr) p_type_info_root_node + 4);
      __type_info_node* typeInfoNodePtr2;
      for (; (IntPtr) typeInfoNodePtr1 != IntPtr.Zero; typeInfoNodePtr1 = typeInfoNodePtr2)
      {
        typeInfoNodePtr2 = (__type_info_node*) *(int*) ((IntPtr) typeInfoNodePtr1 + 4);
        <Module>.free((void*) *(int*) typeInfoNodePtr1);
        <Module>.free((void*) typeInfoNodePtr1);
      }
    }
    finally
    {
      if (flag)
      {
        <Module>._unlock(14);
        Thread.EndThreadAffinity();
      }
    }
  }

  [SecuritySafeCritical]
  internal static unsafe void __clean_type_info_names()
  {
    <Module>.__clean_type_info_names_internal(&<Module>.__type_info_root_node);
  }

  internal static unsafe void ?A0xbdc48617.??__E??_7type_info@@6B@@@YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @<Module>.??_7type_info@@6B@ = (int) &<Module>.??_R4type_info@@6B@;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    // ISSUE: method pointer
    ^(int&) ((IntPtr) &<Module>.??_7type_info@@6B@ + 4) = (int) __methodptr(type_info.__vecDelDtor);
  }

  internal static unsafe void ?A0xbdc48617.??__E??_R0?AVtype_info@@@8@@YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @<Module>.??_R0?AVtype_info@@@8 = (int) ((IntPtr) &<Module>.??_7type_info@@6B@ + 4);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R0?AVtype_info@@@8 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    // ISSUE: cpblk instruction
    __memcpy(($_TypeDescriptor$_extraBytes_16&) ((IntPtr) &<Module>.??_R0?AVtype_info@@@8 + 8), @<Module>.??_C@_0BA@NOJDBDJO@?4?$DPAVtype_info?$EA?$EA?$AA@, 16);
  }

  internal static unsafe void ?A0xbdc48617.??__E??_R1A@?0A@EA@type_info@@8@@YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @<Module>.??_R1A@?0A@EA@type_info@@8 = (int) &<Module>.??_R0?AVtype_info@@@8;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R1A@?0A@EA@type_info@@8 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R1A@?0A@EA@type_info@@8 + 8) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R1A@?0A@EA@type_info@@8 + 12) = -1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R1A@?0A@EA@type_info@@8 + 16) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R1A@?0A@EA@type_info@@8 + 20) = 64;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R1A@?0A@EA@type_info@@8 + 24) = (int) &<Module>.??_R3type_info@@8;
  }

  internal static unsafe void ?A0xbdc48617.??__E??_R2type_info@@8@@YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @<Module>.??_R2type_info@@8 = (int) &<Module>.??_R1A@?0A@EA@type_info@@8;
  }

  internal static unsafe void ?A0xbdc48617.??__E??_R3type_info@@8@@YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @<Module>.??_R3type_info@@8 = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R3type_info@@8 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R3type_info@@8 + 8) = 1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R3type_info@@8 + 12) = (int) &<Module>.??_R2type_info@@8;
  }

  internal static unsafe void ?A0xbdc48617.??__E??_R4type_info@@6B@@@YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @<Module>.??_R4type_info@@6B@ = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R4type_info@@6B@ + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R4type_info@@6B@ + 8) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R4type_info@@6B@ + 12) = (int) &<Module>.??_R0?AVtype_info@@@8;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R4type_info@@6B@ + 16) = (int) &<Module>.??_R3type_info@@8;
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SuppressUnmanagedCodeSecurity]
  [SecurityCritical]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern void _unlock(int _File);

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SuppressUnmanagedCodeSecurity]
  [SecurityCritical]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern void _lock(int _File);

  internal static void ?A0xb174b438.??__E?A0xb174b438@SA_Yes@@YMXXZ()
  {
    <Module>.?A0xb174b438.SA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void ?A0xb174b438.??__E?A0xb174b438@SA_No@@YMXXZ()
  {
    <Module>.?A0xb174b438.SA_No = (YesNoMaybe) 268369921;
  }

  internal static void ?A0xb174b438.??__E?A0xb174b438@SA_Maybe@@YMXXZ()
  {
    <Module>.?A0xb174b438.SA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void ?A0xb174b438.??__E?A0xb174b438@SA_NoAccess@@YMXXZ()
  {
    <Module>.?A0xb174b438.SA_NoAccess = (AccessType) 0;
  }

  internal static void ?A0xb174b438.??__E?A0xb174b438@SA_Read@@YMXXZ()
  {
    <Module>.?A0xb174b438.SA_Read = (AccessType) 1;
  }

  internal static void ?A0xb174b438.??__E?A0xb174b438@SA_Write@@YMXXZ()
  {
    <Module>.?A0xb174b438.SA_Write = (AccessType) 2;
  }

  internal static void ?A0xb174b438.??__E?A0xb174b438@SA_ReadWrite@@YMXXZ()
  {
    <Module>.?A0xb174b438.SA_ReadWrite = (AccessType) 3;
  }

  [DebuggerStepThrough]
  internal static ModuleHandle <CrtImplementationDetails>.ThisModule.Handle()
  {
    return typeof (ThisModule).Module.ModuleHandle;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void _initterm_m(__FnPtr<void* ()>* pfbegin, __FnPtr<void* ()>* pfend)
  {
    if (pfbegin >= pfend)
      return;
    do
    {
      uint num = (uint) *(int*) pfbegin;
      if ((int) num != 0)
      {
        // ISSUE: cast to a function pointer type
        // ISSUE: function pointer call
        void* voidPtr = __calli(<Module>.<CrtImplementationDetails>.ThisModule.ResolveMethod<void const * __clrcall(void)>((__FnPtr<void* ()>) (int) num))();
      }
      pfbegin += 4;
    }
    while (pfbegin < pfend);
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe __FnPtr<void* ()> <CrtImplementationDetails>.ThisModule.ResolveMethod<void const * __clrcall(void)>(__FnPtr<void* ()> methodToken)
  {
    // ISSUE: cast to a function pointer type
    return (__FnPtr<void* ()>) (IntPtr) <Module>.<CrtImplementationDetails>.ThisModule.Handle().ResolveMethodHandle((int) methodToken).GetFunctionPointer().ToPointer();
  }

  internal static void ?A0x9536fa44.??__E?A0x9536fa44@SA_Yes@@YMXXZ()
  {
    <Module>.?A0x9536fa44.SA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void ?A0x9536fa44.??__E?A0x9536fa44@SA_No@@YMXXZ()
  {
    <Module>.?A0x9536fa44.SA_No = (YesNoMaybe) 268369921;
  }

  internal static void ?A0x9536fa44.??__E?A0x9536fa44@SA_Maybe@@YMXXZ()
  {
    <Module>.?A0x9536fa44.SA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void ?A0x9536fa44.??__E?A0x9536fa44@SA_NoAccess@@YMXXZ()
  {
    <Module>.?A0x9536fa44.SA_NoAccess = (AccessType) 0;
  }

  internal static void ?A0x9536fa44.??__E?A0x9536fa44@SA_Read@@YMXXZ()
  {
    <Module>.?A0x9536fa44.SA_Read = (AccessType) 1;
  }

  internal static void ?A0x9536fa44.??__E?A0x9536fa44@SA_Write@@YMXXZ()
  {
    <Module>.?A0x9536fa44.SA_Write = (AccessType) 2;
  }

  internal static void ?A0x9536fa44.??__E?A0x9536fa44@SA_ReadWrite@@YMXXZ()
  {
    <Module>.?A0x9536fa44.SA_ReadWrite = (AccessType) 3;
  }

  [HandleProcessCorruptedStateExceptions]
  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  internal static unsafe void __ehvec_dtor(void* ptr, uint size, int count, __FnPtr<void (void*)> pDtor)
  {
    int num = 0;
    ptr = (void*) ((int) size * count + (IntPtr) ptr);
    try
    {
      while (true)
      {
        --count;
        if (count >= 0)
        {
          ptr -= (int) size;
          void* voidPtr = ptr;
          // ISSUE: function pointer call
          __calli(pDtor)(voidPtr);
        }
        else
          break;
      }
      num = 1;
    }
    finally
    {
      if (num == 0)
        <Module>.__ArrayUnwind(ptr, size, count, pDtor);
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe int ?A0x9536fa44.ArrayUnwindFilter(_EXCEPTION_POINTERS* pExPtrs)
  {
    if (*(int*) *(int*) pExPtrs != -529697949)
      return 0;
    <Module>.terminate();
    return 0;
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [HandleProcessCorruptedStateExceptions]
  [SecurityCritical]
  internal static unsafe void __ArrayUnwind(void* ptr, uint size, int count, __FnPtr<void (void*)> pDtor)
  {
    try
    {
      while (true)
      {
        --count;
        if (count >= 0)
        {
          ptr -= (int) size;
          void* voidPtr = ptr;
          // ISSUE: function pointer call
          __calli(pDtor)(voidPtr);
        }
        else
          break;
      }
    }
    catch (Exception ex) when (<Module>.?A0x9536fa44.ArrayUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  internal static void ?A0x000256ae.??__E?A0x000256ae@SA_Yes@@YMXXZ()
  {
    <Module>.?A0x000256ae.SA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void ?A0x000256ae.??__E?A0x000256ae@SA_No@@YMXXZ()
  {
    <Module>.?A0x000256ae.SA_No = (YesNoMaybe) 268369921;
  }

  internal static void ?A0x000256ae.??__E?A0x000256ae@SA_Maybe@@YMXXZ()
  {
    <Module>.?A0x000256ae.SA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void ?A0x000256ae.??__E?A0x000256ae@SA_NoAccess@@YMXXZ()
  {
    <Module>.?A0x000256ae.SA_NoAccess = (AccessType) 0;
  }

  internal static void ?A0x000256ae.??__E?A0x000256ae@SA_Read@@YMXXZ()
  {
    <Module>.?A0x000256ae.SA_Read = (AccessType) 1;
  }

  internal static void ?A0x000256ae.??__E?A0x000256ae@SA_Write@@YMXXZ()
  {
    <Module>.?A0x000256ae.SA_Write = (AccessType) 2;
  }

  internal static void ?A0x000256ae.??__E?A0x000256ae@SA_ReadWrite@@YMXXZ()
  {
    <Module>.?A0x000256ae.SA_ReadWrite = (AccessType) 3;
  }

  internal static unsafe void ?A0x000256ae.??__EInterfaceClassGuid@HIDBootLoader@@YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @<Module>.HIDBootLoader.InterfaceClassGuid = 1293833650;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ((IntPtr) &<Module>.HIDBootLoader.InterfaceClassGuid + 4) = (short) -3729;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ((IntPtr) &<Module>.HIDBootLoader.InterfaceClassGuid + 6) = (short) 4559;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &<Module>.HIDBootLoader.InterfaceClassGuid + 8) = (sbyte) -120;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &<Module>.HIDBootLoader.InterfaceClassGuid + 9) = (sbyte) -53;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &<Module>.HIDBootLoader.InterfaceClassGuid + 10) = (sbyte) 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &<Module>.HIDBootLoader.InterfaceClassGuid + 11) = (sbyte) 17;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &<Module>.HIDBootLoader.InterfaceClassGuid + 12) = (sbyte) 17;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &<Module>.HIDBootLoader.InterfaceClassGuid + 13) = (sbyte) 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &<Module>.HIDBootLoader.InterfaceClassGuid + 14) = (sbyte) 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &<Module>.HIDBootLoader.InterfaceClassGuid + 15) = (sbyte) 48;
  }

  internal static unsafe void ?A0x000256ae.??__EMyStructureWithDetailedInterfaceDataInIt@HIDBootLoader@@YMXXZ()
  {
    <Module>.HIDBootLoader.MyStructureWithDetailedInterfaceDataInIt = (_SP_DEVICE_INTERFACE_DETAIL_DATA_W*) <Module>.@new(6U);
  }

  internal static void ?A0x000256ae.??__EMyDeviceAttachedStatus@HIDBootLoader@@YMXXZ()
  {
    <Module>.HIDBootLoader.MyDeviceAttachedStatus = 0;
  }

  internal static void ?A0x000256ae.??__EErrorStatusWrite@HIDBootLoader@@YMXXZ()
  {
    <Module>.HIDBootLoader.ErrorStatusWrite = 0U;
  }

  internal static void ?A0x000256ae.??__EErrorStatusRead@HIDBootLoader@@YMXXZ()
  {
    <Module>.HIDBootLoader.ErrorStatusRead = 0U;
  }

  internal static void ?A0x000256ae.??__EStatus@HIDBootLoader@@YMXXZ()
  {
    <Module>.HIDBootLoader.Status = 0;
  }

  internal static void ?A0x000256ae.??__Eg_number_of_version@HIDBootLoader@@YMXXZ()
  {
    <Module>.HIDBootLoader.g_number_of_version = 0;
  }

  internal static void ?A0x000256ae.??__Eg_first_time@HIDBootLoader@@YMXXZ()
  {
    <Module>.HIDBootLoader.g_first_time = 0;
  }

  internal static void ?A0x000256ae.??__Eg_id@HIDBootLoader@@YMXXZ()
  {
    <Module>.HIDBootLoader.g_id = 0;
  }

  internal static unsafe void ?A0x000256ae.??__E??_R0PAD@8@@YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @<Module>.??_R0PAD@8 = ^(int&) @<Module>.??_7type_info@@6B@ + 4;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &<Module>.??_R0PAD@8 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    // ISSUE: cpblk instruction
    __memcpy(($_TypeDescriptor$_extraBytes_5&) ((IntPtr) &<Module>.??_R0PAD@8 + 8), @<Module>.??_C@_04GJGMPLND@?4PAD?$AA@, 5);
  }

  [STAThread]
  internal static int main(string[] args)
  {
    Application.EnableVisualStyles();
    Application.SetCompatibleTextRenderingDefault(false);
    Application.Run((Form) new Form1());
    return 0;
  }

  [DllImport("setupapi.dll", EntryPoint = "SetupDiGetDeviceInterfaceDetail", CharSet = CharSet.Unicode)]
  public static extern unsafe int SetupDiGetDeviceInterfaceDetailUM(void* DeviceInfoSet, _SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData, _SP_DEVICE_INTERFACE_DETAIL_DATA_W* DeviceInterfaceDetailData, uint DeviceInterfaceDetailDataSize, uint* RequiredSize, _SP_DEVINFO_DATA* DeviceInfoData);

  [DllImport("setupapi.dll", EntryPoint = "SetupDiGetDeviceRegistryProperty", CharSet = CharSet.Unicode)]
  public static extern unsafe int SetupDiGetDeviceRegistryPropertyUM(void* DeviceInfoSet, _SP_DEVINFO_DATA* DeviceInfoData, uint Property, uint* PropertyRegDataType, byte* PropertyBuffer, uint PropertyBufferSize, uint* RequiredSize);

  [DllImport("setupapi.dll", EntryPoint = "SetupDiEnumDeviceInfo", CharSet = CharSet.Unicode)]
  public static extern unsafe int SetupDiEnumDeviceInfoUM(void* DeviceInfoSet, uint MemberIndex, _SP_DEVINFO_DATA* DeviceInfoData);

  [DllImport("setupapi.dll", EntryPoint = "SetupDiDestroyDeviceInfoList", CharSet = CharSet.Unicode)]
  public static extern unsafe int SetupDiDestroyDeviceInfoListUM(void* DeviceInfoSet);

  [DllImport("setupapi.dll", EntryPoint = "SetupDiEnumDeviceInterfaces", CharSet = CharSet.Unicode)]
  public static extern unsafe int SetupDiEnumDeviceInterfacesUM(void* DeviceInfoSet, _SP_DEVINFO_DATA* DeviceInfoData, _GUID* InterfaceClassGuid, uint MemberIndex, _SP_DEVICE_INTERFACE_DATA* DeviceInterfaceData);

  [DllImport("setupapi.dll", EntryPoint = "SetupDiGetClassDevs", CharSet = CharSet.Unicode)]
  public static extern unsafe void* SetupDiGetClassDevsUM(_GUID* ClassGuid, char* Enumerator, HWND__* hwndParent, uint Flags);

  [DllImport("user32.dll", EntryPoint = "RegisterDeviceNotification", CharSet = CharSet.Unicode)]
  public static extern unsafe void* RegisterDeviceNotificationUM(void* hRecipient, void* NotificationFilter, uint Flags);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe void* __AdjustPointer([In] void* obj0, [In] PMD* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", EntryPoint = "?_inconsistency@@YAXXZ", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern void _inconsistency();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int _IsExceptionObjectToBeDestroyed([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", EntryPoint = "?terminate@@YAXXZ", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern void terminate();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", EntryPoint = "?_ValidateRead@@YAHPBXI@Z", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int _ValidateRead([In] void* obj0, [In] uint obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe FrameInfo* _CreateFrameInfo([In] FrameInfo* obj0, [In] void* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int strcmp([In] sbyte* obj0, [In] sbyte* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", EntryPoint = "?_ValidateWrite@@YAHPAXI@Z", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int _ValidateWrite([In] void* obj0, [In] uint obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe void _FindAndUnlinkFrame([In] FrameInfo* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", EntryPoint = "?_ValidateExecute@@YAHP6GHXZ@Z", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern int _ValidateExecute([In] __FnPtr<int ()> obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe void* memmove([In] void* obj0, [In] void* obj1, [In] uint obj2);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int __FrameUnwindFilter([In] _EXCEPTION_POINTERS* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", EntryPoint = "??3@YAXPAX@Z", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe void delete([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int strcpy_s([In] sbyte* obj0, [In] uint obj1, [In] sbyte* obj2);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe void* __unDNameHelper([In] sbyte* obj0, [In] sbyte* obj1, [In] int obj2, [In] ushort obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe uint strlen([In] sbyte* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe void* malloc([In] uint obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe void free([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe void _invoke_watson([In] char* obj0, [In] char* obj1, [In] char* obj2, [In] uint obj3, [In] uint obj4);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int remove([In] sbyte* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  internal static extern void Sleep([In] uint obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  internal static extern unsafe int SetEvent([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  internal static extern unsafe void* CreateEventW([In] _SECURITY_ATTRIBUTES* obj0, [In] int obj1, [In] int obj2, [In] char* obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  internal static extern uint GetTickCount();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  internal static extern unsafe int ReadFile([In] void* obj0, [In] void* obj1, [In] uint obj2, [In] uint* obj3, [In] _OVERLAPPED* obj4);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  internal static extern unsafe int WriteFile([In] void* obj0, [In] void* obj1, [In] uint obj2, [In] uint* obj3, [In] _OVERLAPPED* obj4);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  internal static extern unsafe int CloseHandle([In] void* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  internal static extern unsafe void* CreateFileW([In] char* obj0, [In] uint obj1, [In] uint obj2, [In] _SECURITY_ATTRIBUTES* obj3, [In] uint obj4, [In] uint obj5, [In] void* obj6);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("KERNEL32.dll", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
  internal static extern ushort GetSystemDefaultUILanguage();

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int ftell([In] _iobuf* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int fclose([In] _iobuf* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe uint fwrite([In] void* obj0, [In] uint obj1, [In] uint obj2, [In] _iobuf* obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe _iobuf* fopen([In] sbyte* obj0, [In] sbyte* obj1);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe uint fread([In] void* obj0, [In] uint obj1, [In] uint obj2, [In] _iobuf* obj3);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int fseek([In] _iobuf* obj0, [In] int obj1, [In] int obj2);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe int _mkdir([In] sbyte* obj0);

  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", EntryPoint = "??2@YAPAXI@Z", CallingConvention = CallingConvention.Cdecl, SetLastError = true)]
  internal static extern unsafe void* @new([In] uint obj0);
}
