using System;
namespace AssemblyTimeStamp
{
	public static class TimeStampUtil
	{
		public static DateTime GetAssemblyTimeStamp()
		{
			return System.IO.File.GetLastWriteTime(
				path: "AssemblyTimeStamp.dll" // 自分
			);
		}
	}
}
