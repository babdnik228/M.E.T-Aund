using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuReal : MonoBehaviour
{
    [SerializeField]
    private string nameScene;
    [SerializeField]
    private GameObject[] componentUI;
    [SerializeField]
    private GameObject componentCurrent;
    public void ClickToMenu()
    {
        componentCurrent.SetActive(true);
        for (int i = 0; i < componentUI.Length; i++)
        {
            componentUI[i].SetActive(false);
        }
        
    }
    public void ClickToSoloGame()
    {
        SceneManager.LoadScene(nameScene);
    }
}
