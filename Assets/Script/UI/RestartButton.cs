using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    public void RestartButtonClick()
    {
        Player.player_singolton.is_dead_indicator = false;
        SceneManager.LoadScene(1);  
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void ExitToMeny()
    {
        Player.player_singolton.is_dead_indicator = false;
        SceneManager.LoadScene(0);
    }
    
}
