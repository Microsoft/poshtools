﻿using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using PowerShellTools.DebugEngine;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerShellTools.Service
{
    public class ExecutionEngine
    {
        private ScriptDebugger _debugger;
        private static object _staticSyncObject = new object();
        private static ExecutionEngine _instance;
        private IVsOutputWindowPane _generalPane;

        private ExecutionEngine()
        {
            _debugger = PowerShellToolsPackage.Debugger;

            IVsOutputWindow outWindow = PowerShellToolsPackage.GetGlobalService(typeof(SVsOutputWindow)) as IVsOutputWindow;
            Guid generalPaneGuid = VSConstants.OutputWindowPaneGuid.GeneralPane_guid;
            // By default this is no pane created in output window, so we need to create one by our own
            // This call wont do anything if there is an existing one
            int hr = outWindow.CreatePane(generalPaneGuid, "General", 1, 1); 
            outWindow.GetPane(ref generalPaneGuid, out _generalPane);
        }

        public static ExecutionEngine Instance
        {
            get
            {
                lock (_staticSyncObject)
                {
                    if (_instance == null)
                    {
                        _instance = new ExecutionEngine();
                    }
                }
                return _instance;
            }
        }

        /// <summary>
        /// Issue a command for powershell tools to run synchronously
        /// </summary>
        /// <param name="command">Command to execute</param>
        public void ExecutePowerShellCommand(string command)
        {
            _debugger.HostUi.OutputString = OutputString;
            _debugger.Execute(command);
        }

        /// <summary>
        /// Issue a command for powershell tools to run asynchronously
        /// </summary>
        /// <param name="command">Command to execute</param>
        /// <returns></returns>
        public Task ExecutePowerShellCommandAsync(string command)
        {
            _debugger.HostUi.OutputString = OutputString;
            return Task.Run(() => ExecutePowerShellCommand(command));
        }

        /// <summary>
        /// output string into output window (general pane)
        /// </summary>
        /// <param name="output">string to output</param>
        private void OutputString(string output)
        {
            _generalPane.Activate(); // Brings this pane into view
            _generalPane.OutputString(output);
        }
    }
}
