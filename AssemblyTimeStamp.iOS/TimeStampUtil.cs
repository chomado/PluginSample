using System;
using System.Reflection;

namespace AssemblyTimeStamp
{
	public static class TimeStampUtil
	{
		public static DateTime GetAssemblyTimeStamp()
		{
			//var assemblyTimeStampDllPath = typeof(TimeStampUtil).Assembly.Location;
			//System.Diagnostics.Debug.WriteLine(System.IO.Path.GetFullPath("."));
			//return System.IO.File.GetLastWriteTime(
			//	path: assemblyTimeStampDllPath
			//);
			return System.IO.File.GetLastWriteTime(
				path: "AssemblyTimeStamp.dll" // 自分
			);
		}
	}
}
