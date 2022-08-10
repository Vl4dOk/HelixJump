using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_VictoryScreen : MonoBehaviour
{
    [SerializeField] private GameObject _menu_VictoryScreen;

    private void Awake()
    {
        if (_menu_VictoryScreen == null) { _menu_VictoryScreen = gameObject; }
        GlobalEventManager.Event_PlayerOnFinish += Activate_Menu_Victory;

        Deactivate_Menu_Victory();
    }



    public void Activate_Menu_Victory(){   _menu_VictoryScreen.SetActive(true);}
    public void Deactivate_Menu_Victory(){ _menu_VictoryScreen.SetActive(false);}


}
