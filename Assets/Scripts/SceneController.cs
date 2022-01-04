using UnityEngine;
using UnityEngine.SceneManagement;

namespace Stroop
{
	public class SceneController : MonoBehaviour
	{
		internal static SceneController Instance;
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

