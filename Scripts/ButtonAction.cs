using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonAction : MonoBehaviour
{
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            OnClickOne();
        }
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            OnClickThree();
        }
    }
    public void OnClickOne()
	{
		var scene = SceneManager.GetActiveScene();

		SceneManager.LoadScene(scene.name);
	}

    public void OnClickThree()
    {
        SceneManager.LoadScene("Title");
    }
}
