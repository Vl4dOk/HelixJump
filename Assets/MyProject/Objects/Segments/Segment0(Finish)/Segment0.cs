using UnityEngine;

public class Segment0 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        MenuManager.MainMenuManager.CallingMenu_VictoryScreen();
        Time.timeScale = 0f;
    }
}
