using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _speedBullet;
    [Space]
    [SerializeField]
    private GameObject _particlEffect;
    [SerializeField]
    [Space]
    private GameObject _music;
    private void Start()
    {
        Destroy(gameObject, 3f);
    }
    private void Update()
    {
        transform.position += Vector3.up * _speedBullet * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Obstacle obstacle = collision.GetComponent<Obstacle>();

        if(obstacle != null)
        {
            PlayerManager._deadObstacle++;
            PlayerPrefs.SetInt("deadObstacle_player_pref", PlayerManager._deadObstacle);
            StartCoroutine(CorDeadObstacle());
            Destroy(obstacle.gameObject);
            Destroy(gameObject);
        }
    }
    private IEnumerator CorDeadObstacle()
    {
        GameObject music = Instantiate(_music, transform.position, Quaternion.identity);
        Destroy(music, 2f);
        GameObject partical = Instantiate(_particlEffect, transform.position, Quaternion.identity);
        Destroy(partical, 2f);
        yield return new WaitForSeconds(0.5f);
        Destroy(music);
        Destroy(partical);
    }
}
