using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Menu_Shop : MonoBehaviour
{

    [SerializeField] private GameObject _menu_Shop;
    [SerializeField] private TextMeshProUGUI _text_Coins;


    [SerializeField] private GameObject _menu_Shop_Window, 
                                        _menu_Shop_Consumables,
                                        _menu_Shop_Skins,
                                        _menu_Shop_Backgrounds,
                                        _menu_Shop_Sounds;



    private void Awake()
    {  
        if (_menu_Shop == null) { _menu_Shop = gameObject;}
        Deactivate_Menu_Shop();
    }



    public void Activate_Menu_Shop() { _menu_Shop.SetActive(true);}
    public void Deactivate_Menu_Shop() { _menu_Shop.SetActive(false);}

    private void OnEnable() { Activate_Menu_Shop_Window(); }

    private void OnDisable() { Deactivate_Menu_Shop_ALL(); }




    public void Activate_Menu_Shop_Window() { _menu_Shop_Window.SetActive(true); }
    public void Deactivate_Menu_Shop_Window() { _menu_Shop_Window.SetActive(false); }

    public void Activate_Menu_Shop_Consumables() 
    {
        Deactivate_Menu_Shop_ALL();
        _menu_Shop_Consumables.SetActive(true);
    }
    public void Deactivate_Menu_Shop_Consumables() { _menu_Shop_Consumables.SetActive(false); }

    public void Activate_Menu_Shop_Skins() 
    {
        Deactivate_Menu_Shop_ALL();
        _menu_Shop_Skins.SetActive(true);
    }
    public void Deactivate_Menu_Shop_Skins() { _menu_Shop_Skins.SetActive(false); }

    public void Activate_Menu_Shop_Backgrounds() 
    {
        Deactivate_Menu_Shop_ALL();
        _menu_Shop_Backgrounds.SetActive(true);
    }
    public void Deactivate_Menu_Shop_Backgrounds() { _menu_Shop_Backgrounds.SetActive(false); }

    public void Activate_Menu_Shop_Sounds() 
    {
        Deactivate_Menu_Shop_ALL();
        _menu_Shop_Sounds.SetActive(true);       
    }
    public void Deactivate_Menu_Shop_Sounds() { _menu_Shop_Sounds.SetActive(false); }

    public void Deactivate_Menu_Shop_ALL()
    {
        Deactivate_Menu_Shop_Window();
        Deactivate_Menu_Shop_Skins();
        Deactivate_Menu_Shop_Consumables();
        Deactivate_Menu_Shop_Backgrounds();
        Deactivate_Menu_Shop_Sounds();
    }


  







}