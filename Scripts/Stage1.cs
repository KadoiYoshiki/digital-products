using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1 : MonoBehaviour
{
    [SerializeField] GameObject stage1;
    // Start is called before the first frame update
    void Start()
    {
        stage1.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            stage1.SetActive(true);
        }
    }
}
