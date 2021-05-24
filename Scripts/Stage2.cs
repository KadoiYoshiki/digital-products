using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2 : MonoBehaviour
{
    [SerializeField] GameObject stage2;
    // Start is called before the first frame update
    void Start()
    {
        stage2.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            stage2.SetActive(true);
        }
    }
}
