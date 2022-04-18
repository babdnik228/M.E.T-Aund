using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject _prefabObject;
    public Transform _borderRight;
    public Transform _borderLeft;
    public float _spawnInterval = 1;
    public float _spawnTimer;

    private void Update()
    {
        _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0)
        {
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        float randomX = Random.Range(_borderLeft.position.x, _borderRight.position.x);
        Vector3 position = transform.position;
        position.x = randomX;
        Instantiate(_prefabObject, position, Quaternion.identity);
        _spawnTimer = _spawnInterval;
    }
}
