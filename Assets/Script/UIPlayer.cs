using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPlayer : MonoBehaviour
{
    public Text _cointTextUI;
    public Text _distanceUI;
    [SerializeField]
    private PlayerManager _playerManager;
    
    
    private void Update()
    {
        _distanceUI.text = "Расстояние:" + _playerManager._distance.ToString();
        _cointTextUI.text = _playerManager._coins.ToString();

    }
}
