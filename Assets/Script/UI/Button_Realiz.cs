using UnityEngine;


public class Button_Realiz : MonoBehaviour
{
    [SerializeField] private GameObject music_FB;
    public static bool isMusic = false;
    public void MusicDeActivate()
    {
        isMusic = true;
        music_FB.SetActive(false);
    }
}
