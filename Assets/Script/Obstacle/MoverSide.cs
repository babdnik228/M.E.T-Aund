using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverSide : MonoBehaviour
{
   
    
   [SerializeField] private float _speedStandart;
    private void Start()
    {
        
        Destroy(gameObject, 5f);
    }

    private void Update()
    {
        transform.localPosition += transform.right * _speedStandart * Time.deltaTime;
    }
}
