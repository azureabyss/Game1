using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVar  {

	/// <summary>
	/// BGM 是否備妥。
	/// </summary>
	public static bool IsBGMReady { get; set; }
	public static bool IsRootReady { get; set; }

	//靜態建構式 (僅第一次執行)
	static StaticVar()
	{
		IsBGMReady = false;
		IsRootReady = false;
	}
}
