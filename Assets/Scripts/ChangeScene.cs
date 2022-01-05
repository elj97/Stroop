using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Stroop
{
	public class ChangeScene : MonoBehaviour
	{
		public void LoadNextScene()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}

		public void QuitGame()
		{
			Application.Quit();
		}
	}
}

