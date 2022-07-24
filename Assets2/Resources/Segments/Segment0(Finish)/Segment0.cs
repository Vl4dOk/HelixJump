using UnityEngine;

public class Segment0 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        MenuManager.MainMenuManager.CallingMenu_VictoryScreen();
        LevelBiulder.MainLevelBiulder.IsControlPlayer = false;
        collision.rigidbody.isKinematic = true;
    }
}
