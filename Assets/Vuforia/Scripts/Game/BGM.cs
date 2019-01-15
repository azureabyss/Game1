using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {

	private void Awake()
	{
		DontDestroyOnLoad(this);

		if (StaticVar.IsRootReady)
		{
			this.gameObject.SetActive(false);
			Destroy(this.gameObject);  //自殺
		}
		else
		{
			StaticVar.IsRootReady = true; //標記變數
			DontDestroyOnLoad(this);  //標記永不銷毀 (直到APP EXIT)
		}

	}
}
