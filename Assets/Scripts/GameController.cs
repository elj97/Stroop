using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Stroop
{
	public class GameController : MonoBehaviour
	{
		[Header("Gameplay")]
		[SerializeField] private int _numberOfQuestions = 10;

		[Space(10)]
		[Header("UI")]
		[SerializeField] private TextMeshProUGUI _question;
		[SerializeField] private TextMeshProUGUI[] _buttons;
	}
}

