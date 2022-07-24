using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
   // private bool isGameIncluded = false;
    private byte _numberLevel = 1;
    private Game Number1, Number2, Number3;

    private void Start()
    {
        NewGame();
    }


    public void NewGame()
    {
        //isGameIncluded = true;
        Number1 = Game.MainGame;
        Number1.ConstrGame();
        Number2 = Game.MainGame;
        Number2.ConstrGame();
        Number3 = Game.MainGame;
        Number3.ConstrGame();

        Level.MainLevel.ConstrLevel(_numberLevel, Game.MainGame.GO_Game.transform);

        Player.MainPlayerConstr.ConstrPlayer(0, Game.MainGame.GO_Game.transform);      
       




    }


}
