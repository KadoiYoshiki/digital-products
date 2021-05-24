using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{

    [SerializeField] GameObject result;
    [SerializeField] GameObject clear;
    [SerializeField] GameObject time;
    [SerializeField] GameObject spawners;
    [SerializeField] GameObject map;
    [SerializeField] GameObject img1;
    [SerializeField] GameObject img2;
    [SerializeField] GameObject img3;
    [SerializeField] GameObject img4;
    [SerializeField] GameObject img5;
    public int hp = 5;
    private Slider _slider;
    public GameObject slider;
    private Image _img;
    public GameObject img;

    // Start is called before the first frame update
    void Start()
    {
        _slider = slider.GetComponent<Slider>();

        _img = img.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = hp;
        _img.color = new Color(0.5f, 0f, 0f, 0.5f);

        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger))
        {
            img.SetActive(false);
        }
        
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            map.SetActive(false);
        }

        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            map.SetActive(true);
        }

        if (hp <= 0)
        {
            clear.SetActive(false);
            time.SetActive(false);
            spawners.SetActive(false);
        }
    }
    
    private void OnHitEnemy()
    {
        //OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.RTouch);

        //OVRInput.SetControllerVibration(1, 1, OVRInput.Controller.LTouch);
        
        hp -= 1;

        
        if (hp == 4)
        {
            img1.SetActive(false);
            img2.SetActive(true);
        }
        if (hp == 3)
        {
            img2.SetActive(false);
            img3.SetActive(true);
        }
        if (hp == 2)
        {
            img3.SetActive(false);
            img4.SetActive(true);
        }
        if (hp == 1)
        {
            img4.SetActive(false);
            img5.SetActive(true);
        }
        if (hp == 0)
        {
            img5.SetActive(false);
        }
        if (hp <= 0)
        {
            result.SetActive(true);
        }
        if (hp > 0 && hp < 5)
        {
            img.SetActive(true);
        }
        else
        {
            img.SetActive(false);
        }
        
    }
    
}