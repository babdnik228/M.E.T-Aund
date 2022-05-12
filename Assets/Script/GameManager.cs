using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject music;
    private void Update()
    {
        if(Button_Realiz.isMusic == true)
        {
            music.SetActive(false);
        }
        else if(Button_Realiz.isMusic == false)
        {
            music.SetActive(true);

        }
    }
}
