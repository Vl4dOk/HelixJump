using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public static Game MainGame; private void Awake()
    {
        if (MainGame == null) { MainGame = this; }
        else if (MainGame != this) { Destroy(gameObject); }
    }

    public GameObject GO_Game;
        





    public void ConstrGame()
    {
        GO_Game = Instantiate(Resources.Load<GameObject>("_CommonPrefabs/EmptyObject"), new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)));
        GO_Game.name = "Game";
    }


}
