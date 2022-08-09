using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Shop : MonoBehaviour
{
    public static Menu_Shop ShopManager; private void Awake()
    {
        if (ShopManager == null) { ShopManager = this; }
        else if (ShopManager != this) { Destroy(gameObject); }
    }


    [SerializeField] private GameObject _menu_Shop_Window;
    [SerializeField] private GameObject _menu_Shop_Consumables;
    [SerializeField] private GameObject _menu_Shop_Skins;
    [SerializeField] private GameObject _menu_Shop_Backgrounds;
    [SerializeField] private GameObject _menu_Shop_Sounds;




    public void CallingMenu_Shop_Window() { _menu_Shop_Window.SetActive(true); }
    public void CloseMenu_Shop_Window() { _menu_Shop_Window.SetActive(false); }

    public void CallingMenu_Shop_Consumables() { _menu_Shop_Consumables.SetActive(true); }
    public void CloseMenu_Shop_Consumables() { _menu_Shop_Consumables.SetActive(false); }

    public void CallingMenu_Shop_Skins() { _menu_Shop_Skins.SetActive(true); }
    public void CloseMenu_Shop_Skins() { _menu_Shop_Skins.SetActive(false); }

    public void CallingMenu_Shop_Backgrounds() { _menu_Shop_Backgrounds.SetActive(true); }
    public void CloseMenu_Shop_Backgrounds() { _menu_Shop_Backgrounds.SetActive(false); }

    public void CallingMenu_Shop_Sounds() { _menu_Shop_Sounds.SetActive(true); }
    public void CloseMenu_Shop_Sounds() { _menu_Shop_Sounds.SetActive(false); }












}