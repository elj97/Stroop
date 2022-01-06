using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace Stroop
{
    public class Stopwatch : MonoBehaviour
    {
		public Text m_currentTimeText;
		bool m_stopwatchActive = false;
		float m_currentTime;

		void Start()
		{
			m_currentTime = 0;
		}

		void Update()
		{
			if(m_stopwatchActive == true)
			{
				m_currentTime = m_currentTime + Time.deltaTime;
			}
			TimeSpan time = TimeSpan.FromSeconds(m_currentTime);
			m_currentTimeText.text = time.ToString(@"mm\:ss\:fff");
		}

		public void ToggleStopwatch(bool toggle)
		{
			m_stopwatchActive = toggle;

			if (toggle == false)
			{
				PlayerPrefs.SetFloat("Stopwatch", m_currentTime);
				m_stopwatchActive = false;
			}
		}
	}
}

