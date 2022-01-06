using UnityEngine;
using UnityEngine.UI;

namespace Stroop
{
	public class GameController : MonoBehaviour
	{
		#region
		[Header("Questions")]
		[SerializeField] private int m_numberOfQuestions = 10;

		[Space(5)]
		[SerializeField] private string[] m_questionTextOptions = {"Red", "Blue", "Yellow", "Pink"};

		[Space(5)]
		[SerializeField] private Animator m_questionAnimator;

		[Space(5)]
		[SerializeField] private Text m_question;

		[Space(5)]
		[SerializeField] private Text[] m_buttons;

		[Space(10)]
		[SerializeField] private Stopwatch m_stopwatch;
		
		[Space(5)]
		[SerializeField] private ChangeScene m_changeScene;

		#endregion

		private void Start()
		{	
			// random visual colors for question
			colors[0] = Color.red;
			colors[1] = Color.blue;
			colors[2] = Color.yellow;
			colors[3] = Color.magenta;

			// start stopwatch when game starts
			m_stopwatch.ToggleStopwatch(true);

			// load new question when game starts
			LoadNewQuestion();	
		}

		public void LoadNewQuestion()
		{
			// sets up random number for questions and colors - this is used to compare them later
			m_questionInt = Random.Range(0, m_questionTextOptions.Length);
			m_colorInt = Random.Range(0, colors.Length);

			// sets question text & color based on each list
			m_question.text = m_questionTextOptions[m_questionInt];
			m_question.color = colors[m_colorInt];
			
			// To ensure that text and color of text are not the same. If they are the same this will load another question.
			if (m_questionInt == m_colorInt)
			{
				Debug.Log("Reloaded Question");
				LoadNewQuestion();
			}
		}

		public void CorrectAnswer()
		{
			m_numberOfAnsweredQuestions++;

			if(m_numberOfAnsweredQuestions == m_numberOfQuestions)
			{
				// stops stopwatch when game end, then loads next scene
				m_stopwatch.ToggleStopwatch(false);
				m_changeScene.LoadScene("End Screen");
			}

			LoadNewQuestion();
		}
		#region colorChecks
		// Checks if button is same as the text color i.e. the answer is correct.
		// if answer is correct then it will move on to another question
		// if answer is incorrect then it will play a shake animation
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
			}
		}
#endregion
		#region privateVariables
		private int m_colorInt, m_questionInt;
		private int m_numberOfAnsweredQuestions;

		private Color[] colors = new Color[4];
		#endregion
	}
}

