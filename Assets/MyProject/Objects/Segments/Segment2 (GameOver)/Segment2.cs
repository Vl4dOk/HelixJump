using UnityEngine;

public class Segment2 : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        MenuManager.MainMenuManager.CallingMenu_DefeatScreen();
        Time.timeScale = 0f;        
    }
       

    
}
