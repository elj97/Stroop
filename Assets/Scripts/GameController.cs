using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Stroop
{
	public class GameController : MonoBehaviour
	{
		[Header("Fields")]
		[SerializeField] private int m_numberOfQuestions = 10;

		[Space(5)]
		[SerializeField] private string[] m_questionTextOptions = {"Red", "Blue", "Yellow", "Pink"};

		[Space(10)]
		[Header("UI")]
		[SerializeField] private TextMeshProUGUI m_question;
		[Space(5)]
		[SerializeField] private TextMeshProUGUI[] m_buttons;

		[SerializeField] private int m_numberOfAnsweredQuestions;
		[SerializeField] private
		
		Color[] colors = new Color[4];

		private void Start()
		{
			colors[0] = Color.red;
			colors[1] = Color.blue;
			colors[2] = Color.yellow;
			colors[3] = Color.magenta;
			//color[4] = new Color(255, 165, 0);

			LoadNewQuestion();
		}
		public void LoadNewQuestion()
		{
			string questionToDisplay = RandomQuestionDisplay();

			m_question.text = questionToDisplay;

			m_question.color = colors[Random.Range(0, colors.Length)];

			int correctAnswer = Random.Range(0, m_buttons.Length);
			string[] buttonColors = new string[m_buttons.Length];

			// correct answer is button text compared to question color
			//m_buttons[correctAnswer].text

			// TO DO: once game runs through set amount of questions, go to next scene. This is in the wrong spot, it is temp here for testing.
			m_numberOfAnsweredQuestions++;

			if ( m_numberOfAnsweredQuestions == m_numberOfQuestions )
			{
				SceneController.Instance.LoadNextScene();
				return;
			}
		}

		private string RandomQuestionDisplay()
		{
			string randomQuestion = m_questionTextOptions[Random.Range(0, m_questionTextOptions.Length)];

			return randomQuestion;
		}

		private void CheckAnswer(Text text)
		{
			bool success = false;

			if (!success)
			{
				// animation
			}

			m_numberOfAnsweredQuestions++;

			if(m_numberOfAnsweredQuestions  == m_numberOfQuestions )
			{
				SceneController.Instance.LoadNextScene();
				return;
			}

			LoadNewQuestion();
		}
	}
}

