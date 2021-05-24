using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class R_Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform gunBarrelEnd;

    [SerializeField] AudioSource gunAudioSource;
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.SecondaryIndexTrigger) & OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, gunBarrelEnd.position, gunBarrelEnd.rotation);

        gunAudioSource.Play();
    }
}