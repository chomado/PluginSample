using System;
using System.Reflection;

namespace AssemblyTimeStamp
{
	public static class TimeStampUtil
	{
		public static DateTime GetAssemblyTimeStamp()
		{
			//var assemblyPath = Assembly.GetExecutingAssembly().Location;
			//System.Diagnostics.Debug.WriteLine("assemblyPath: " + assemblyPath);
			//// /storage/emulated/0/Android/data/com.chomado.pluginsample/files/.__override__/AssemblyTimeStamp.dll

			//var assemblyDirectoryPath = System.IO.Path.GetDirectoryName(assemblyPath);
			//System.Diagnostics.Debug.WriteLine("assemblyDirectoryPath: " + assemblyDirectoryPath);
			//// /storage/emulated/0/Android/data/com.chomado.pluginsample/files/.__override__

			//var assemblyTimeStampDllPath = System.IO.Path.Combine(
			//	assemblyDirectoryPath,
			//	"AssemblyTimeStamp.dll");
			//System.Diagnostics.Debug.WriteLine("assemblyTimeStampDllPath: " + assemblyTimeStampDllPath);
			//// /storage/emulated/0/Android/data/com.chomado.pluginsample/files/.__override__/AssemblyTimeStamp.dll

			//var current = System.IO.Path.GetFullPath(".");
			//System.Diagnostics.Debug.WriteLine("current: " + current);
			//// current: /

			var assemblyTimeStampDllPath = typeof(TimeStampUtil).Assembly.Location; 

			return System.IO.File.GetLastWriteTime(
				path: assemblyTimeStampDllPath
			);
		}
	}
}
