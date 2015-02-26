// <copyright>
// Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// If you get compiler errors CS0579, "Duplicate '<attributename>' attribute", check your 
// Properties\AssemblyInfo.cs file and remove any lines duplicating the ones below.
// (See also AssemblyInfoCommon.cs in this same directory.)

[assembly: AssemblyVersion(AssemblyVersionInfo.Version)]

class AssemblyVersionInfo {
    
    // This version string (and the comments for StableVersion and Version)
    // should be updated manually between major releases.
    // Servicing branches should retain the value
    public const string MajorVersion = "1";

    // This version string (and the comment for StableVersion) should be
    // updated manually between minor releases.
    // Servicing branches should retain the value
    public const string MinorVersion = "0";

#if DEV10
    public const string VSMajorVersion = "10";
    const string VSVersionSuffix = "2010";
#elif DEV11
    public const string VSMajorVersion = "11";
    const string VSVersionSuffix = "2012";
#elif DEV12
    public const string VSMajorVersion = "12";
    const string VSVersionSuffix = "2013";
#elif DEV14
    public const string VSMajorVersion = "14";
    const string VSVersionSuffix = "2015";
#else
#error Unrecognized VS Version.
#endif

    // This will increment each build. TODO: Make this line up with AppVeyor's Build system better.
    public const string BuildNumber = "*";
    
    // Defaults to "1.0.(2010|2012|2013).*"
    public const string Version = MajorVersion + "." + MinorVersion + "." + VSVersionSuffix + "." + BuildNumber;
}
