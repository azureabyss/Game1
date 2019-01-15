using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneButton : MonoBehaviour {

	public void Botton(string name)
	{

		SceneManager.LoadScene(name, LoadSceneMode.Single);
	}
}
