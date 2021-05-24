using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugMover : MonoBehaviour
{
	[SerializeField]
	Transform Head = null;
	const float Angle = 30f;
	const float DashSpeed = 5f;
	const float SlowSpeed = 0.2f;
    [SerializeField] GameObject up;
    [SerializeField] GameObject down;
    [SerializeField] GameObject right;
    [SerializeField] GameObject left;
    public AudioClip footSound;
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Reset()
    {
		Head = GetComponentInChildren<OVRCameraRig>().transform.Find("TrackingSpace/CenterEyeAnchor");
    }

    float Scale
	{
		get
        {
			return IsPressTrigger ? DashSpeed : IsPressGrip ? SlowSpeed : 2f;
        }
    }

    bool IsPressTrigger
	{
		get
        {
			return Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.LeftAlt) || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger);
		}
    }

    bool IsPressGrip
	{
		get
		{
			return Input.GetKey(KeyCode.LeftAlt) || Input.GetKey(KeyCode.RightShift) || OVRInput.Get(OVRInput.Button.PrimaryHandTrigger);
		}
    }
    
    void Update()
    {   //forward
		if (Input.GetKey(KeyCode.W) || OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp))
        {
			var forward = Head.forward;
			forward.y = 0;
			transform.position += forward.normalized * Time.deltaTime * Scale;
            up.SetActive(true);
            
        }
        if (Input.GetKeyDown(KeyCode.W) || OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickUp) || Input.GetKeyDown(KeyCode.S) || OVRInput.GetDown(OVRInput.Button.PrimaryThumbstickDown))
        {
            audioSource.PlayOneShot(footSound);
        }
        //back
            if (Input.GetKey(KeyCode.S) || OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown))
		{
			var forward = Head.forward;
			forward.y = 0;
			transform.position -= forward.normalized * Time.deltaTime * Scale;
            down.SetActive(true);
		}

        //left rotate
		if (Input.GetKeyDown(KeyCode.A) || OVRInput.GetDown(OVRInput.Button.SecondaryThumbstickLeft))
        {
			transform.Rotate(0, -Angle, 0);
            left.SetActive(true);
        }
        //right rotate
		if (Input.GetKeyDown(KeyCode.D) || OVRInput.GetDown(OVRInput.Button.SecondaryThumbstickRight))
		{
			transform.Rotate(0, Angle, 0);
            right.SetActive(true);
		}

        if (Input.GetKeyUp(KeyCode.W) || OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickUp) || OVRInput.GetUp(OVRInput.Button.SecondaryThumbstickUp))
        {
            up.SetActive(false);
            audioSource.Stop();
        }

        if (Input.GetKeyUp(KeyCode.S) || OVRInput.GetUp(OVRInput.Button.PrimaryThumbstickDown) || OVRInput.GetUp(OVRInput.Button.SecondaryThumbstickDown))
        {
            down.SetActive(false);
            audioSource.Stop();
        }

        if (Input.GetKeyUp(KeyCode.A) || OVRInput.GetUp(OVRInput.Button.SecondaryThumbstickLeft))
        {
            left.SetActive(false);
        }

        if (Input.GetKeyUp(KeyCode.D) || OVRInput.GetUp(OVRInput.Button.SecondaryThumbstickRight))
        {
            right.SetActive(false);
        }
    }
}
