using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace Stroop
{
	public class GameController : MonoBehaviour
	{
		[Header("Fields")]
		[SerializeField] private int m_numberOfQuestions = 10;

		[Space(5)]
		[SerializeField] private string[] m_questionTextOptions = {"Red", "Blue", "Yellow", "Pink"};

		[Space(5)]
		[SerializeField] private Animator m_questionAnimator;
		//[SerializeField] private int m_incorrectAnswerAnimation;

		[Space(10)]
		[Header("UI")]
		[SerializeField] private Text m_question;
		//public Button redButton, blueButton, yellowButton, pinkButton;
		[Space(5)]
		[SerializeField] private Text[] m_buttons;

		[SerializeField] private int m_numberOfAnsweredQuestions;
		
		Color[] colors = new Color[4];

		public Stopwatch m_stopwatch;
		public ChangeScene m_changeScene;

		private int m_colorInt, m_questionInt;

		private void Start()
		{	
			// random visual colors for question
			colors[0] = Color.red;
			colors[1] = Color.blue;
			colors[2] = Color.yellow;
			colors[3] = Color.magenta;

			// load new question when game starts
			LoadNewQuestion();

			// start stopwatch when game starts
			m_stopwatch.StartStopwatch();
		}
		public void LoadNewQuestion()
		{
			// sets up random number for questions and colors - this is used to compare them later
			m_questionInt = Random.Range(0, m_questionTextOptions.Length);
			m_colorInt = Random.Range(0, colors.Length);

			// sets question text & color based on each list
			m_question.text = m_questionTextOptions[m_questionInt];
			m_question.color = colors[m_colorInt];

			// not sure if I should keep this****
			while (m_questionInt == m_colorInt)
			{
				Debug.Log("Reloaded Question");
				LoadNewQuestion();
			}
		}

		public void CorrectAnswer()
		{
			m_numberOfAnsweredQuestions++;

			if(m_numberOfAnsweredQuestions  == m_numberOfQuestions)
			{
				m_changeScene.LoadNextScene();
				return;
			}

			LoadNewQuestion();
		}

		// COLOR CHECKS
		public void CheckIfRed()
		{
			if ( m_question.color == Color.red)
			{
				Debug.Log("yes Red");
				CorrectAnswer();
			}
			else
			{
				Debug.Log("Incorrect Answer");
				m_questionAnimator.SetTrigger("IncorrectAnswer");
				return;
			}
		}

		public void CheckIfBlue()
		{
			if ( m_question.color == Color.blue)
			{
				Debug.Log("yes Blue");
				CorrectAnswer();
			}
			else
			{
				Debug.Log("Incorrect Answer");
				m_questionAnimator.SetTrigger("IncorrectAnswer");
				return;
			}
		}

		public void CheckIfYellow()
		{
			if ( m_question.color == Color.yellow)
			{
				Debug.Log("yes Yellow");
				CorrectAnswer();
			}
			else
			{
				Debug.Log("Incorrect Answer");
				m_questionAnimator.SetTrigger("IncorrectAnswer");
				return;
			}
		}

		public void CheckIfPink()
		{
			if ( m_question.color == Color.magenta)
			{
				Debug.Log("yes pink");
				CorrectAnswer();
			}
			else
			{
				Debug.Log("Incorrect Answer");
				m_questionAnimator.SetTrigger("IncorrectAnswer");
				return;
			}
		}
	}
}

