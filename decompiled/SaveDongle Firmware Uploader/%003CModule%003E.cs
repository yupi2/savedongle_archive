// Decompiled with JetBrains decompiler
// Type: <Module>
// Assembly: HIDBootLoader, Version=1.0.4350.28629, Culture=neutral, PublicKeyToken=null
// MVID: C2ABEB73-C84E-41BA-807E-B4913B3F1A22
// Assembly location: C:\Temp\SaveDongle Firmware Uploader.exe

using \u003CCppImplementationDetails\u003E;
using \u003CCrtImplementationDetails\u003E;
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

internal class \u003CModule\u003E
{
  [FixedAddressValueType]
  internal static int \u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002E\u003FUninitialized\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0xfd8b67b9\u002E__xi_vt_a;
  [FixedAddressValueType]
  internal static double \u003FA0xfd8b67b9\u002E_HUGE;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xfd8b67b9\u002ESA_Write;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002E_HUGE\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002E\u003FInitializedPerAppDomain\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  [FixedAddressValueType]
  internal static double \u003FA0xfd8b67b9\u002EHUGE;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xfd8b67b9\u002ESA_NoAccess;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002ESA_NoAccess\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xfd8b67b9\u002ESA_ReadWrite;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002ESA_ReadWrite\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static bool \u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002E\u003FIsDefaultDomain\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xfd8b67b9\u002ESA_Yes;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002EHUGE\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002ESA_Write\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002ESA_Yes\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xfd8b67b9\u002ESA_Maybe;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0xfd8b67b9\u002E__xc_ma_a;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xfd8b67b9\u002ESA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xfd8b67b9\u002ESA_No;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002E\u003FInitializedNative\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  [FixedAddressValueType]
  internal static int \u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002E\u003FInitialized\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0xfd8b67b9\u002E__xc_ma_z;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002E\u003FInitializedVtables\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002ESA_Read\u0024initializer\u0024;
  internal static \u0024ArrayType\u0024\u0024\u0024BY00Q6MPBXXZ \u003FA0xfd8b67b9\u002E__xi_vt_z;
  [FixedAddressValueType]
  internal static Progress.State \u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002E\u003FInitializedPerProcess\u0024initializer\u0024\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2P6MXXZA;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002ESA_Maybe\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xfd8b67b9\u002ESA_No\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static uint __exit_list_size_app_domain;
  [FixedAddressValueType]
  internal static unsafe __FnPtr<void ()>* __onexitbegin_app_domain;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xc9f6eb9e\u002ESA_Write;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xc9f6eb9e\u002ESA_NoAccess;
  internal static __FnPtr<void ()> \u003FA0xc9f6eb9e\u002ESA_NoAccess\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xc9f6eb9e\u002ESA_ReadWrite;
  internal static __FnPtr<void ()> \u003FA0xc9f6eb9e\u002ESA_ReadWrite\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xc9f6eb9e\u002ESA_Yes;
  internal static __FnPtr<void ()> \u003FA0xc9f6eb9e\u002ESA_Write\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xc9f6eb9e\u002ESA_Yes\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xc9f6eb9e\u002ESA_Maybe;
  [FixedAddressValueType]
  internal static unsafe __FnPtr<void ()>* __onexitend_app_domain;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xc9f6eb9e\u002ESA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xc9f6eb9e\u002ESA_No;
  internal static __FnPtr<void ()> \u003FA0xc9f6eb9e\u002ESA_Read\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static unsafe void* \u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA;
  [FixedAddressValueType]
  internal static int \u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA;
  internal static __FnPtr<void ()> \u003FA0xc9f6eb9e\u002ESA_Maybe\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xc9f6eb9e\u002ESA_No\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x8bd98b91\u002ESA_Write;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x8bd98b91\u002ESA_NoAccess;
  internal static __FnPtr<void ()> \u003FA0x8bd98b91\u002ESA_NoAccess\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x8bd98b91\u002ESA_ReadWrite;
  internal static __FnPtr<void ()> \u003FA0x8bd98b91\u002ESA_ReadWrite\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0x8bd98b91\u002ESA_Yes;
  internal static __FnPtr<void ()> \u003FA0x8bd98b91\u002ESA_Write\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0x8bd98b91\u002ESA_Yes\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0x8bd98b91\u002ESA_Maybe;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x8bd98b91\u002ESA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0x8bd98b91\u002ESA_No;
  internal static __FnPtr<void ()> \u003FA0x8bd98b91\u002ESA_Read\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0x8bd98b91\u002ESA_Maybe\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0x8bd98b91\u002ESA_No\u0024initializer\u0024;
  internal static \u003F\u003F_C\u0040_0BA\u0040NOJDBDJO\u0040\u003F4\u003F\u0024DPAVtype_info\u003F\u0024EA\u003F\u0024EA\u003F\u0024AA\u0040\u0024\u0024BY0A\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_0BA\u0040NOJDBDJO\u0040\u003F4\u003F\u0024DPAVtype_info\u003F\u0024EA\u003F\u0024EA\u003F\u0024AA\u0040;
  [FixedAddressValueType]
  internal static \u0024_s__RTTIBaseClassArray\u0024_extraBytes_4 \u003F\u003F_R2type_info\u0040\u00408;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002E\u003F\u003F_R2type_info\u0040\u00408\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static _s__RTTICompleteObjectLocator \u003F\u003F_R4type_info\u0040\u00406B\u0040;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002E\u003F\u003F_R4type_info\u0040\u00406B\u0040\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static \u0024ArrayType\u0024\u0024\u0024BY01Q6MXXZ \u003F\u003F_7type_info\u0040\u00406B\u0040;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xbdc48617\u002ESA_Write;
  [FixedAddressValueType]
  internal static _s__RTTIClassHierarchyDescriptor \u003F\u003F_R3type_info\u0040\u00408;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xbdc48617\u002ESA_NoAccess;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002ESA_NoAccess\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xbdc48617\u002ESA_ReadWrite;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002ESA_ReadWrite\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xbdc48617\u002ESA_Yes;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002ESA_Write\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002ESA_Yes\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xbdc48617\u002ESA_Maybe;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002E\u003F\u003F_R3type_info\u0040\u00408\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xbdc48617\u002ESA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xbdc48617\u002ESA_No;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002ESA_Read\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static \u0024_TypeDescriptor\u0024_extraBytes_16 \u003F\u003F_R0\u003FAVtype_info\u0040\u0040\u00408;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002E\u003F\u003F_R0\u003FAVtype_info\u0040\u0040\u00408\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002ESA_Maybe\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002E\u003F\u003F_7type_info\u0040\u00406B\u0040\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002ESA_No\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static _s__RTTIBaseClassDescriptor2 \u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408;
  [FixedAddressValueType]
  internal static __type_info_node __type_info_root_node;
  internal static __FnPtr<void ()> \u003FA0xbdc48617\u002E\u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xb174b438\u002ESA_Write;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xb174b438\u002ESA_NoAccess;
  internal static __FnPtr<void ()> \u003FA0xb174b438\u002ESA_NoAccess\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xb174b438\u002ESA_ReadWrite;
  internal static __FnPtr<void ()> \u003FA0xb174b438\u002ESA_ReadWrite\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xb174b438\u002ESA_Yes;
  internal static __FnPtr<void ()> \u003FA0xb174b438\u002ESA_Write\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xb174b438\u002ESA_Yes\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xb174b438\u002ESA_Maybe;
  [FixedAddressValueType]
  internal static AccessType \u003FA0xb174b438\u002ESA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0xb174b438\u002ESA_No;
  internal static __FnPtr<void ()> \u003FA0xb174b438\u002ESA_Read\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xb174b438\u002ESA_Maybe\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0xb174b438\u002ESA_No\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x9536fa44\u002ESA_Write;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x9536fa44\u002ESA_NoAccess;
  internal static __FnPtr<void ()> \u003FA0x9536fa44\u002ESA_NoAccess\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x9536fa44\u002ESA_ReadWrite;
  internal static __FnPtr<void ()> \u003FA0x9536fa44\u002ESA_ReadWrite\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0x9536fa44\u002ESA_Yes;
  internal static __FnPtr<void ()> \u003FA0x9536fa44\u002ESA_Write\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0x9536fa44\u002ESA_Yes\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0x9536fa44\u002ESA_Maybe;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x9536fa44\u002ESA_Read;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0x9536fa44\u002ESA_No;
  internal static __FnPtr<void ()> \u003FA0x9536fa44\u002ESA_Read\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0x9536fa44\u002ESA_Maybe\u0024initializer\u0024;
  internal static __FnPtr<void ()> \u003FA0x9536fa44\u002ESA_No\u0024initializer\u0024;
  internal static \u003F\u003F_C\u0040_07BNLNPKOB\u0040c\u003F3\u003F2Temp\u003F\u0024AA\u0040\u0024\u0024BY0A\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_07BNLNPKOB\u0040c\u003F3\u003F2Temp\u003F\u0024AA\u0040;
  internal static \u003F\u003F_C\u0040_02GMLFBBN\u0040wb\u003F\u0024AA\u0040\u0024\u0024BY0A\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_02GMLFBBN\u0040wb\u003F\u0024AA\u0040;
  internal static \u003F\u003F_C\u0040_0BA\u0040BJPDJJDH\u0040c\u003F3\u003F2Temp\u003F2tmp\u003F4tmp\u003F\u0024AA\u0040\u0024\u0024BY0A\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_0BA\u0040BJPDJJDH\u0040c\u003F3\u003F2Temp\u003F2tmp\u003F4tmp\u003F\u0024AA\u0040;
  internal static \u003F\u003F_C\u0040_02JDPG\u0040rb\u003F\u0024AA\u0040\u0024\u0024BY0A\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_02JDPG\u0040rb\u003F\u0024AA\u0040;
  internal static \u003F\u003F_C\u0040_0L\u0040BKPAMLJP\u0040WriteEvent\u003F\u0024AA\u0040\u0024\u0024BY0A\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_0L\u0040BKPAMLJP\u0040WriteEvent\u003F\u0024AA\u0040;
  internal static \u003F\u003F_C\u0040_0M\u0040INNKCKGP\u0040WriteEvent2\u003F\u0024AA\u0040\u0024\u0024BY0A\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_0M\u0040INNKCKGP\u0040WriteEvent2\u003F\u0024AA\u0040;
  internal static \u003F\u003F_C\u0040_09PIDNBOJN\u0040ReadEvent\u003F\u0024AA\u0040\u0024\u0024BY0A\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_09PIDNBOJN\u0040ReadEvent\u003F\u0024AA\u0040;
  internal static \u003F\u003F_C\u0040_04GJGMPLND\u0040\u003F4PAD\u003F\u0024AA\u0040\u0024\u0024BY0A\u0040\u0024\u0024CBD \u003F\u003F_C\u0040_04GJGMPLND\u0040\u003F4PAD\u003F\u0024AA\u0040;
  [FixedAddressValueType]
  internal static \u0024_TypeDescriptor\u0024_extraBytes_5 \u003F\u003F_R0PAD\u00408;
  internal static __FnPtr<void ()> \u003FA0x000256ae\u002E\u003F\u003F_R0PAD\u00408\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static g_pszSourcePath\u0024\u0024BY0A\u0040D HIDBootLoader\u002Eg_pszSourcePath;
  [FixedAddressValueType]
  internal static g_index\u0024\u0024BY0A\u0040H HIDBootLoader\u002Eg_index;
  [FixedAddressValueType]
  internal static hexinfo\u0024\u0024BY0A\u0040UHEX_INFO\u0040HIDBootLoader\u0040\u0040 HIDBootLoader\u002Ehexinfo;
  [FixedAddressValueType]
  internal static hex_description\u0024\u0024BY1A\u0040CAA\u0040D HIDBootLoader\u002Ehex_description;
  [FixedAddressValueType]
  internal static int HIDBootLoader\u002Eg_id;
  internal static __FnPtr<void ()> HIDBootLoader\u002E\u003FA0x000256ae\u002Eg_id\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static int HIDBootLoader\u002Eg_first_time;
  internal static __FnPtr<void ()> HIDBootLoader\u002E\u003FA0x000256ae\u002Eg_first_time\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static int HIDBootLoader\u002Eg_number_of_version;
  internal static __FnPtr<void ()> HIDBootLoader\u002E\u003FA0x000256ae\u002Eg_number_of_version\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static int HIDBootLoader\u002EStatus;
  internal static __FnPtr<void ()> HIDBootLoader\u002E\u003FA0x000256ae\u002EStatus\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static uint HIDBootLoader\u002EErrorStatusRead;
  internal static __FnPtr<void ()> HIDBootLoader\u002E\u003FA0x000256ae\u002EErrorStatusRead\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static uint HIDBootLoader\u002EErrorStatusWrite;
  internal static __FnPtr<void ()> HIDBootLoader\u002E\u003FA0x000256ae\u002EErrorStatusWrite\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static int HIDBootLoader\u002EMyDeviceAttachedStatus;
  internal static __FnPtr<void ()> HIDBootLoader\u002E\u003FA0x000256ae\u002EMyDeviceAttachedStatus\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static unsafe _SP_DEVICE_INTERFACE_DETAIL_DATA_W* HIDBootLoader\u002EMyStructureWithDetailedInterfaceDataInIt;
  internal static __FnPtr<void ()> HIDBootLoader\u002E\u003FA0x000256ae\u002EMyStructureWithDetailedInterfaceDataInIt\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static _GUID HIDBootLoader\u002EInterfaceClassGuid;
  internal static __FnPtr<void ()> HIDBootLoader\u002E\u003FA0x000256ae\u002EInterfaceClassGuid\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static encryptedFF\u0024\u0024BY0A\u0040E encryptedFF;
  [FixedAddressValueType]
  internal static byte encryptionBlockSize;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x000256ae\u002ESA_ReadWrite;
  internal static __FnPtr<void ()> \u003FA0x000256ae\u002ESA_ReadWrite\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x000256ae\u002ESA_Write;
  internal static __FnPtr<void ()> \u003FA0x000256ae\u002ESA_Write\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x000256ae\u002ESA_Read;
  internal static __FnPtr<void ()> \u003FA0x000256ae\u002ESA_Read\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static AccessType \u003FA0x000256ae\u002ESA_NoAccess;
  internal static __FnPtr<void ()> \u003FA0x000256ae\u002ESA_NoAccess\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0x000256ae\u002ESA_Maybe;
  internal static __FnPtr<void ()> \u003FA0x000256ae\u002ESA_Maybe\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0x000256ae\u002ESA_No;
  internal static __FnPtr<void ()> \u003FA0x000256ae\u002ESA_No\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static YesNoMaybe \u003FA0x000256ae\u002ESA_Yes;
  internal static __FnPtr<void ()> \u003FA0x000256ae\u002ESA_Yes\u0024initializer\u0024;
  [FixedAddressValueType]
  internal static int __\u0040\u0040_PchSym_\u004000\u0040UDwhUkDsfyUnrxilxsrkOyllgolzwviOfhyOsrwOeCOGySgsvLhlugdzivLuliLfhysrwxBILygoTUnrxilxsrkOyllgolzwviOfhyOsrwOeCOGyUivovzhvUhgwzucOlyq\u0040;

  [SecurityCritical]
  [DebuggerStepThrough]
  static unsafe \u003CModule\u003E()
  {
    LanguageSupport languageSupport;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bctor\u007D(&languageSupport);
    // ISSUE: fault handler
    try
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitialize(&languageSupport);
    }
    __fault
    {
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.___CxxCallUnwindDtor((__FnPtr<void (void*)>) __methodptr(\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bdtor\u007D), (void*) &languageSupport);
    }
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bdtor\u007D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) &languageSupport);
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FA0xfd8b67b9\u0040SA_Yes\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xfd8b67b9\u002ESA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FA0xfd8b67b9\u0040SA_No\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xfd8b67b9\u002ESA_No = (YesNoMaybe) 268369921;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FA0xfd8b67b9\u0040SA_Maybe\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xfd8b67b9\u002ESA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FA0xfd8b67b9\u0040SA_NoAccess\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xfd8b67b9\u002ESA_NoAccess = (AccessType) 0;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FA0xfd8b67b9\u0040SA_Read\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xfd8b67b9\u002ESA_Read = (AccessType) 1;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FA0xfd8b67b9\u0040SA_Write\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xfd8b67b9\u002ESA_Write = (AccessType) 2;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FA0xfd8b67b9\u0040SA_ReadWrite\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xfd8b67b9\u002ESA_ReadWrite = (AccessType) 3;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FA0xfd8b67b9\u0040_HUGE\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xfd8b67b9\u002E_HUGE = double.PositiveInfinity;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FA0xfd8b67b9\u0040HUGE\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xfd8b67b9\u002EHUGE = \u003CModule\u003E.\u003FA0xfd8b67b9\u002E_HUGE;
  }

  [SecurityCritical]
  internal static int _atexit_m(__FnPtr<void ()> _Function)
  {
    return \u003CModule\u003E._atexit_m_appdomain(_Function);
  }

  [SecurityCritical]
  internal static int atexit(__FnPtr<void ()> _Function)
  {
    return \u003CModule\u003E._atexit_m_appdomain(_Function);
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(Exception innerException, Exception nestedException)
  {
    throw new ModuleLoadExceptionHandlerException("A nested exception occurred after the primary exception that caused the C++ module to fail to load.\n", innerException, nestedException);
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002EThrowModuleLoadException(string errorMessage, Exception innerException)
  {
    throw new ModuleLoadException(errorMessage, innerException);
  }

  internal static void \u003CCrtImplementationDetails\u003E\u002ERegisterModuleUninitializer(EventHandler handler)
  {
    ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 0;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 0;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA = false;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedNative\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedPerProcess\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  internal static void \u003FA0xfd8b67b9\u002E\u003F\u003F__E\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 0;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeVtables([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during vtable initialization.\n");
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 1;
    \u003CModule\u003E._initterm_m((__FnPtr<void* ()>*) &\u003CModule\u003E.\u003FA0xfd8b67b9\u002E__xi_vt_a, (__FnPtr<void* ()>*) &\u003CModule\u003E.\u003FA0xfd8b67b9\u002E__xi_vt_z);
    \u003CModule\u003E.\u003FInitializedVtables\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 2;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerAppDomain([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during appdomain initialization.\n");
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 1;
    \u003CModule\u003E._initatexit_app_domain();
    \u003CModule\u003E._initterm_m((__FnPtr<void* ()>*) &\u003CModule\u003E.\u003FA0xfd8b67b9\u002E__xc_ma_a, (__FnPtr<void* ()>*) &\u003CModule\u003E.\u003FA0xfd8b67b9\u002E__xc_ma_z);
    \u003CModule\u003E.\u003FInitializedPerAppDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2W4State\u0040Progress\u00402\u0040A = (Progress.State) 2;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeUninitializer([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load during registration for the unload events.\n");
    EventHandler handler = new EventHandler(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EDomainUnload);
    ModuleUninitializer._ModuleUninitializer.AddHandler(handler);
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_Initialize([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.\u003FIsDefaultDomain\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2_NA = AppDomain.CurrentDomain.IsDefaultAppDomain();
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeVtables(obj0);
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializePerAppDomain(obj0);
    \u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA = 1;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitializeUninitializer(obj0);
  }

  [SecurityCritical]
  internal static void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeAppDomain()
  {
    \u003CModule\u003E._app_exit_callback();
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [PrePrepareMethod]
  internal static void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EDomainUnload(object source, EventArgs arguments)
  {
    if (\u003CModule\u003E.\u003FInitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA == 0 || Interlocked.Exchange(ref \u003CModule\u003E.\u003FUninitialized\u0040CurrentDomain\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q2HA, 1) != 0)
      return;
    \u003CModule\u003E._app_exit_callback();
  }

  [DebuggerStepThrough]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup([In] LanguageSupport* obj0, Exception innerException)
  {
    try
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EUninitializeAppDomain();
    }
    catch (Exception ex)
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(innerException, ex);
    }
    catch
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThrowNestedModuleLoadException(innerException, (Exception) null);
    }
  }

  [SecurityCritical]
  internal static unsafe LanguageSupport* \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bctor\u007D([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bctor\u007D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0);
    return obj0;
  }

  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E\u007Bdtor\u007D([In] LanguageSupport* obj0)
  {
    \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bdtor\u007D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0);
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [DebuggerStepThrough]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002EInitialize([In] LanguageSupport* obj0)
  {
    try
    {
      \u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0, "The C++ module failed to load.\n");
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002E_Initialize(obj0);
    }
    catch (Exception ex)
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup(obj0, ex);
      throw new ModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0), ex);
    }
    catch
    {
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002ELanguageSupport\u002ECleanup(obj0, (Exception) null);
      throw new ModuleLoadException(\u003CModule\u003E.gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040((gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E*) obj0), (Exception) null);
    }
  }

  [DebuggerStepThrough]
  [SecuritySafeCritical]
  internal static unsafe gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bctor\u007D([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    IntPtr num = (IntPtr) GCHandle.Alloc((object) null);
    *(int*) obj0 = (int) num.ToPointer();
    return obj0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u007Bdtor\u007D([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    (GCHandle) new IntPtr((void*) *(int*) obj0).Free();
    *(int*) obj0 = 0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u003D([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0, string t)
  {
    (GCHandle) new IntPtr((void*) *(int*) obj0).Target = (object) t;
    return obj0;
  }

  [SecuritySafeCritical]
  internal static unsafe string gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E\u002E\u002EP\u0024AAVString\u0040System\u0040\u0040([In] gcroot\u003CSystem\u003A\u003AString\u0020\u005E\u003E* obj0)
  {
    return (string) (GCHandle) new IntPtr((void*) *(int*) obj0).Target;
  }

  internal static void \u003FA0xc9f6eb9e\u002E\u003F\u003F__E\u003FA0xc9f6eb9e\u0040SA_Yes\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xc9f6eb9e\u002ESA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void \u003FA0xc9f6eb9e\u002E\u003F\u003F__E\u003FA0xc9f6eb9e\u0040SA_No\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xc9f6eb9e\u002ESA_No = (YesNoMaybe) 268369921;
  }

  internal static void \u003FA0xc9f6eb9e\u002E\u003F\u003F__E\u003FA0xc9f6eb9e\u0040SA_Maybe\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xc9f6eb9e\u002ESA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void \u003FA0xc9f6eb9e\u002E\u003F\u003F__E\u003FA0xc9f6eb9e\u0040SA_NoAccess\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xc9f6eb9e\u002ESA_NoAccess = (AccessType) 0;
  }

  internal static void \u003FA0xc9f6eb9e\u002E\u003F\u003F__E\u003FA0xc9f6eb9e\u0040SA_Read\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xc9f6eb9e\u002ESA_Read = (AccessType) 1;
  }

  internal static void \u003FA0xc9f6eb9e\u002E\u003F\u003F__E\u003FA0xc9f6eb9e\u0040SA_Write\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xc9f6eb9e\u002ESA_Write = (AccessType) 2;
  }

  internal static void \u003FA0xc9f6eb9e\u002E\u003F\u003F__E\u003FA0xc9f6eb9e\u0040SA_ReadWrite\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xc9f6eb9e\u002ESA_ReadWrite = (AccessType) 3;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe ValueType \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle()
  {
    if ((IntPtr) \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA != IntPtr.Zero)
      return (ValueType) GCHandle.FromIntPtr(new IntPtr(\u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA));
    return (ValueType) null;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Construct(object value)
  {
    \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA = (void*) 0;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Set(value);
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Set(object value)
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle();
    if (valueType == null)
      \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA = GCHandle.ToIntPtr(GCHandle.Alloc(value)).ToPointer();
    else
      ((GCHandle) valueType).Target = value;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static object \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get()
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle();
    if (valueType != null)
      return ((GCHandle) valueType).Target;
    return (object) null;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Destruct()
  {
    ValueType valueType = \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_handle();
    if (valueType == null)
      return;
    ((GCHandle) valueType).Free();
    \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA = (void*) 0;
  }

  [DebuggerStepThrough]
  [SecuritySafeCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized()
  {
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get() != null;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EAddRef()
  {
    if (!\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      \u003CModule\u003E.\u003F_lock\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0PAXA = (void*) 0;
      \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Set(new object());
      \u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA = 0;
    }
    ++\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA;
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002ERemoveRef()
  {
    --\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA;
    if (\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA != 0)
      return;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Destruct();
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EEnter()
  {
    Monitor.Enter(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get());
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static void \u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EExit()
  {
    Monitor.Exit(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get());
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003FA0xc9f6eb9e\u002E__global_lock()
  {
    bool flag = false;
    if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      Monitor.Enter(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get());
      flag = true;
    }
    return flag;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003FA0xc9f6eb9e\u002E__global_unlock()
  {
    bool flag = false;
    if (\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized())
    {
      Monitor.Exit(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Get());
      flag = true;
    }
    return flag;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static bool \u003FA0xc9f6eb9e\u002E__alloc_global_lock()
  {
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EAddRef();
    return \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002EIsInitialized();
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static void \u003FA0xc9f6eb9e\u002E__dealloc_global_lock()
  {
    --\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA;
    if (\u003CModule\u003E.\u003F_ref_count\u0040AtExitLock\u0040\u003CCrtImplementationDetails\u003E\u0040\u0040\u0024\u0024Q0HA != 0)
      return;
    \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EAtExitLock\u002E_lock_Destruct();
  }

  [SecurityCritical]
  internal static unsafe int _atexit_helper(__FnPtr<void ()> func, uint* __pexit_list_size, __FnPtr<void ()>** __ponexitend_e, __FnPtr<void ()>** __ponexitbegin_e)
  {
    // ISSUE: cast to a function pointer type
    __FnPtr<void ()> local1 = (__FnPtr<void ()>) 0;
    if (func == null)
      return -1;
    int num1;
    if (\u003CModule\u003E.\u003FA0xc9f6eb9e\u002E__global_lock())
    {
      try
      {
        __FnPtr<void ()>* local2 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) *(int*) __ponexitbegin_e);
        __FnPtr<void ()>* local3 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) *(int*) __ponexitend_e);
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
        *(int*) __ponexitbegin_e = (int) \u003CModule\u003E.EncodePointer((void*) local2);
        *(int*) __ponexitend_e = (int) \u003CModule\u003E.EncodePointer((void*) local4);
      }
      catch (OutOfMemoryException ex)
      {
      }
      finally
      {
        \u003CModule\u003E.\u003FA0xc9f6eb9e\u002E__global_unlock();
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
    if (\u003CModule\u003E.\u003FA0xc9f6eb9e\u002E__alloc_global_lock())
    {
      \u003CModule\u003E.__onexitbegin_app_domain = (__FnPtr<void ()>*) \u003CModule\u003E.EncodePointer(Marshal.AllocHGlobal(128).ToPointer());
      \u003CModule\u003E.__onexitend_app_domain = \u003CModule\u003E.__onexitbegin_app_domain;
      \u003CModule\u003E.__exit_list_size_app_domain = 32U;
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E._atexit_m_appdomain((__FnPtr<void ()>) __methodptr(__clean_type_info_names));
    }
    return 1;
  }

  [HandleProcessCorruptedStateExceptions]
  [SecurityCritical]
  internal static unsafe void _app_exit_callback()
  {
    if ((int) \u003CModule\u003E.__exit_list_size_app_domain == 0)
      return;
    __FnPtr<void ()>* local1 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitbegin_app_domain);
    __FnPtr<void ()>* local2 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitend_app_domain);
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
          while (local2 >= local1 && (IntPtr) *(int*) local2 == (IntPtr) \u003CModule\u003E._encoded_null());
          if (local2 >= local1)
          {
            // ISSUE: cast to a function pointer type
            __FnPtr<void ()> local7 = (__FnPtr<void ()>) (IntPtr) \u003CModule\u003E.DecodePointer((void*) *(int*) local2);
            *(int*) local2 = (int) \u003CModule\u003E._encoded_null();
            // ISSUE: function pointer call
            __calli(local7)();
            local5 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitbegin_app_domain);
            local6 = (__FnPtr<void ()>*) \u003CModule\u003E.DecodePointer((void*) \u003CModule\u003E.__onexitend_app_domain);
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
      \u003CModule\u003E.\u003FA0xc9f6eb9e\u002E__dealloc_global_lock();
    }
  }

  [SecurityCritical]
  internal static __FnPtr<int ()> _onexit_m_appdomain(__FnPtr<int ()> _Function)
  {
    // ISSUE: cast to a function pointer type
    if (\u003CModule\u003E._atexit_m_appdomain((__FnPtr<void ()>) _Function) != -1)
      return _Function;
    // ISSUE: cast to a function pointer type
    return (__FnPtr<int ()>) 0;
  }

  [DebuggerStepThrough]
  [SecurityCritical]
  internal static unsafe int _atexit_m_appdomain(__FnPtr<void ()> func)
  {
    // ISSUE: cast to a function pointer type
    return \u003CModule\u003E._atexit_helper((__FnPtr<void ()>) (IntPtr) \u003CModule\u003E.EncodePointer((void*) func), &\u003CModule\u003E.__exit_list_size_app_domain, &\u003CModule\u003E.__onexitend_app_domain, &\u003CModule\u003E.__onexitbegin_app_domain);
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

  internal static void \u003FA0x8bd98b91\u002E\u003F\u003F__E\u003FA0x8bd98b91\u0040SA_Yes\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x8bd98b91\u002ESA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void \u003FA0x8bd98b91\u002E\u003F\u003F__E\u003FA0x8bd98b91\u0040SA_No\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x8bd98b91\u002ESA_No = (YesNoMaybe) 268369921;
  }

  internal static void \u003FA0x8bd98b91\u002E\u003F\u003F__E\u003FA0x8bd98b91\u0040SA_Maybe\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x8bd98b91\u002ESA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void \u003FA0x8bd98b91\u002E\u003F\u003F__E\u003FA0x8bd98b91\u0040SA_NoAccess\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x8bd98b91\u002ESA_NoAccess = (AccessType) 0;
  }

  internal static void \u003FA0x8bd98b91\u002E\u003F\u003F__E\u003FA0x8bd98b91\u0040SA_Read\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x8bd98b91\u002ESA_Read = (AccessType) 1;
  }

  internal static void \u003FA0x8bd98b91\u002E\u003F\u003F__E\u003FA0x8bd98b91\u0040SA_Write\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x8bd98b91\u002ESA_Write = (AccessType) 2;
  }

  internal static void \u003FA0x8bd98b91\u002E\u003F\u003F__E\u003FA0x8bd98b91\u0040SA_ReadWrite\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x8bd98b91\u002ESA_ReadWrite = (AccessType) 3;
  }

  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static void \u003FA0x8bd98b91\u002E__DestructExceptionObject_m(EHExceptionRecord* pExcept, byte fThrowNotAllowed)
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
          if ((int) num1 == -529697949 && *(int*) ((IntPtr) pExcept + 16) == 3 && (*(int*) ((IntPtr) pExcept + 20) == 26820608 || *(int*) ((IntPtr) pExcept + 28) == 0) && (*(int*) ((IntPtr) pExcept + 28) == 0 && *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) == 0))
            return 0;
          IntPtr num2 = (IntPtr) \u003CModule\u003E._getptd() + 144;
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
        if (*(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) == 0)
          return 0;
        pExcept = (EHExceptionRecord*) *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136);
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
          if (\u003CModule\u003E.\u003FA0x8bd98b91\u002ETypeMatch\u003Cstruct\u0020_s_HandlerType\u002Cstruct\u0020_s_CatchableType\u0020const\u0020\u002Cstruct\u0020_s_ThrowInfo\u0020const\u0020\u003E(&sHandlerType, sCatchableTypePtr2, (_s_ThrowInfo*) *(int*) ((IntPtr) pExcept + 28)) == 0)
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
        IntPtr num3 = (IntPtr) \u003CModule\u003E._getptd() + 144;
        int num4 = *(int*) num3 + 1;
        *(int*) num3 = num4;
        if ((IntPtr) pBuildObj != IntPtr.Zero)
          \u003CModule\u003E.\u003FA0x8bd98b91\u002EBuildCatchObject\u003Cstruct\u0020_s_HandlerType\u002Cstruct\u0020_s_CatchableType\u0020const\u0020\u003E(pExcept, pBuildObj, &sHandlerType, sCatchableTypePtr2);
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
          ehExceptionRecordPtr = (EHExceptionRecord*) *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136);
        \u003CModule\u003E._CreateFrameInfo((FrameInfo*) pStorage, (void*) *(int*) ((IntPtr) ehExceptionRecordPtr + 24));
        *(int*) ((IntPtr) pStorage + 8) = *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136);
        *(int*) ((IntPtr) pStorage + 8 + 4) = *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 140);
        *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) = (int) ehExceptionRecordPtr;
        goto label_6;
      }
    }
    *(int*) ((IntPtr) pStorage + 8) = -1;
    *(int*) ((IntPtr) pStorage + 8 + 4) = -1;
label_6:
    IntPtr num1 = (IntPtr) \u003CModule\u003E._getptd() + 144;
    int num2 = *(int*) num1 - 1;
    *(int*) num1 = num2;
    if (*(int*) ((IntPtr) \u003CModule\u003E._getptd() + 144) < 0)
      *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 144) = 0;
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
    IntPtr num1 = (IntPtr) \u003CModule\u003E._getptd() + 144;
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
    \u003CModule\u003E._FindAndUnlinkFrame((FrameInfo*) pStorage);
    if (rethrow == 0 && *(int*) *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) == -529697949 && *(int*) (*(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) + 16) == 3 && ((*(int*) (*(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) + 20) == 26820608 || *(int*) (*(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) + 28) == 0) && \u003CModule\u003E._IsExceptionObjectToBeDestroyed((void*) *(int*) (*(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) + 24)) != 0))
      \u003CModule\u003E.\u003FA0x8bd98b91\u002E__DestructExceptionObject_m((EHExceptionRecord*) *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136), (byte) 1);
    if (*(int*) *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) == -529697949 && *(int*) (*(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) + 16) == 3 && (*(int*) (*(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) + 20) == 26820608 || *(int*) (*(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) + 28) == 0) && rethrow != 0)
    {
      IntPtr num1 = (IntPtr) \u003CModule\u003E._getptd() + 144;
      int num2 = *(int*) num1 - 1;
      *(int*) num1 = num2;
    }
    *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 136) = *(int*) ehExceptionRecordPtr;
    *(int*) ((IntPtr) \u003CModule\u003E._getptd() + 140) = *(int*) contextPtr;
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
    catch (Exception ex) when (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
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
    catch (Exception ex) when (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
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
    catch (Exception ex) when (\u003CModule\u003E.__FrameUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecuritySafeCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe int \u003FA0x8bd98b91\u002ETypeMatch\u003Cstruct\u0020_s_HandlerType\u002Cstruct\u0020_s_CatchableType\u0020const\u0020\u002Cstruct\u0020_s_ThrowInfo\u0020const\u0020\u003E(_s_HandlerType* pCatch, _s_CatchableType* pCatchable, _s_ThrowInfo* pThrow)
  {
    uint num1 = (uint) *(int*) ((IntPtr) pCatch + 4);
    if ((int) num1 != 0)
    {
      int num2 = (int) num1 + 8;
      if ((int) *(sbyte*) num2 != 0)
      {
        uint num3 = (uint) *(int*) ((IntPtr) pCatchable + 4);
        if ((int) num1 != (int) num3 && \u003CModule\u003E.strcmp((sbyte*) num2, (sbyte*) ((int) num3 + 8)) != 0)
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
  internal static unsafe void \u003FA0x8bd98b91\u002EBuildCatchObject\u003Cstruct\u0020_s_HandlerType\u002Cstruct\u0020_s_CatchableType\u0020const\u0020\u003E(EHExceptionRecord* pExcept, void* pRN, _s_HandlerType* pCatch, _s_CatchableType* pConv)
  {
    if ((*(int*) pCatch & int.MinValue) == 0)
      \u003CModule\u003E._inconsistency();
    try
    {
      switch (\u003CModule\u003E.\u003FA0x8bd98b91\u002EBuildCatchObjectHelper\u003Cstruct\u0020_s_HandlerType\u002Cstruct\u0020_s_CatchableType\u0020const\u0020\u003E(pExcept, pRN, pCatch, pConv))
      {
        case 1:
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          __calli((__FnPtr<void (void*, void*)>) *(int*) ((IntPtr) pConv + 24))(pRN, \u003CModule\u003E.__AdjustPointer((void*) *(int*) ((IntPtr) pExcept + 24), (PMD*) ((IntPtr) pConv + 8)));
          break;
        case 2:
          // ISSUE: cast to a function pointer type
          // ISSUE: function pointer call
          __calli((__FnPtr<void (void*, void*, int)>) *(int*) ((IntPtr) pConv + 24))((int) pRN, \u003CModule\u003E.__AdjustPointer((void*) *(int*) ((IntPtr) pExcept + 24), (PMD*) ((IntPtr) pConv + 8)), (void*) 1);
          break;
      }
    }
    catch (Exception ex) when (1 != 0)
    {
      \u003CModule\u003E.terminate();
    }
  }

  [SecurityCritical]
  [HandleProcessCorruptedStateExceptions]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe int \u003FA0x8bd98b91\u002EBuildCatchObjectHelper\u003Cstruct\u0020_s_HandlerType\u002Cstruct\u0020_s_CatchableType\u0020const\u0020\u003E(EHExceptionRecord* pExcept, void* pRN, _s_HandlerType* pCatch, _s_CatchableType* pConv)
  {
    int num1 = 0;
    uint num2 = (uint) *(int*) ((IntPtr) pCatch + 4);
    if ((int) num2 == 0 || (int) *(sbyte*) ((int) num2 + 8) == 0 || *(int*) ((IntPtr) pCatch + 8) == 0 && (*(int*) pCatch & int.MinValue) == 0)
      return 0;
    if ((*(int*) pCatch & int.MinValue) == 0)
      \u003CModule\u003E._inconsistency();
    try
    {
      if ((*(int*) pCatch & 8) != 0)
      {
        if (\u003CModule\u003E._ValidateRead((void*) *(int*) ((IntPtr) pExcept + 24), 1U) != 0 && \u003CModule\u003E._ValidateWrite(pRN, 1U) != 0)
        {
          int num3 = *(int*) ((IntPtr) pExcept + 24);
          *(int*) pRN = num3;
          *(int*) pRN = (int) \u003CModule\u003E.__AdjustPointer((void*) num3, (PMD*) ((IntPtr) pConv + 8));
        }
        else
          \u003CModule\u003E._inconsistency();
      }
      else if ((*(int*) pConv & 1) != 0)
      {
        if (\u003CModule\u003E._ValidateRead((void*) *(int*) ((IntPtr) pExcept + 24), 1U) != 0 && \u003CModule\u003E._ValidateWrite(pRN, 1U) != 0)
        {
          \u003CModule\u003E.memmove(pRN, (void*) *(int*) ((IntPtr) pExcept + 24), (uint) *(int*) ((IntPtr) pConv + 20));
          if (*(int*) ((IntPtr) pConv + 20) == 4)
          {
            uint num3 = (uint) *(int*) pRN;
            if ((int) num3 != 0)
              *(int*) pRN = (int) \u003CModule\u003E.__AdjustPointer((void*) num3, (PMD*) ((IntPtr) pConv + 8));
          }
        }
        else
          \u003CModule\u003E._inconsistency();
      }
      else if (*(int*) ((IntPtr) pConv + 24) == 0)
      {
        if (\u003CModule\u003E._ValidateRead((void*) *(int*) ((IntPtr) pExcept + 24), 1U) != 0 && \u003CModule\u003E._ValidateWrite(pRN, 1U) != 0)
          \u003CModule\u003E.memmove(pRN, \u003CModule\u003E.__AdjustPointer((void*) *(int*) ((IntPtr) pExcept + 24), (PMD*) ((IntPtr) pConv + 8)), (uint) *(int*) ((IntPtr) pConv + 20));
        else
          \u003CModule\u003E._inconsistency();
      }
      else
      {
        // ISSUE: cast to a function pointer type
        if (\u003CModule\u003E._ValidateRead((void*) *(int*) ((IntPtr) pExcept + 24), 1U) != 0 && \u003CModule\u003E._ValidateWrite(pRN, 1U) != 0 && \u003CModule\u003E._ValidateExecute((__FnPtr<int ()>) *(int*) ((IntPtr) pConv + 24)) != 0)
          num1 = (*(int*) pConv & 4) != 0 ? 2 : 1;
        else
          \u003CModule\u003E._inconsistency();
      }
    }
    catch (Exception ex) when (1 != 0)
    {
      \u003CModule\u003E.terminate();
    }
    return num1;
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SuppressUnmanagedCodeSecurity]
  [DllImport("MSVCR100.dll", CallingConvention = CallingConvention.Cdecl)]
  public static extern unsafe _tiddata* _getptd();

  internal static void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003FA0xbdc48617\u0040SA_Yes\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xbdc48617\u002ESA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003FA0xbdc48617\u0040SA_No\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xbdc48617\u002ESA_No = (YesNoMaybe) 268369921;
  }

  internal static void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003FA0xbdc48617\u0040SA_Maybe\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xbdc48617\u002ESA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003FA0xbdc48617\u0040SA_NoAccess\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xbdc48617\u002ESA_NoAccess = (AccessType) 0;
  }

  internal static void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003FA0xbdc48617\u0040SA_Read\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xbdc48617\u002ESA_Read = (AccessType) 1;
  }

  internal static void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003FA0xbdc48617\u0040SA_Write\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xbdc48617\u002ESA_Write = (AccessType) 2;
  }

  internal static void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003FA0xbdc48617\u0040SA_ReadWrite\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xbdc48617\u002ESA_ReadWrite = (AccessType) 3;
  }

  [SecurityCritical]
  internal static unsafe void _invoke_watson_if_error(int _ExpressionError, char* _Expression, char* _Function, char* _File, uint _Line, uint _Reserved)
  {
    if (_ExpressionError == 0)
      return;
    \u003CModule\u003E._invoke_watson(_Expression, _Function, _File, _Line, _Reserved);
  }

  [SecurityCritical]
  internal static unsafe sbyte* type_info\u002Ename([In] type_info* obj0, __type_info_node* __ptype_info_node)
  {
    return \u003CModule\u003E.type_info\u002E_Name_base(obj0, __ptype_info_node);
  }

  [SecurityCritical]
  internal static unsafe void type_info\u002E\u007Bdtor\u007D([In] type_info* obj0)
  {
    *(int*) obj0 = (int) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_7type_info\u0040\u00406B\u0040 + 4);
    \u003CModule\u003E.type_info\u002E_Type_info_dtor(obj0);
  }

  internal static unsafe void* type_info\u002E__vecDelDtor([In] type_info* obj0, uint _param2)
  {
    if (((int) param1 & 2) != 0)
    {
      type_info* typeInfoPtr = (type_info*) ((IntPtr) obj0 - 4);
      // ISSUE: method pointer
      // ISSUE: cast to a function pointer type
      \u003CModule\u003E.__ehvec_dtor((void*) obj0, 12U, *(int*) typeInfoPtr, (__FnPtr<void (void*)>) __methodptr(type_info\u002E\u007Bdtor\u007D));
      if (((int) param1 & 1) != 0)
        \u003CModule\u003E.delete((void*) typeInfoPtr);
      return (void*) typeInfoPtr;
    }
    *(int*) obj0 = (int) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_7type_info\u0040\u00406B\u0040 + 4);
    \u003CModule\u003E.type_info\u002E_Type_info_dtor(obj0);
    if (((int) param1 & 1) != 0)
      \u003CModule\u003E.delete((void*) obj0);
    return (void*) obj0;
  }

  [SecuritySafeCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool type_info\u002E\u003D\u003D([In] type_info* obj0, type_info* _Rhs)
  {
    return \u003CModule\u003E.strcmp((sbyte*) ((IntPtr) _Rhs + 9), (sbyte*) ((IntPtr) obj0 + 9)) == 0;
  }

  [SecuritySafeCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  [return: MarshalAs(UnmanagedType.U1)]
  internal static unsafe bool type_info\u002E\u0021\u003D([In] type_info* obj0, type_info* _Rhs)
  {
    return \u003CModule\u003E.strcmp((sbyte*) ((IntPtr) _Rhs + 9), (sbyte*) ((IntPtr) obj0 + 9)) != 0;
  }

  [SecuritySafeCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe int type_info\u002Ebefore([In] type_info* obj0, type_info* _Rhs)
  {
    return \u003CModule\u003E.strcmp((sbyte*) ((IntPtr) _Rhs + 9), (sbyte*) ((IntPtr) obj0 + 9)) > 0 ? 1 : 0;
  }

  [SecuritySafeCritical]
  internal static unsafe sbyte* type_info\u002Eraw_name([In] type_info* obj0)
  {
    return (sbyte*) ((IntPtr) obj0 + 8);
  }

  [HandleProcessCorruptedStateExceptions]
  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe void type_info\u002E_Type_info_dtor(type_info* _param1)
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
        \u003CModule\u003E._lock(14);
        flag = true;
      }
      uint num = (uint) *(int*) ((IntPtr) param0 + 4);
      if ((int) num == 0)
        return;
      // ISSUE: cast to a reference type
      // ISSUE: explicit reference operation
      __type_info_node* typeInfoNodePtr1 = (__type_info_node*) ^(int&) ((IntPtr) &\u003CModule\u003E.__type_info_root_node + 4);
      __type_info_node* typeInfoNodePtr2 = &\u003CModule\u003E.__type_info_root_node;
      for (; (IntPtr) typeInfoNodePtr1 != IntPtr.Zero; typeInfoNodePtr1 = typeInfoNodePtr1)
      {
        if (*(int*) typeInfoNodePtr1 == (int) num)
        {
          *(int*) ((IntPtr) typeInfoNodePtr2 + 4) = *(int*) ((IntPtr) typeInfoNodePtr1 + 4);
          \u003CModule\u003E.free((void*) typeInfoNodePtr1);
          break;
        }
        typeInfoNodePtr2 = typeInfoNodePtr1;
      }
      \u003CModule\u003E.free((void*) *(int*) ((IntPtr) param0 + 4));
      *(int*) ((IntPtr) param0 + 4) = 0;
    }
    finally
    {
      if (flag)
      {
        \u003CModule\u003E._unlock(14);
        Thread.EndThreadAffinity();
      }
    }
  }

  [SecurityCritical]
  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [HandleProcessCorruptedStateExceptions]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe sbyte* type_info\u002E_Name_base(type_info* __unnamed000, __type_info_node* __ptype_info_node)
  {
    if (*(int*) ((IntPtr) __unnamed000 + 4) == 0)
    {
      void* voidPtr1 = \u003CModule\u003E.__unDNameHelper((sbyte*) 0, (sbyte*) ((IntPtr) __unnamed000 + 9), 0, (ushort) 0);
      if ((IntPtr) voidPtr1 == IntPtr.Zero)
        return (sbyte*) 0;
      uint num = \u003CModule\u003E.strlen((sbyte*) voidPtr1);
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
          \u003CModule\u003E._lock(14);
          flag = true;
        }
        if (*(int*) ((IntPtr) __unnamed000 + 4) == 0)
        {
          __type_info_node* typeInfoNodePtr = (__type_info_node*) \u003CModule\u003E.malloc(8U);
          if ((IntPtr) typeInfoNodePtr != IntPtr.Zero)
          {
            void* voidPtr2 = \u003CModule\u003E.malloc(num + 2U);
            *(int*) ((IntPtr) __unnamed000 + 4) = (int) voidPtr2;
            if ((IntPtr) voidPtr2 != IntPtr.Zero)
            {
              if (\u003CModule\u003E.strcpy_s((sbyte*) voidPtr2, num + 2U, (sbyte*) voidPtr1) == 0)
              {
                *(int*) typeInfoNodePtr = *(int*) ((IntPtr) __unnamed000 + 4);
                *(int*) ((IntPtr) typeInfoNodePtr + 4) = *(int*) ((IntPtr) __ptype_info_node + 4);
                *(int*) ((IntPtr) __ptype_info_node + 4) = (int) typeInfoNodePtr;
                goto label_18;
              }
              else
                \u003CModule\u003E._invoke_watson((char*) 0, (char*) 0, (char*) 0, 0U, 0U);
            }
            \u003CModule\u003E.free((void*) typeInfoNodePtr);
          }
        }
label_18:
        \u003CModule\u003E.free(voidPtr1);
      }
      finally
      {
        if (flag)
        {
          \u003CModule\u003E._unlock(14);
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
        \u003CModule\u003E._lock(14);
        flag = true;
      }
      __type_info_node* typeInfoNodePtr1 = (__type_info_node*) *(int*) ((IntPtr) p_type_info_root_node + 4);
      __type_info_node* typeInfoNodePtr2;
      for (; (IntPtr) typeInfoNodePtr1 != IntPtr.Zero; typeInfoNodePtr1 = typeInfoNodePtr2)
      {
        typeInfoNodePtr2 = (__type_info_node*) *(int*) ((IntPtr) typeInfoNodePtr1 + 4);
        \u003CModule\u003E.free((void*) *(int*) typeInfoNodePtr1);
        \u003CModule\u003E.free((void*) typeInfoNodePtr1);
      }
    }
    finally
    {
      if (flag)
      {
        \u003CModule\u003E._unlock(14);
        Thread.EndThreadAffinity();
      }
    }
  }

  [SecuritySafeCritical]
  internal static unsafe void __clean_type_info_names()
  {
    \u003CModule\u003E.__clean_type_info_names_internal(&\u003CModule\u003E.__type_info_root_node);
  }

  internal static unsafe void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003F\u003F_7type_info\u0040\u00406B\u0040\u0040\u0040YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @\u003CModule\u003E.\u003F\u003F_7type_info\u0040\u00406B\u0040 = (int) &\u003CModule\u003E.\u003F\u003F_R4type_info\u0040\u00406B\u0040;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    // ISSUE: method pointer
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_7type_info\u0040\u00406B\u0040 + 4) = (int) __methodptr(type_info\u002E__vecDelDtor);
  }

  internal static unsafe void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003F\u003F_R0\u003FAVtype_info\u0040\u0040\u00408\u0040\u0040YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @\u003CModule\u003E.\u003F\u003F_R0\u003FAVtype_info\u0040\u0040\u00408 = (int) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_7type_info\u0040\u00406B\u0040 + 4);
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R0\u003FAVtype_info\u0040\u0040\u00408 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    // ISSUE: cpblk instruction
    __memcpy((\u0024_TypeDescriptor\u0024_extraBytes_16&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R0\u003FAVtype_info\u0040\u0040\u00408 + 8), @\u003CModule\u003E.\u003F\u003F_C\u0040_0BA\u0040NOJDBDJO\u0040\u003F4\u003F\u0024DPAVtype_info\u003F\u0024EA\u003F\u0024EA\u003F\u0024AA\u0040, 16);
  }

  internal static unsafe void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408\u0040\u0040YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @\u003CModule\u003E.\u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408 = (int) &\u003CModule\u003E.\u003F\u003F_R0\u003FAVtype_info\u0040\u0040\u00408;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408 + 8) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408 + 12) = -1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408 + 16) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408 + 20) = 64;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408 + 24) = (int) &\u003CModule\u003E.\u003F\u003F_R3type_info\u0040\u00408;
  }

  internal static unsafe void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003F\u003F_R2type_info\u0040\u00408\u0040\u0040YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @\u003CModule\u003E.\u003F\u003F_R2type_info\u0040\u00408 = (int) &\u003CModule\u003E.\u003F\u003F_R1A\u0040\u003F0A\u0040EA\u0040type_info\u0040\u00408;
  }

  internal static unsafe void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003F\u003F_R3type_info\u0040\u00408\u0040\u0040YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @\u003CModule\u003E.\u003F\u003F_R3type_info\u0040\u00408 = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R3type_info\u0040\u00408 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R3type_info\u0040\u00408 + 8) = 1;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R3type_info\u0040\u00408 + 12) = (int) &\u003CModule\u003E.\u003F\u003F_R2type_info\u0040\u00408;
  }

  internal static unsafe void \u003FA0xbdc48617\u002E\u003F\u003F__E\u003F\u003F_R4type_info\u0040\u00406B\u0040\u0040\u0040YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @\u003CModule\u003E.\u003F\u003F_R4type_info\u0040\u00406B\u0040 = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R4type_info\u0040\u00406B\u0040 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R4type_info\u0040\u00406B\u0040 + 8) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R4type_info\u0040\u00406B\u0040 + 12) = (int) &\u003CModule\u003E.\u003F\u003F_R0\u003FAVtype_info\u0040\u0040\u00408;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R4type_info\u0040\u00406B\u0040 + 16) = (int) &\u003CModule\u003E.\u003F\u003F_R3type_info\u0040\u00408;
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

  internal static void \u003FA0xb174b438\u002E\u003F\u003F__E\u003FA0xb174b438\u0040SA_Yes\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xb174b438\u002ESA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void \u003FA0xb174b438\u002E\u003F\u003F__E\u003FA0xb174b438\u0040SA_No\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xb174b438\u002ESA_No = (YesNoMaybe) 268369921;
  }

  internal static void \u003FA0xb174b438\u002E\u003F\u003F__E\u003FA0xb174b438\u0040SA_Maybe\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xb174b438\u002ESA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void \u003FA0xb174b438\u002E\u003F\u003F__E\u003FA0xb174b438\u0040SA_NoAccess\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xb174b438\u002ESA_NoAccess = (AccessType) 0;
  }

  internal static void \u003FA0xb174b438\u002E\u003F\u003F__E\u003FA0xb174b438\u0040SA_Read\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xb174b438\u002ESA_Read = (AccessType) 1;
  }

  internal static void \u003FA0xb174b438\u002E\u003F\u003F__E\u003FA0xb174b438\u0040SA_Write\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xb174b438\u002ESA_Write = (AccessType) 2;
  }

  internal static void \u003FA0xb174b438\u002E\u003F\u003F__E\u003FA0xb174b438\u0040SA_ReadWrite\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0xb174b438\u002ESA_ReadWrite = (AccessType) 3;
  }

  [DebuggerStepThrough]
  internal static ModuleHandle \u003CCrtImplementationDetails\u003E\u002EThisModule\u002EHandle()
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
        void* voidPtr = __calli(\u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThisModule\u002EResolveMethod\u003Cvoid\u0020const\u0020\u002A\u0020__clrcall\u0028void\u0029\u003E((__FnPtr<void* ()>) (int) num))();
      }
      pfbegin += 4;
    }
    while (pfbegin < pfend);
  }

  [SecurityCritical]
  [DebuggerStepThrough]
  internal static unsafe __FnPtr<void* ()> \u003CCrtImplementationDetails\u003E\u002EThisModule\u002EResolveMethod\u003Cvoid\u0020const\u0020\u002A\u0020__clrcall\u0028void\u0029\u003E(__FnPtr<void* ()> methodToken)
  {
    // ISSUE: cast to a function pointer type
    return (__FnPtr<void* ()>) (IntPtr) \u003CModule\u003E.\u003CCrtImplementationDetails\u003E\u002EThisModule\u002EHandle().ResolveMethodHandle((int) methodToken).GetFunctionPointer().ToPointer();
  }

  internal static void \u003FA0x9536fa44\u002E\u003F\u003F__E\u003FA0x9536fa44\u0040SA_Yes\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x9536fa44\u002ESA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void \u003FA0x9536fa44\u002E\u003F\u003F__E\u003FA0x9536fa44\u0040SA_No\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x9536fa44\u002ESA_No = (YesNoMaybe) 268369921;
  }

  internal static void \u003FA0x9536fa44\u002E\u003F\u003F__E\u003FA0x9536fa44\u0040SA_Maybe\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x9536fa44\u002ESA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void \u003FA0x9536fa44\u002E\u003F\u003F__E\u003FA0x9536fa44\u0040SA_NoAccess\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x9536fa44\u002ESA_NoAccess = (AccessType) 0;
  }

  internal static void \u003FA0x9536fa44\u002E\u003F\u003F__E\u003FA0x9536fa44\u0040SA_Read\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x9536fa44\u002ESA_Read = (AccessType) 1;
  }

  internal static void \u003FA0x9536fa44\u002E\u003F\u003F__E\u003FA0x9536fa44\u0040SA_Write\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x9536fa44\u002ESA_Write = (AccessType) 2;
  }

  internal static void \u003FA0x9536fa44\u002E\u003F\u003F__E\u003FA0x9536fa44\u0040SA_ReadWrite\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x9536fa44\u002ESA_ReadWrite = (AccessType) 3;
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
        \u003CModule\u003E.__ArrayUnwind(ptr, size, count, pDtor);
    }
  }

  [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
  [SecurityCritical]
  [SecurityPermission(SecurityAction.Assert, UnmanagedCode = true)]
  internal static unsafe int \u003FA0x9536fa44\u002EArrayUnwindFilter(_EXCEPTION_POINTERS* pExPtrs)
  {
    if (*(int*) *(int*) pExPtrs != -529697949)
      return 0;
    \u003CModule\u003E.terminate();
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
    catch (Exception ex) when (\u003CModule\u003E.\u003FA0x9536fa44\u002EArrayUnwindFilter((_EXCEPTION_POINTERS*) Marshal.GetExceptionPointers()) != 0)
    {
    }
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__E\u003FA0x000256ae\u0040SA_Yes\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x000256ae\u002ESA_Yes = (YesNoMaybe) 268370176;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__E\u003FA0x000256ae\u0040SA_No\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x000256ae\u002ESA_No = (YesNoMaybe) 268369921;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__E\u003FA0x000256ae\u0040SA_Maybe\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x000256ae\u002ESA_Maybe = (YesNoMaybe) 268369936;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__E\u003FA0x000256ae\u0040SA_NoAccess\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x000256ae\u002ESA_NoAccess = (AccessType) 0;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__E\u003FA0x000256ae\u0040SA_Read\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x000256ae\u002ESA_Read = (AccessType) 1;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__E\u003FA0x000256ae\u0040SA_Write\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x000256ae\u002ESA_Write = (AccessType) 2;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__E\u003FA0x000256ae\u0040SA_ReadWrite\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.\u003FA0x000256ae\u002ESA_ReadWrite = (AccessType) 3;
  }

  internal static unsafe void \u003FA0x000256ae\u002E\u003F\u003F__EInterfaceClassGuid\u0040HIDBootLoader\u0040\u0040YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid = 1293833650;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ((IntPtr) &\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid + 4) = (short) -3729;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(short&) ((IntPtr) &\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid + 6) = (short) 4559;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid + 8) = (sbyte) -120;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid + 9) = (sbyte) -53;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid + 10) = (sbyte) 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid + 11) = (sbyte) 17;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid + 12) = (sbyte) 17;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid + 13) = (sbyte) 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid + 14) = (sbyte) 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(sbyte&) ((IntPtr) &\u003CModule\u003E.HIDBootLoader\u002EInterfaceClassGuid + 15) = (sbyte) 48;
  }

  internal static unsafe void \u003FA0x000256ae\u002E\u003F\u003F__EMyStructureWithDetailedInterfaceDataInIt\u0040HIDBootLoader\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.HIDBootLoader\u002EMyStructureWithDetailedInterfaceDataInIt = (_SP_DEVICE_INTERFACE_DETAIL_DATA_W*) \u003CModule\u003E.@new(6U);
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__EMyDeviceAttachedStatus\u0040HIDBootLoader\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.HIDBootLoader\u002EMyDeviceAttachedStatus = 0;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__EErrorStatusWrite\u0040HIDBootLoader\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.HIDBootLoader\u002EErrorStatusWrite = 0U;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__EErrorStatusRead\u0040HIDBootLoader\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.HIDBootLoader\u002EErrorStatusRead = 0U;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__EStatus\u0040HIDBootLoader\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.HIDBootLoader\u002EStatus = 0;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__Eg_number_of_version\u0040HIDBootLoader\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.HIDBootLoader\u002Eg_number_of_version = 0;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__Eg_first_time\u0040HIDBootLoader\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.HIDBootLoader\u002Eg_first_time = 0;
  }

  internal static void \u003FA0x000256ae\u002E\u003F\u003F__Eg_id\u0040HIDBootLoader\u0040\u0040YMXXZ()
  {
    \u003CModule\u003E.HIDBootLoader\u002Eg_id = 0;
  }

  internal static unsafe void \u003FA0x000256ae\u002E\u003F\u003F__E\u003F\u003F_R0PAD\u00408\u0040\u0040YMXXZ()
  {
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    // ISSUE: explicit reference operation
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) @\u003CModule\u003E.\u003F\u003F_R0PAD\u00408 = ^(int&) @\u003CModule\u003E.\u003F\u003F_7type_info\u0040\u00406B\u0040 + 4;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    ^(int&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R0PAD\u00408 + 4) = 0;
    // ISSUE: cast to a reference type
    // ISSUE: explicit reference operation
    // ISSUE: cpblk instruction
    __memcpy((\u0024_TypeDescriptor\u0024_extraBytes_5&) ((IntPtr) &\u003CModule\u003E.\u003F\u003F_R0PAD\u00408 + 8), @\u003CModule\u003E.\u003F\u003F_C\u0040_04GJGMPLND\u0040\u003F4PAD\u003F\u0024AA\u0040, 5);
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
