//############################################################################
//
// Project		:	SecretLock
//
//----------------------------------------------------------------------------
// Programmer	:	Christian "Tipplin" Kurs
//----------------------------------------------------------------------------
// Part		    :	
//----------------------------------------------------------------------------
// Base Class	:	
//----------------------------------------------------------------------------
// Copyright © 2017-2023, by 
// Visual Galaxy Framework Community Kernel Developer Team.
// by Head-Author: Christian "TIPPO" Kurs - Visual C# Senior Developer
// Portions Copyright © 1982-2023 by Microsoft Corporation GmbH.
//----------------------------------------------------------------------------
// Same sourcecode by Microsoft, so we marked with Copyright !.
// © 1982-2023 by Copyrights by Microsoft: Images, Icons, Signs, Gadgets, 
// Copyright © and Tradewark by Microsoft Windows, Windows Logo, Visual Studio
//----------------------------------------------------------------------------
//
// written by 		Christian "Tipplin" Kurs
// 				    Ahornweg 1
//					-G - 53177 Bonn
//					Germany - Allemagne - Duitsland
//----------------------------------------------------------------------------  
//					international phone	:	00-49-1734593440
//					e-mail				:	kurschristian@gmail.de
//					my Website Community:
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
//				
//
//				Honest Business Users, to use our compiled Versions, 
//				please call us to send you our Business Licenses.
//				or our Business Website:
//				
//				
//
//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------
//-------------------------- Project History ----------------------------------
//-----------------------------------------------------------------------------
// Release 0.0.0 - 2017/01/01 - TIPPO - KC - Project Founder - Initial
//-----------------------------------------------------------------------------
// Commentary:
// [VGF.NET - 01]
// change to new NET7 Framework
//-----------------------------------------------------------------------------
// For Windows Operation System Functions
// change to Project 'VANARA' from David Hall
// he has continue all Windows Function from every Library in this Project.
// Install over nuget packages.
//
// New in this Project more functions from Libraries, and for .NET6 written.
//
//-----------------------------------------------------------------------------
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
// 
//######################### Visual.Galaxy.Framework ##########################
//#
//# Start Date: 2017/01/01 - 17:00 - Ground Leaning -Initial
//#
//#---------------------------------------------------------------------------
//# Freeze Date: 
//# (FREEZE: like Microsoft - stopp develop, no more codes into project,
//# - but develop goes on - compiling to R T M )
//# Microsoft Developer's have all one or more Platform's for Project's.
//# Microsoft Office, Project, Team Foundation Server... 
//# Microsoft Build Server - all Developer save they code here, test OK! 
//# Build Server bundles that and compile a Daily Build - 
//# like Windows 10 Desktop - B 15002 - 09.01.2017.
//# --------------------------------------------------------------------------
//#
//# ! NOTE ! Develop are going on, new an features in later build.
//#
//#
//#
//#
//############################################################################
//############################################################################

// Only Information about:
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

at NET6 / NET7
the semicolon include {}
namespace Namespacename;





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


/// <summary>
/// namespace Secret1 with semicolon include {}
/// </summary>
namespace Secret1;
    //----------------------------------------------------------------------------------
    // Local Directives ! - we have only one namespace here in this Part.
    //
    //----------------------------------------------------------------------------------

    using System;

    //----------------------------------------------------------------------------------
    // same Assemblies have: static Class and Methods in .NET Framework.
    // System.Console, System.Math
    // Now new all static class and methods, set here using static namespace and class !
    // so you can directly call the method in codepart.
    //
    // unused System Directives, remove from Compiler at buildrun !!!
    // unused DllImportAttribute the same !!!.
    //
    //----------------------------------------------------------------------------------
    using static System.Console;
   
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    

    using static SecretLock.NativeMethods;
    using static SecretLock.Extern_CPLUSPLUS_RuntimeLibrary;
    using static SecretLock.Extern_Operation_System;

    /* Our own Resource Assembly without Class and Methods pure resources !
     * Our Assembly with pure Resources - icons, images, photos, music, sounds, voices,
     * text, strings (table), signs and more...
    */
    using VisualD.Resource.Library.Properties;

    /// <summary>
    /// set program class on public and static, so you have the change access to methods.
    /// Program.Methodname();
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// SecretWriteLogFile
        /// </summary>
        /// <returns></returns>
        public static bool SecretWriteLogFile()
        {

            /// write try block
            try
            {

                //---------------------------------------------------------------------------------------------------------------------------------------
                // @ unicode sign for slashs, so you set only one slash
                //
                // set here for write all relevant Information into Log File.
                // other you must set two backward slashes
                // url's the same: normal ..\\\.\\
                // with @ : \\.\
                //---------------------------------------------------------------------------------------------------------------------------------------
                string path = @"C:\Users\tipplin\development\source\main\repossamples\SecretLock\SecretLockLogs\ConsoleSecretLog.syslog";
                
                //-----------------------------------------------------------------------------------------------------
                // Set FileStream for LogFile with open, create and append, you see the operator | that's allowed !
                // than FileStream have only two parameters !, the second is MODE !.
                // have forgotten FileMode.Append, than he override everytime! old text.
                //-----------------------------------------------------------------------------------------------------
                var sb = new FileStream(path, FileMode.OpenOrCreate | FileMode.Append);

                //-----------------------------------------------------------------------------------------------------
                // StreamWriter for the strings to write into Stream.
                //-----------------------------------------------------------------------------------------------------
                var sw = new StreamWriter(sb);

                //-----------------------------------------------------------------------------------------------------
                // Here have a Query, System Class Enviroment and Method ExpandEnviromentVariables();
                // Here %SystemDrive% and %SystemRoot%, 
                // in Visual C# Placeholder change the %Placeholder% to string str set him in field.
                //-----------------------------------------------------------------------------------------------------
                String query = "you system drive is %SystemDrive% \nand you system root is %SystemRoot%";
                String str = Environment.ExpandEnvironmentVariables(query);

                sw.WriteLine("=====================================================\n");
                sw.WriteLine("\r\nSecret-System-Log--- Entry ---:\n\n");
                sw.WriteLine("=====================================================\n\n");
                //-------------------------------------------------------------------------------------------------------
                // DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString() as local Time in your Country.
                // using UTC and ISO - ISO Zwo Letters for Countries - en-US = USA, de-DE = Germany,
                // en -UK = United Kingdom
                // next can use string.Format for more options, Time, Date, Timezone(calculated -/+), 
                // Science, Percent, Currency,
                //--------------------------------------------------------------------------------------------------------
                sw.WriteLine("Date: {0} - Time: {1}\n", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString());
                sw.WriteLine("\r\nUsername: {0}\n", Environment.UserName);
                sw.WriteLine("Computername: {0}\n", Environment.MachineName);
                sw.WriteLine("Is64BIT-OS: {0}\n", Environment.Is64BitOperatingSystem);
                sw.WriteLine("System Enviroment Ouery: {0}\n", str);
                sw.WriteLine("Logical Drives: {0}\n", Environment.GetLogicalDrives());
                sw.WriteLine("Exit-Code means the End of Program - 0 successfully end - 1 - failure at End\n");
                sw.WriteLine("Main Exit-Code: {0}\n", Environment.ExitCode.ToString());
                sw.WriteLine("User Domain Name: {0}\n", Environment.UserDomainName);
                sw.WriteLine("Processor(s) inside current Machine: {0}\n", Environment.ProcessorCount);
                sw.WriteLine("Current Directory: {0}\n", Environment.CurrentDirectory);
                sw.WriteLine("Is a 64BIT Process run: {0}\n", Environment.Is64BitProcess);
                sw.WriteLine("Is Version Major: {0}\n", Environment.OSVersion.VersionString);
                sw.WriteLine("Special Library: Visual.Resource.Library.dll:\n");
                sw.WriteLine("Special Library: Visual.Function.Library.dll:\n");
                sw.WriteLine("Special Library: Visual.Security.Library.dll:\n");
                //--------------------------------------------------------------------------------------------------------
                // Flush write complete stream into File !!!
                //--------------------------------------------------------------------------------------------------------
                sw.Flush();

                //--------------------------------------------------------------------------------------------------------
                // Close everytime at end !!!, NOT reverse!!!.
                //--------------------------------------------------------------------------------------------------------
                sw.Close();

                return true;
            }

            // !!! NEW !!! write new catch with filter and keyword when and operator || , same as in Java
            //catch (SystemException ex) when(IOException ex  || Exception ex )
            catch (Exception ex)
            {
                MessageBoxTimeout(IntPtr.Zero, ex.Message, "Exception at write the SecretLog !", 1, 0, 3000);
                return false;
            }

            /* finally is the ultimate free resources, exception or not exception !
             * bind with garbage collection - GC - finalize()
            finally
            {
                sw.Close();
            }
            */
        }

        //-------------------------------------------------------------------------
        // TIPPO have change datatype from void to integer, is allowed in Visual C#
        // dont forget returned integer value!!
        // int Main, returned program-codes
        // TIPPO: checked 0, 1,
        // unchecked
        // ..........................255 = unknown error
        //
        //-------------------------------------------------------------------------

        /// <summary>
        /// main
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static int Main(string[] args)
        {

            //----------------------------------------------------------------------------------------------
            // set instance for Soundplayer,
            // but he play only wave file .wav - pure Resources from Visual Resource Library.dll
            //----------------------------------------------------------------------------------------------

            // set here registered Voice "time to registration"
            //var t = new SoundPlayer(Resources.BACKSND);

            // set here for TIPPO Image, hey cool media and play direct
            //var s = new SoundPlayer(Resources.NOTICE);
            

            // set here for for start executable app with sound wave
            //var f = new SoundPlayer(Resources.SNDTEST);



            //------------------- Console Window Settings ----------------------------------------

            // Delete show Information in ConsoleBuffer to Console Window
            Console.Clear();

            // Change new BackgroundColor to BLUE
            Console.BackgroundColor = ConsoleColor.Blue;


           
            // Delete show Information in ConsoleBuffer to Console Window
            Console.Clear();

            // Set out Console Window Title
            Console.Title = "Secret your Computer - Copyright © 2017-2023 by Christian'Tipplin' Kurs Visual C#/C++ Developer.";



            //------------------- Call Extern Native Functions, our Visual.function.Library.dll pure C Functions ------------------

            // External from Visual.Function.Library.dll- pure -C- Functions - same Parts of Operation System - Windows -
            // Insert with [DLLImportAttribute] - see ExternalNativeFunctions.cs
            // This MessageBox only parameter TextID - Internal CHAR Text Array. - define 1 to 20.
            // 999 No text - Only Message unknown.
            //vgfVFLMessageBox(1);

            // External from Visual.Function.Library.dll - pure -C- Functions - same Parts of Operation System - Windows -
            // .NET have only one Beep without Frequency and duration.
            //Extern_Native_Functions.vgfVFLMultiBeep(800, 2000);

            //-------------------- set here Form specified ------------------------------------------------------------------------
            
            // Voice sound "Time to Registration !"
            //s.Play();

            // Set ForegroundColor WHITE for Font !
            Console.ForegroundColor = ConsoleColor.White;
            

            // WriteLine is now static written in System.Console
            WriteLine("\n\n\n");
            WriteLine("\t\t\tSecret your Workstation to other users:\n\n");
            WriteLine("\t\t\tNOW !!! Lock this Current Workstation !!!\n\n");
            WriteLine("\t\t\tFor work on this Workstation, click on Screen and LogIn !!!\n\n");
            WriteLine("\t\t\tCopyright © 2017-2023 by Christian 'Tipplin' Kurs - VGF-Kernel-Team\n\n\n");
            // Hold Thread here 8 seconds and than continue the Thread.
            Thread.Sleep(2000);

            // For urgent messages set Color to Black
            ForegroundColor = ConsoleColor.Yellow;

            WriteLine("\t\t\tDone. All Datas to ConsoleSecretSystemLog.syslog for Control.\n\n");
            WriteLine("\t\t\tThis File is encrypted and only for the Administrator !.\n\n");
            WriteLine("\t\t\tWindows10/11 now allowed own .Suffixe limit 255 chars.\n\n");
            WriteLine("\t\t\tfor tell Windows open with App. use tool assoc.exe\n\n");
            WriteLine("\t\t\tThis File is secure for access ! Only read Data ! NO more!.\n");
            WriteLine("\t\t\tInside File Access Rights System active !.\n\n");
            WriteLine("\t\t\tNOTE: System-Administrator can set for him Fullcontrol.\n\n");

            // OK ! - For end set Color on GREEN
            ForegroundColor = ConsoleColor.Yellow;

            WriteLine("\t\t\tSpecial Library bind in: Visual.Function.Library.dll\n");
            WriteLine("\t\t\tSpecial Library bind in: Visual.Resource.Library.dll\n");
            WriteLine("\t\t\tan pure resource assembly, here use soundfile .wav over .NET Class Soundplayer\n");
            WriteLine("\t\t\tSpecial Library bind in: Visual.Security.Library.dll\n\n");
            WriteLine("\t\t\tCopyright © 2017-2023 by Christian 'Tipplin' Kurs - Visual .NET - C# / C++ Senior Developer.\n");
            WriteLine("\t\t\tPortions Copyright © 1982-2023 by Microsoft Corporation.\n\n\n");
            WriteLine("\t\t\t\t\tPress any key to lock workstation. . . . ");

            // Play wave file from Resource - here our pure resource assembly - Visual.Resource.Library.dll -
            //t.Play();

            // Hold/Stop the current thread, * after 4 seconds he continue the thread and show messagebox
            // so you can with Thread.Sleep or Sleep (os) call a Function or MessageBox with middle Asterics operator
            // NOTE! messageBox in .NET returned DialogResult, so you must cast to (integer).
            // The same as here, you can write in Visual C++ Project without cast, MessageBox from OS.
            //
            // Thread.Sleep(4000 * (int)MessageBox.Show("Press <OK> Loading executable File", "Loading VGFExperimental.exe", MessageBoxButtons.OK, MessageBoxIcon.Information));
            // After milliseconde the Thread calls the Method !!!.
            // Thread.Sleep(milliseconds * Methodname);

            // write secret logfile - you can use this method outside program.cs in Project-Solution, is written public and static -
            // Program is the class and SecretWriteLogFile is the Method == program.SecretWriteLogFile();
            SecretWriteLogFile();


            // ReadKey is now static written in System.Console
            ReadKey(true);

            //t.Stop();

            // Special Function Operation System - user32.dll
            // so we can use this Call in other csharpfile.cs with Program.LockWorkStation();
            // Lockscreen
            if (LockWorkstation() == true)
            {
                // successfully work, call returned 1 at Program-end (Programcodes)
                return 1;
            }
            else
            {
                // failure work, call returned 0 at Program-end
                return 0;
            }
        }

        private static void Write()
        {
            throw new NotImplementedException();
        }
    }

