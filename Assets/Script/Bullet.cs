using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float _speedBullet;
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
            Destroy(obstacle.gameObject);
            Destroy(gameObject);
        }
    }
}
