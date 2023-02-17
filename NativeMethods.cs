//----------------------------------------------------------------------------
// Project		:	SecretLock
//
//----------------------------------------------------------------------------
// Programmer	:	Christian "Tipplin" Kurs
//----------------------------------------------------------------------------
// Part         :	Secret1.exe - Console Application at Fall creators Update
//              :   Console Application is a legacy Application.
//              :   Complete NEW !!! - with many Features !
//              :   Console Window is the Windows Operation System Window !!!.
//              :   faster, smaller, little Overhead than a Form/Window.
//              :   directly ! - write Console App with Resource Library and
//              :   Cursor-size from 0 _ to 100 ##
//              :   New Console-Colors, Console Word WrapUp, Console dragging
//              :   minimal to maximal, Console Title changed,
//              :   System-Menu now with copy, can marked Text and copy and
//              :   insert in a Editor text.
//              :   Console Legacy Application is Windows Host Service.
//              :   Function Library to call the inside Functions.
//              :   Resource Library: Visual.Resource.Library.dll 
//              :   pure Resources: icons, images, photos, music, sound, text 
//              :   and more - 
//-----------------------------------------------------------------------------
// Base Class	:	Program - change to static class Program
//-----------------------------------------------------------------------------
// After Migration from .NET Framework 4.8 to .NET7 following important
// differences:
// 1. namespace Secrets2 at end with semnicolon ; includes the signs {}
// 2. Microsoft have change DllImport Attribute to LibraryImport Attribute
// but same settings.
//
// 3. NOT all System Assemblies with namespaces for use in .NET7
// 4. The property of Project have new properties.
// 5.
// 6.
//-----------------------------------------------------------------------------
// Copyright © 2017-2023,
// by Visual Galaxy Framework Community Kernel Developer Team.
//-----------------------------------------------------------------------------
// by Head-Author: Christian "Tipplin" Kurs - Visual C# Senior Developer
// Portions Copyright © 1982-2023 by Microsoft Corporation GmbH.
//-----------------------------------------------------------------------------
// Same sourcecode by Microsoft, so we marked with Copyright !.
// © 1982-2023 - Copyrights by Microsoft: Images, Icons, Signs, Gadgets, 
// Copyright © and Tradewark by Microsoft Windows, Windows Logo, Visual Studio
// ---------------------------------------------------------------------------
//--------------------------------- -------------------------------------------
//
// written by 		Christian "Tipplin" Kurs
// 				    Ahornweg 1
//					-G - 53177 Bonn
//					Germany - Allemagne - Duitsland
//----------------------------------------------------------------------------
//					international phone	:	00-49-1734593440
//					Skype				:
//					e-mail				:	kurschristian@gmail.de
//					my Website Community:	in progress
//					
//----------------------------------------------------------------------------
// This software is supplied as is. Use it at your own  RISK !!!!.
// Obviously I've tried to do the best job possible.
// If you find any problem with it, let me know.
//
// With any luck, Visual Galaxy Framework will make it obsolete anyway
//----------------------------------------------------------------------------
// License:	
//				NO fee for NON-Commercial use.
//				our Community Website: 
//				
//				in progress
//
//				Honest Business Users, to use our compiled Versions, 
//				please call us to send you our Business Licenses.
//				or our Business Website:
//				
//				in progress
//
//----------------------------------------------------------------------------
//----------------------------------------------------------------------------
//-------------------------- Project History ---------------------------------
//----------------------------------------------------------------------------
// Release 0.0.0 - 2017/01/01 - TIPPO - KC - Project Founder - Initial
//----------------------------------------------------------------------------
// Commentary:
// [VGF.NET - 01]
//
//
//
//----------------------------------------------------------------------------
// Definition:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Improvement:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// New Feature:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Task:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Class:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Method:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
// Property:
// [VGF.NET - 01]
//
//----------------------------------------------------------------------------
//
//######################## Other notable Changes #############################
//
// Other:
// [VGF.NET - 01] 
//
//----------------------------------------------------------------------------
// Bug:
// [VGF.NET - 01]
// Timer Control 
//----------------------------------------------------------------------------
// Fixes:
//[VGF.NET - Bug 01]
// Tipplin forget Timer, set directly in Console program.cs the call for the
// Image Form.
//---------------------------------------------------------------------------- 
// Miscellous:
// .1 insert Windows form to Console Project for Splash.
// Console Window goes at Runtime in resize Window, show the Image Form,
// unload method the Image Form in program.cs after Thread.Sleep(7000);
// Resize the Console Window normal, show all relevant Informations for User,
// what have the Console App done.(Settings for user and more.)
// For User: NO Personal Datas have use or write into a File, only machinename
// username that's all.
//
// 
// 
// 
//############################################################################# 

/* ########################################################################
     * ######                                                             #####
     * ###### Visual.Function.Library.dll - written in Visual C/C++      ######
     * ######                                                            ######
     * ########################################################################
     * ------------------------------------------------------------------------
     * return value	for .NET	Functionname					parameter
     * ------------------------------------------------------------------------
     * 
     * 
     *
     *-------------------------------------------------------------------------
     * ExternNativeFunctions - Our native Visual.Function.Library.dll
     * written Visual C/C++, set __stdcall inside.
     * ------------------------------------------------------------------------
    */
// first Alternate:
// set NamespaceBundle with Namespace inside for use in this Project.

/*using NamespaceBundle.StartUp3;

// using have avantage to namespace, so you must write the NamespaceBundle here
// NamespaceBundle miscellous namespaces

namespace NamespaceBundle
{
    // namespace 1
    namespace StartUp1 { };
    namespace StartUp2 { };
    namespace StartUp3 { };

};

*/

// second Alternate:
// our written Assembly static, pure resources (text, icons, images, photo, sound, music, signs...)
// NO Class, Methods...
// !!! ATTENTION !!! visual Studio Resource manage Standard is internal, so NO access to Resources,
// change to public over Menue item, so you have access outside use to Resources.
// Here: Visual.Resource.Library.dll
// using Visual.Resource.Library.Properties;
//----show---blendUp--automatic--Resourcename
// BackgroundImage = <Resources>.BigBen;

// third Alternate:
// parts(codes) or more or File from a other Project-Solution for into this project,
// <include file = '' path = '[@name=""]' />

// fourth Alternate:
// set you namespace here out Project-Solution
// using namespacename;






global using System;
global using System.Runtime.InteropServices;

//
//
//
namespace SecretLock;

internal static class NativeMethods
{

    /// <summary>
    /// Our defined MessageBox with only one Parameter TextID as integer
    /// inside Visual.Function.Library.dll a pure native C Library, as
    /// CHAR ARRAY (Textarray) defined.
    /// </summary>
    /// <param name="TextID">
    ///     Set integer Value for TextID
    ///     inside CHAR ARRAY TEXT from 1 to 24 as Textarray
    /// </param>
    /// <returns>
    /// 
    /// </returns>
    [DllImport("VFL.dll", EntryPoint = "VFLMessageBox", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern int VFLMessageBox(int TextID);

    /// <summary>
    ///     Our defined Warning MessageBoxes
    /// </summary>
    /// <param name="MessageID">
    /// 
    /// </param>
    /// <returns>
    /// 
    /// </returns>
    [DllImport("VFL.dll", EntryPoint = "VFLWarningMessageBox", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    internal static extern int VFLWarningMessageBox(int MessageID);

    /// <summary>
    ///     Multi Beep with Frequency and Duration
    /// </summary>
    /// <param name="Frequency">please set only hearbar frequencies</param>
    /// <param name="Duration">please set minimal Value, longest is 2000000000 ,not possible!</param>
    /// <remarks>
    ///     can set Values for Police Siren or more, with loops.
    ///     have found Old Amiga Operation System Internal Handbook with frequency-list to Notes c, d, cis, dis....
    ///     and Voice-Arts: Bariton, Alt....
    /// </remarks>
    /// <returns>
    /// 
    /// </returns>
    [DllImport("VFL.dll", EntryPoint = "VFLMultiBeep", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool VFLMultiBeep(uint Frequency, uint Duration);

    /// <summary>
    /// Animate a Window with Slide In
    /// </summary>
    /// <param name="WindowHandle">Set Handle to Window</param>
    /// <param name="SlideTime">Set the Time for Slide - 200 to 500</param>
    /// <returns></returns>
    [DllImport("VFL.dll", EntryPoint = "VFLWindowAnimate", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool VFLWindowAnimate(IntPtr WindowHandle, uint SlideTime);

    /// <summary>
    /// Counts Dynamic Link Library Calls
    /// </summary>
    /// <param name="FreeCalls">Set free count calls</param>
    /// <remarks>
    ///     set inside, a inline counter and Exit ! terminate App and Component !.
    /// </remarks>
    [DllImport("VFL.dll", EntryPoint = "VFLDLLCalls", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    internal static extern void VFLDLLCalls(uint FreeCalls);

    /// <summary>
    ///     Lock the current Workstation, your PC/Computer/Machine
    /// </summary>
    /// <remarks>
    ///     Than the Computer show the Lock Screen, 
    ///     click so you must be new LogIn.
    ///     The current User as click or taste, so the current User Account is locked !!!.
    ///     A other User click on Screen and show the Log On Scree, 
    ///     he must be logIn with Password in own User Account !!!.
    ///     Windows 10 Professional/Enterprise are - NOW:
    ///     Multi User Operation System with User Accounts (Windows User Account Database inside!)
    ///     So one User or more on ONE PC/Computer !!!.
    ///     More Secrets with Windows 10 Professional/Enterprise (Limit RAM 2 Terabyte and 2 Processors) 
    ///     Windows 10 Professional for Workstations Edition with Limit RAM 6 Terabyte and 4 Processors use for Networking,
    ///     like Netware, One Fileserver and the others Workstations.
    ///     Windows Firewall is at install NOT active, you must actived all Settings, but NOT Beginners, better admin !
    ///     One wrong set, and the Firewall can block it.
    ///     System-tools to encrypt data, Harddrive...
    /// </remarks>
    /// <returns>
    /// 
    /// </returns>
    [DllImport("VFL.dll", EntryPoint = "VFLLockWorkstation", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool VFLLockWorkstation();

    /// <summary>
    ///     Start Directly a Executable for you (.exe)
    /// </summary>
    /// <param name="AppName">Set the AppName (.exe)</param>
    /// <remarks>
    ///     Inside Function in Visual.Function.Library.dll:
    ///     CreateProcess(AppName,....);
    /// </remarks>
    /// <returns>
    ///  CreateProcess returns true (OK) or false (can't create process)
    /// </returns>
    [DllImport("VFL.dll", EntryPoint = "VFLStartDirectEXE", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool VFLStartDirectEXE(
                                                        [MarshalAs(UnmanagedType.LPStr)]
                                                            string AppName);


    //=================================================================================================================================================

} // End::OF::Class::ExternNativeFunctions


/// <summary>
/// External native Operation System Functions
/// </summary>
internal static class Extern_Operation_System
{

    ///
    /// General for Handles, Close all Handles !!!.
    /// One forgotten close Handle, he is now open !
    /// and can blocked any Process, Thread or Device and more.
    /// 


    /// <summary>
    /// Standard Output Handle
    /// </summary>

    public const int STD_OUTPUT_HANDLE = -11;
    /// <summary>
    /// TrueType
    /// </summary>

    public const int TMPF_TRUETYPE = 4;
    /// <summary>
    /// Facesize
    /// </summary>
    public const int LF_FACESIZE = 32;

    /// <summary>
    /// Set this for handles, miscellous returns: 0 or -1
    /// At New .NET Framework can set SafeHandles
    /// </summary>
    public static IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);

    /// <summary>
    /// Structure COORD
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal struct COORD
    {
        /// <summary>
        /// Field X 
        /// </summary>
        public int X;

        /// <summary>
        /// Field Y
        /// </summary>
        public int Y;

        /// <summary>
        /// Structure Constructor with Parametern
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        internal COORD(short x, short y)
        {
            X = x;
            Y = y;
        }
    }

    /// <summary>
    /// Structure CONSOLE_FONT_INFO_EX
    /// If you use internal as access modifizer, all members must be public for access use.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal struct CONSOLE_FONT_INFO_EX
    {
        /// <summary>
        /// Field cbSize 
        /// </summary>
        public uint cbSize;
        /// <summary>
        /// 
        /// </summary>
        public uint nFont;
        /// <summary>
        /// 
        /// </summary>
        public COORD dwFontSize;
        /// <summary>
        /// 
        /// </summary>
        public int FontFamily;
        /// <summary>
        /// 
        /// </summary>
        public int FontWeight;
        /// <summary>
        /// Pointer and Buffer fixed Size, ONLY in unsafe used !!!.
        /// </summary>
        //public unsafe fixed char FaceName[LF_FACESIZE];
    }




    /// <summary>
    /// Structure for FlashWindowEx
    /// Flash the Window Form - 
    /// dwFlags: 
    /// Frame Flash - change frame color to red for alert.
    /// Title Flash
    /// All 
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    internal struct FLASHWINFO
    {
        // TODO: 
        // ! ATTENTION ! Members must be public declared !
        // uint cbsize - is private! private is standard in Visual C#
        // NO outside access!
        // cbSize is the size of Structure
        // Visual C# marshalling
        //													Pointer	of Class
        // By class struct - public uint cbSize = ((int) Marshal.SizeOf(this)),


        /// <summary>
        /// instancevariable.cbSize = (uint)Marshal.SizeOf(typeof(FLASHWINFO));
        /// </summary>
        public uint cbSize;

        /// <summary>
        /// 
        /// </summary>
        public IntPtr WindowsHandle;

        /// <summary>
        /// 
        /// </summary>
        public uint dwFlags;

        /// <summary>
        /// 
        /// </summary>
        public uint uCount;

        /// <summary>
        /// 
        /// </summary>
        public uint dwTimeout;

    } // End of Structure::FLASHWINFO





    //-------------------------------------------------------------------------------------------------------------

    /// <summary>
    ///     Sleep hold/stop the thread for a given time, than continue.
    /// </summary>
    /// <param name="dwMilliseconds">Set the Value in thousand'l</param>
    /// <remarks>
    /// Set Sleep from Operation System here, for variants.
    /// 
    /// Sleep too in .NET Framework - syncron - Task.Delay is asyncron same !.
    /// 
    ///------------- SPECIAL SLEEP --------------------------------------------------------------------------------
    ///
    /// Hold Thread on in Milliseconds, after this continue the Thread and call the method !!! (Operator Asterics).
    /// Sleep(5000 * MethodnameCall);
    /// -----------------------------------------------------------------------------------------------------------
    /// Special with call MessageBox
    /// Hold the Thread in Milliseconds, after this continue and Show the MessageBox with Text and Title and Style
    /// 
    /// Sleep(5000 * MessageBox(NULL, "Messagetext", "MessageTitle", Style1) );
    ///      
    /// -----------------------------------------------------------------------------------------------------------
    /// Sleep can use too as Timer, so must not use TimerControl or Timer from Threading.Timer
    /// 
    /// (System.Threading.)Timer(Method, parameter, start timer, timerinterval);
    /// Method as TimerCallback, timerinterval he calls the Method everytime or comes timer.stop();
    /// parameter set, start timer - 0 start directly - 1 lazy
    /// all without a Control !!!!.
    /// 
    /// -----------------------------------------------------------------------------------------------------------
    /// </remarks>
    /// <return>
    ///     nothing, void!!! everytime return zero!!!
    /// </return>
    [DllImport("kernel32.dll", EntryPoint = "Sleep", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern void Sleep(uint dwMilliseconds);


    ///-----------------------------------------------------------------------
    /// SleepEx
    /// same as Sleep, second parameter bAlertable = false/true
    /// true, after seconds wake up the Thread and continue the current Thread
    ///-----------------------------------------------------------------------
    [DllImport("kernel32.dll", EntryPoint = "SleepEx", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern uint SleepEx(uint dwMilliseconds, bool bAlertable);

    /// <summary>
    /// 	Lock the current Workstation
    /// </summary>
    /// <remarks>
    ///		use this, Windows 10 shows the Lock Screen, click on Screen new LogIn
    /// </remarks> 
    [DllImport("user32.dll", EntryPoint = "LockWorkStation", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool LockWorkstation();

    /// <summary>
    /// 	The SwitchToThisWindow function is called to 
    /// 	switch focus to a specified window and bring it to the foreground.
    /// </summary>
    /// <param name="WindowHandle">
    ///		Handle to the window being switched to.
    /// </param>
    /// <param name="AltTab">
    ///		A true for this parameter indicates that the window is being 
    /// 	switched to using the Alt/Ctrl+Tab key sequence. 
    ///		This parameter should be false otherwise.
    /// </param>
    [DllImport("user32.dll", EntryPoint = "SwitchToThisWindow", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern void SwitchToThisWindow(IntPtr WindowHandle, bool AltTab);


    /// <summary>
    ///     Exit Windows with Flags and MajorReason and MinorReason
    /// </summary>
    /// <param name="uFlags">Set the flags here, can more than one with operator vertical bar |</param>
    /// <param name="dwReason">Set the Reasons: MajorReason are Categories: System, Application
    /// MinorReason:
    /// Fixes: Bugfix, Hotfix, Securityfix, Quickfix, PlannedUpdate,
    /// 
    /// if you register your Application in Windows Operation System, 
    /// he shutdown and do the work and restart the Application automatic at reboot.
    /// RegisterRestartApplication(string AppName);
    /// Windows Operation System give you same special Functions, 
    /// this Functions insert Settings into Windows Operation System.
    /// int RegisterWindowsMessage(string MessageText);
    /// insert Message into Windows Messages System, so NO duplicate Messages in Operation System !.
    /// the function returns the MessageID as integer Value for use.
    /// !TIPPO! Windows Operation System have own database inside.
    /// 
    /// ! Windows 10 Prof/Enterprise ! have a User database, it's Multi User System NOW !!!.
    /// the user database can be crypted.
    /// 
    /// Thats means, one user or more user on ONE PC/Computer.
    /// Windows 10 Prof/Enterprise and Windows Server have the same Codebase !.
    /// 
    /// So many Network dll's.(TIPPO: Windows Server Client DLL in Windows 10 Prof/Ent)
    /// BUT NOTE, take a Client License for Network - Client/Server System -
    /// CAL = Client Access License. everytime with options for purcased.
    /// 
    /// NEW ! 2017 ! Remote Server Administration Tools for Windows 10 Professional/Enterprise Fullversion!
    /// Server Manager and more....... for download !!!.
    /// 
    /// </param>
    /// <remarks>
    /// ExitWindowsEx:
    /// At Windows 7 - Parameters change from dwReserved
    /// to dwReason = Shutdown Reasons see overthere Flags
    /// Shutdown Reasons for Hardware and Software.
    /// Sample: 
    ///
    ///
    /// Sample:
    /// Flag EWX_RESTARTAPPS
    /// 
    /// ExitWindowsEx(EWX_REBOOT | EWX_RESTARTAPPS, 0),
    /// 
    /// So we Reboot Computer and then we restart 
    /// the registered Application now!.
    /// 
    /// This we have set with 
    /// RegisterApplicationRestart(string ApplicatioName),
    /// 
    /// The Windows Operation System have a List inside for this.
    ///----------------------------------------------------------------------------------------------
    /// ExitWindowsEx - Windows Operation System with NEW Rights (ACLS)
    /// so we have checks the Permission/Privileges 
    /// for user, allowed the Shutdown now!.
    /// so many Privileges for set.
    /// Administrator can set them or not.
    ///
    /// 
    ///---------Operator Vertical Bar | -------------------------------------------------------------
    /// TIPPO UNCHECKED - NEW Microsoft Code Convention:
    /// double Vertical Bar || , better for Tuning and Runtime.
    /// 
    /// MajorReason | MinorReason
    /// 
    /// simplesample:
    /// 
    /// Application | PlannedUpdate 
    /// and more.... in Visual C++ Headerfile Operation System.
    /// System, Hardware
    /// </remarks>
    /// <returns>
    /// 
    /// </returns>
    [DllImport("user32.dll", EntryPoint = "ExitWindowsExW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool ExitWindowsEx(
                                                uint uFlags,
                                                uint dwReason);



    /// <summary>
    ///     Register Application Restart
    /// </summary>
    /// <param name="lpString"></param>
    /// <remarks>
    /// RegisterApplicationRestart entry the Applicationname in a
    /// internal List of Operation System,
    /// next start, the operation system starts the Application now	 
    /// </remarks>
    /// <returns></returns>
    [DllImport("kernel32.dll", EntryPoint = "RegisterApplicationRestart", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    internal static extern int RegisterApplicationRestart(string lpString);


    /// <summary>
    ///		Method MessageBoxTimeout
    /// </summary>
    /// <remarks>
    /// 	MessageBoxTimeout is a new Function in Windows Operation System at Windows 7.
    /// 	Is so implemened that he close automatic the MessageBox after Timeout Value !!!.
    ///		Same as Method from Jeffrey Richter - Inside Windows Programming Book -
    /// </remarks>
    /// <param name="WindowsHandle"></param>
    /// <param name="text">Your String</param>
    /// <param name="title">Your Title String</param>
    /// <param name="Style">Set here the compact Style</param>
    /// <param name="wLanguageId">Set here our constant LANG_NEUTRAL</param>
    /// <param name="milliseconds">
    /// Timeout Value in milliseconds, 
    /// after this Timeout close the MessageBox automatic
    /// without Useraction.
    /// </param>
    /// <returns></returns>
    [DllImport("user32.dll", EntryPoint = "MessageBoxTimeoutW", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern int MessageBoxTimeout(IntPtr WindowsHandle,
                                                 [MarshalAs(UnmanagedType.LPWStr)]
                                                     string text,
                                                 [MarshalAs(UnmanagedType.LPWStr)]
                                                     string title,
                                                 uint Style,
                                                 ushort wLanguageId,
                                                 uint milliseconds);

    /// <summary>
    ///     FlashWindowEx
    /// </summary>
    /// <param name="pfwi"></param>
    /// <remarks>
    /// The specifies Window flashed or blinked
    /// </remarks>
    /// <returns></returns>
    [DllImport("user32.dll", EntryPoint = "FlashWindowEx", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool FlashWindowEx(ref FLASHWINFO pfwi);

    /// <summary>
    ///  Get the standard handle
    /// </summary>
    /// <param name="nStdHandle"></param>
    /// <returns></returns>
    [DllImport("kernel32.dll", EntryPoint = "GetStdHandle", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern IntPtr GetStdHandle(int nStdHandle);

    /// <summary>
    ///  Get Current Console Font
    /// </summary>
    /// <param name="consoleOutput"></param>
    /// <param name="maximumWindow"></param>
    /// <param name="lpConsoleCurrentFontEx"></param>
    /// <returns></returns>
    [DllImport("kernel32.dll", EntryPoint = "GetCurrentConsoleFontEx", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool GetCurrentConsoleFontEx(
                                               IntPtr consoleOutput,
                                               bool maximumWindow,
                                               ref CONSOLE_FONT_INFO_EX lpConsoleCurrentFontEx);
    /// <summary>
    ///     Set Console Font
    /// </summary>
    /// <param name="consoleOutput"></param>
    /// <param name="maximumWindow"></param>
    /// <param name="consoleCurrentFontEx"></param>
    /// <returns></returns>
    [DllImport("kernel32.dll", EntryPoint = "SetCurrentConsoleFontEx", SetLastError = true, CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
    internal static extern bool SetCurrentConsoleFontEx(
                                               IntPtr consoleOutput,
                                               bool maximumWindow,
                                               CONSOLE_FONT_INFO_EX consoleCurrentFontEx);


}

/// <summary>
///     Visual C++ Runtime Libraryies
/// </summary>
/// <remarks>
/// ! ATTENTION !
/// All Libraries written in C++ and managled names, other CallingConvention .cdecl !!!
/// NOT .stdcall !!!.
/// 
/// !!! NOTE !!!
/// Set here the MSVRCT.dll this is a 64BIT Runtime Library !!!.
/// for use in this 64BIT Project - NOTE: Everytime 64BIT .exe and 64BIT .dll
/// 
/// !!! Cdecl for variadic arguments, like printf(const *char format, ... );
/// ------------------------------------------------------------------varargs
/// For .NET Developer like Visual C#:
/// printf(string format, params Object[] args);
/// params everytime as last parameter !
/// Object[] all Datatypes allowed !
/// or
/// int[] but yet !, only integer Values !
/// -------------------------------------------------------------------------
/// At Visual Studio 2017 V 15.3.5/15.4/15.4.1/15.4.2/15.5
/// Microsoft Names Rules:
/// the beginning first char, must be lower char !!! see below.
/// see the yellow lamp left side and the intellisense window correction....
/// -------------------------------------------------------------------------
/// </remarks>
internal static class Extern_CPLUSPLUS_RuntimeLibrary
{

    /* ########################### ATTENTION ##################################
     * This is the Microsoft Visual C++ Runtime Library in 64BIT written !!!.
     * MSVCRT.dll 
     * ########################################################################
    */

    /// <summary>
    ///     Rand - Randomize Generator
    /// </summary>
    /// <remarks>
    ///     the C Functionname change to first letter upper, it's NEW !.
    ///     
    ///     Microsoft Name Rules, the first letter must be upper.
    ///     
    ///     The yellow lamp (Compiler under the Hood) on right show you the intelligence Window!
    /// </remarks>
    /// <returns>
    /// 
    /// </returns>
    [DllImport("msvcrt.dll", EntryPoint = "rand", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Rand();

    /// <summary>
    ///     Srand
    /// </summary>
    /// <param name="Value"></param>
    /// <returns></returns>
    [DllImport("msvcrt.dll", EntryPoint = "srand", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Srand(uint Value);



    /// <summary>
    ///     Cexit
    /// </summary>
    /// <remarks>
    /// Performs cleanup operations and termination procedures 
    /// and returns to caller, but does NOT terminate process (.exe) 
    /// </remarks>
    /// <returns>
    /// 
    /// </returns>
    [DllImport("msvcrt.dll", EntryPoint = "_cexit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Cexit();

    /// <summary>
    ///     Exit
    /// </summary>
    /// <remarks>
    /// Performs cleanup operations and termination procedures 
    /// and returns to caller, but does terminate process (.exe) 
    /// </remarks>
    /// <returns></returns>
    [DllImport("msvcrt.dll", EntryPoint = "_exit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Exit();

    /// <summary>
    ///     kbhit
    /// </summary>
    /// <remarks>
    /// keyboard hit - push a taste
    /// </remarks>
    /// <returns>
    /// 
    /// </returns>
    [DllImport("msvcrt.dll", EntryPoint = "kbhit", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Kbhit();

    /// <summary>
    ///     Getchar
    /// </summary>
    /// <param name="taste"></param>
    /// <remarks>
    /// 
    /// </remarks>
    /// <returns>
    /// 
    /// </returns>
    [DllImport("msvcrt.dll", EntryPoint = "getchar", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.Cdecl)]
    internal static extern int Getchar(int taste);




}

