using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadSide : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        PlayerManager playerManager = collision.GetComponent<PlayerManager>();
        if (playerManager != null)
        {
            playerManager._helthSideTime++;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        PlayerManager playerManager = collision.GetComponent<PlayerManager>();
        if (playerManager != null)
        {
            playerManager._helthSideTime = 0;
        }
    }
}
