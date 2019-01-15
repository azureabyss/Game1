using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExit : MonoBehaviour {

	public void ExitButton()
	{
		Debug.Log("exit game");
		Application.Quit();
	}
}
