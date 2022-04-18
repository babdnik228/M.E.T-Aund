using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    Gradient gradient;
    GradientColorKey[] colorKey;
    GradientAlphaKey[] alphaKey;
   [SerializeField] private GameObject bulletPrefab;
    private void Start()
    {
        gradient = new Gradient();

        // Populate the color keys at the relative time 0 and 1 (0 and 100%)
        colorKey = new GradientColorKey[2];
        colorKey[0].color = Color.blue;
        colorKey[0].time = 0.0f;
        colorKey[1].color = Color.blue;
        colorKey[1].time = 1.0f;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  Bullet bulletScript = collision.GetComponent<Bullet>();
        Player playerScript = collision.GetComponent<Player>();
        if(playerScript )
        {
            //bulletPrefab._speedBullet += 20;
            playerScript._timerShotInterv = 0.2f;
            bulletPrefab.GetComponent<TrailRenderer>().colorGradient = gradient;
        }
    }
}
