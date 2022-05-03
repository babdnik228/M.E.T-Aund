using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSpawn : MonoBehaviour
{
    [SerializeField]
    private float _timeSpawn;
    [SerializeField]
    private GameObject _spawn;
    private void Update()
    {
        Invoke("InvokeSpawn", _timeSpawn);
    }
    private void InvokeSpawn()
    {
        _spawn.SetActive(true);
    }
}
