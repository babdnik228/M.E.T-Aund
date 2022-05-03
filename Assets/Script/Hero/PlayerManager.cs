using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public int _distance;
    public int _coins;
    public int _helthSideTime = 0;
    
    private void Update()
    {
        _distance++;
        if(_helthSideTime == 78)
        {
            Destroy(gameObject);
        }
    }
}
