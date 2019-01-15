using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMclose : MonoBehaviour {

	private void Awake()
	{
		if (StaticVar.IsBGMReady)
		{
			this.gameObject.SetActive(false);
			Destroy(this.gameObject);  //自殺
		}
		else
		{
			StaticVar.IsBGMReady = true; //標記變數
			DontDestroyOnLoad(this);  //標記永不銷毀 (直到APP EXIT)
		}
	}
}
