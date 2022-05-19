using UnityEngine;

public class CameraOptions : MonoBehaviour
{
    public bool is_meny_camera;
    private void Update()
    {
        if(is_meny_camera == true)
        {
         if(Player.player_singolton.is_dead_indicator == true)
            {
            Cursor.visible = true;
            }
        if (Player.player_singolton.is_dead_indicator == false)
            {
            Cursor.visible = false;
            }
        }
        if(is_meny_camera == false)
        {
            Cursor.visible = true;
        }

    }
}
