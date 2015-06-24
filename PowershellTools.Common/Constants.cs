﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellTools.Common
{
    internal static class Constants
    {
        public const string ProcessManagerHostUri = "net.pipe://localhost/";

        public const string IntelliSenseHostRelativeUri = "NamedPipePowershellIntelliSense";

        public const string DebuggingHostRelativeUri = "NamedPipePowershellDebugging";

        public const string ReadyEventPrefix = "VsPowershellToolProcess:";

        // 20 minutes
        public const int HostProcessStartupTimeout = 20 * 60 * 1000; // wait for 20 minutes max for remote powershell host process to initialize

        public const string PowerShellHostExeName = "PowerShellToolsProcessHost.exe";

        public const string PowerShellHostExeNameForx86 = "PowerShellToolsProcessHost.x86.exe";

        public const string PowerShellHostConsoleExeName = "PowerShellToolsProcessHostConsole.exe";

        // 10M in bytes
        public const int BindingMaxReceivedMessageSize = 10000000;

        // Arguments for vspowershellhost.exe
        public const string VsProcessIdArg = "/vsPid:";
        public const string UniqueEndpointArg = "/endpoint:";
        public const string ReadyEventUniqueNameArg = "/readyEventUniqueName:";

        // Arguments for vspowershellhostconsole.exe
        public const string ConsoleProcessIdArg = "/hpPid:";

        public const string SecureStringFullTypeName = "system.security.securestring";
        public const string PSCredentialFullTypeName = "system.management.automation.pscredential";

        /// <summary>
        /// This is the GUID in string form of the Visual Studio UI Context when in PowerShell debug mode.
        /// </summary>
        public const string PowerShellDebuggingUiContextString = "A185A958-AD74-44E5-B343-1B6682DAB132";

        /// <summary>
        /// This is the GUID of the Visual Studio UI Context when in PowerShell debug mode.
        /// </summary>
        public static readonly Guid PowerShellDebuggingUiContextGuid = new Guid(PowerShellDebuggingUiContextString);
        
        /// <summary>
        /// PowerShell install version registry key
        /// </summary>
        public const string NewInstalledPowerShellRegKey = @"Software\Microsoft\PowerShell\3\PowerShellEngine";
        public const string LegacyInstalledPowershellRegKey = @"Software\Microsoft\PowerShell\1\PowerShellEngine";

        /// <summary>
        /// PowerShell install version registry key name
        /// </summary>
        public const string PowerShellVersionRegKeyName = "PowerShellVersion";

        /// <summary>
        /// Latest PowerShell install link
        /// </summary>
        public const string PowerShellInstallFWLink = "http://go.microsoft.com/fwlink/?LinkID=524571";

        /// <summary>
        /// This is the GUID in string form of the Visual Studio UI Context when in PowerShell REPL window is opened.
        /// </summary>
        public const string PowerShellReplCreationUiContextString = "310d9a74-0a72-4b83-8c5b-4e75f035214c";

        /// <summary>
        /// This is the GUID of the Visual Studio UI Context when in PowerShell REPL window is opened.
        /// </summary>
        public static readonly Guid PowerShellReplCreationUiContextGuid = new Guid(PowerShellReplCreationUiContextString);


        /// <summary>
        /// This is the GUID in string form of the Visual Studio UI Context when in PowerShell project is opened/created.
        /// </summary>
        public const string PowerShellProjectUiContextString = "8b1141ab-519d-4c1e-a86c-510e5a56bf64";

        /// <summary>
        /// This is the GUID of the Visual Studio UI Context when in PowerShell project is opened/created.
        /// </summary>
        public static readonly Guid PowerShellProjectUiContextGuid = new Guid(PowerShellProjectUiContextString);

        /// <summary>
        /// Minimal width of REPL output buffer as 80 to keep consistent experience with another PowerShell custom host in VS: Nuget Manager Console
        /// </summary>
        public const int MinimalReplBufferWidth = 80;

        /// <summary>
        /// PowerShell host process window title format
        /// </summary>
        public const string HostProcessWindowTitleFormat = "{0} : {1}";

        /// <summary>
        /// Dialog box title for invalid attempt at attaching on PowerShell v4 or below
        /// </summary>
        public const string ProcessAttachVersionErrorTitle = "Invalid PowerShell Version";

        /// <summary>
        /// Dialog box body for invalid attempt at attaching on PowerShell v4 or below
        /// </summary>
        public const string ProcessAttachVersionErrorBody = "Unable to attach to specified process with PowerShell Tools.\nPowerShell version 5.0 or above is required before PowerShell Tools may attach to a local or remote process.";

        /// <summary>
        /// Dialog box title for when wait on Enter-PSHostProcess cmdlet times out
        /// </summary>
        public const string ProcessAttachFailErrorTitle = "Error Attaching to Process";

        /// <summary>
        /// Dialog box body for when wait on Enter-PSHostProcess cmdlet times out
        /// </summary>
        public const string ProcessAttachFailErrorBody = "Unable to attach to specified process.";
    }
}
