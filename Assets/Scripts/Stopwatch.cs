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

		public void StartStopwatch()
		{
			m_stopwatchActive = true;
		}

		public void StopStopwatch()
		{
			m_stopwatchActive = false;
		}
		#region privateVariables
		private bool m_stopwatchActive = false;
		private float m_currentTime;
		#endregion
	}
}

