using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{   
    private void OnTriggerEnter2D(Collider2D collision)
    {
      //  Bullet bulletScript = collision.GetComponent<Bullet>();
        Player playerScript = collision.GetComponent<Player>();
        PlayerManager playerManager = collision.GetComponent<PlayerManager>();
        if(playerScript )
        {
            playerManager._coins++;
            //bulletPrefab._speedBullet += 20;
            playerScript._timerShotInterv = 0.2f;
        }
    }
}
