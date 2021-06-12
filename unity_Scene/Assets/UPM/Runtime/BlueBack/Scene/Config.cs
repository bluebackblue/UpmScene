

/**
 * Copyright (c) blueback
 * Released under the MIT License
 * @brief コンフィグ。
*/


/** BlueBack.Scene
*/
namespace BlueBack.Scene
{
	/** Config
	*/
	public class Config
	{
		/** ERRORPROC
		*/
		#if(DEF_BLUEBACK_SCENE_ASSERT)
		public delegate void ErrorProcType(System.Exception a_exception,string a_message);
		public static ErrorProcType ERRORPROC = DebugTool.ErrorProc;
		#endif

		/** LOGPROC
		*/
		#if(DEF_BLUEBACK_SCENE_LOG)
		public delegate void LogProcType(string a_message);
		public static LogProcType LOGPROC = DebugTool.LogProc;
		#endif
	}
}

