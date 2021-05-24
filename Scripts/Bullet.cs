using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    
    void Start()
    {
        var velocity = speed * transform.forward;

        var rigidbody = GetComponent<Rigidbody>();

        rigidbody.AddForce(velocity, ForceMode.VelocityChange);
    }

    void OnTriggerEnter(Collider other)
    {
        other.SendMessage("OnHitBullet");
        Destroy(gameObject);
    }
}
