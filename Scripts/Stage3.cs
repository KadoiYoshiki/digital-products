using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3 : MonoBehaviour
{
    [SerializeField] GameObject stage3;
    // Start is called before the first frame update
    void Start()
    {
        stage3.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            stage3.SetActive(true);
        }
    }
}
