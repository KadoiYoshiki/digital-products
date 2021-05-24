using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject pauseUI;
    [SerializeField] private GameObject panel;
    [SerializeField] private GameObject reStartButton;
   

    public void ReStartGame()
    {
        pauseUI.SetActive(false);
        panel.SetActive(false);
        reStartButton.SetActive(false);
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            pauseUI.SetActive(true);
            panel.SetActive(true);
            reStartButton.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
