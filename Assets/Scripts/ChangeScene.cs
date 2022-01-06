using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// This script changes scenes.
/// </summary>
namespace Stroop
{
	public class ChangeScene : MonoBehaviour
	{
		public void LoadScene(string sceneName)
		{
			SceneManager.LoadScene(sceneName);
		}

		public void QuitGame()
		{
			Application.Quit();
		}
	}
}

