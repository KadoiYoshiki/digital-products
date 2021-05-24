using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause_tu : MonoBehaviour
{
	[SerializeField] private GameObject pauseUI;
	[SerializeField] private GameObject panel;
	[SerializeField] private GameObject reStartButton;
	[SerializeField] private GameObject StartButton;
	[SerializeField] private GameObject Text1;
	[SerializeField] private GameObject Text2;


	public void ReStartGame()
	{
		pauseUI.SetActive(false);
		panel.SetActive(false);
		reStartButton.SetActive(false);
		StartButton.SetActive(false);
		Text1.SetActive(false);
		Text2.SetActive(false);
		Time.timeScale = 1f;
	}

	void Update()
	{
		if (OVRInput.GetDown(OVRInput.Button.Three))
		{
			pauseUI.SetActive(true);
			panel.SetActive(true);
			reStartButton.SetActive(true);
			StartButton.SetActive(true);
			Text1.SetActive(true);
			Text2.SetActive(true);
			Time.timeScale = 0f;
		}
	}
}
