using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform _pointShot;
    public GameObject _bulletPrefab;
    public float _timerShotInterv = 5;
    public float _shotTimer;
    private void Update()
    {
        Move();
        Shoot();
    }
    void Move()
    {
        Vector3 mousPos = Input.mousePosition;
        Vector3 realPos = Camera.main.ScreenToWorldPoint(mousPos);
        realPos.z = 0;
        transform.position = realPos;
    }
    void Shoot()
    {
        _shotTimer -= Time.deltaTime;
        if (Input.GetMouseButtonDown(1))
        {
            if (_shotTimer <= 0)
            {
                Instantiate(_bulletPrefab, _pointShot.transform.position, Quaternion.identity);
                _shotTimer = _timerShotInterv;
            }
        }
    }
}
