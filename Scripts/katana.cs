using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class katana : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.SendMessage("OnHitBullet");
    }
}
