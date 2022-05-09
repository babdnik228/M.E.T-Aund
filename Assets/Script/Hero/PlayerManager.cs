using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int _distance;
    public int _coins;
    public int _helthSideTime = 0;
    public static int _deadObstacle;
    [SerializeField] private GameObject panel;
    
    private void Update()
    {
        _distance++;
        if(_helthSideTime == 78)
        {
            panel.SetActive(true);
            Destroy(gameObject);
        }
    }
}
