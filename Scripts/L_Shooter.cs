using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_Shooter : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform gunBarrelEnd;

    [SerializeField] AudioSource gunAudioSource;
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger) & OVRInput.Get(OVRInput.Button.PrimaryHandTrigger))
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
