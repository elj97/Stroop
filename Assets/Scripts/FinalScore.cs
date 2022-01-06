using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Stroop
{
	public class FinalScore : MonoBehaviour
	{
		[SerializeField] private Text m_finalScoreText;

		private void Start()
		{
			// Fetch PlayerPref data
			SetFinalScore();
		}

		// Sets and shows the finalscore show
		void SetFinalScore()
		{
			float finalScore = PlayerPrefs.GetFloat("Stopwatch");
			TimeSpan finalTime = TimeSpan.FromSeconds(finalScore);
			m_finalScoreText.text = ("Total time taken: " + finalTime.ToString(@"mm\:ss\:fff"));
		}
	}
}

