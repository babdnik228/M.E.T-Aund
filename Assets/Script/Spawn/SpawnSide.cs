using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSide : MonoBehaviour
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
      
            float randomY = Random.Range(_borderLeft.position.y, _borderRight.position.y);
            Vector3 position = transform.position;
            position.y = randomY;
            Instantiate(_prefabObject, position, Quaternion.identity);
            _spawnTimer = _spawnInterval;
        
        

    }
}
