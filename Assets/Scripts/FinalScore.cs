using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Stroop
{
	public class FinalScore : MonoBehaviour
	{
		[SerializeField] public Text m_finalScoreText;

		float m_finalScore;

		private void Start()
		{
			// Fetch PlayerPref data
			SetFinalScore();
		}

		// TODO: make the finalscore show
		void SetFinalScore()
		{
			m_finalScore = PlayerPrefs.GetFloat("Stopwatch");
			m_finalScoreText.text = ("Total time taken: " + m_finalScore.ToString(@"mm\:ss\:fff"));
		}
	}
}

