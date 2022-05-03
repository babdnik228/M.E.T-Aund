using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIPlayer : MonoBehaviour
{
    public Text _cointTextUI;
    public Text _distanceUI;
    public Text _panelCoins;
    public Text _panelDistance;
    public Text _helthUI;
    [SerializeField]
    private PlayerManager _playerManager;
    [SerializeField]
    private Player _player;
    
    
    private void Update()
    {
        _distanceUI.text = _playerManager._distance.ToString();
        _cointTextUI.text = _playerManager._coins.ToString();
        _panelCoins.text = _cointTextUI.text;
        _panelDistance.text = _distanceUI.text;
        _helthUI.text = _player._health.ToString();
    }
   
}
