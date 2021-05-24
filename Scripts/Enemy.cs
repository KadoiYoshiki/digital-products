using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Enemy : MonoBehaviour
{
    [SerializeField] AudioClip spawnClip;
    [SerializeField] AudioClip hitClip;

    [SerializeField] Collider enemyCollider;
    [SerializeField] Renderer enemyRenderer;

    AudioSource audioSource;

    [SerializeField] int hp = 1;

    [SerializeField] int point = 1;
    Score score;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.PlayOneShot(spawnClip);

        var gameObj = GameObject.FindWithTag("Score");

        score = gameObj.GetComponent<Score>();
    }


    void OnHitBullet()
    {
        audioSource.PlayOneShot(hitClip);

        --hp;

        if (hp <= 0)
        {
            GoDown();
        }
        
    }

    void GoDown()
    {
        score.AddScore(point);

        enemyCollider.enabled = false;
        enemyRenderer.enabled = false;

        Destroy(gameObject, 1f);
    }

    void OnTriggerEnter(Collider other)
    {
        other.SendMessage("OnHitEnemy");
        Destroy(gameObject);
    }
}
