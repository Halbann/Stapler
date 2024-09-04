﻿using System.Reflection;

[assembly: AssemblyProduct(Stapler.VersionInfo.ASSEMBLY)]
[assembly: AssemblyTitle(Stapler.VersionInfo.ASSEMBLY)]
[assembly: AssemblyCopyright("Copyright © 2024")]

[assembly: AssemblyVersion(Stapler.VersionInfo.STRING)]
[assembly: AssemblyFileVersion(Stapler.VersionInfo.STRING)]
[assembly: KSPAssembly(Stapler.VersionInfo.ASSEMBLY, Stapler.VersionInfo.MAJOR, Stapler.VersionInfo.MINOR, Stapler.VersionInfo.REVISION)]

namespace Stapler
{
	static partial class VersionInfo
	{
		public const int MAJOR = 3;
		public const int MINOR = 2;
		public const int REVISION = 3;
		public const string STRING = "0.1.1";
	}
}
