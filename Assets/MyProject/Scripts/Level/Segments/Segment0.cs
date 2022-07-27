using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class Segment0 : MonoBehaviour
{
    [SerializeField] private GameManager _gameManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.TryGetComponent(out Character character))
        {
            MenuManager.MainMenuManager.CallingMenu_VictoryScreen();
        }
    }

   


}
