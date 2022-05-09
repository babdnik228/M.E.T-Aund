using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelDeact : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;
    [SerializeField] private GameObject activPanel;
    public void ClickPanelDeact()
    {
        for (int i = 0; i < panels.Length; i++)
        {
            activPanel.SetActive(true);
            panels[i].SetActive(false);

        }
    }
}
