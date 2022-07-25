using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Shop_Skins : MonoBehaviour
{
    public static Menu_Shop_Skins ShopSkinsManager; private void Awake()
    {
        if (ShopSkinsManager == null) { ShopSkinsManager = this; }
        else if (ShopSkinsManager != this) { Destroy(gameObject); }
    }


    public byte CurrentSkin;
    private const short _totalNumberOfSkins = 15;
    private short _priceSkin;
    private Dictionary<string, byte> _openSkins;
    [SerializeField] private GameObject[] _skinButtonBuy;

    private void Start()
    {
        
       // _openSkins = InventoryPlayer.MainInventoryPlayer.Skins;



        for (int i = 0; i < 8; i++)
        {
            if (_openSkins["Skin" + i] == 1)
            {
                _skinButtonBuy[i].SetActive(false);
            }
        }
    }



    private void OpenSkin()
    {

    }


    private void OpenSkin1()
    {

    }





    public void ChooseSkin(byte numberSkin)
    {
        CurrentSkin = numberSkin;
    }


    public void BuySkin0(byte numberSkin)
    {
        
        _priceSkin = 0;
        PriceComparison();
    }  


    public void BuySkin1()
    {
        
        _priceSkin = 100;
        PriceComparison();
    }


    public void BuySkin2()
    {
        
        _priceSkin = 200;
        PriceComparison();
    }



    private void PriceComparison()
    {
        if (GameManager.MainGameManeger.Score >= _priceSkin)
        {
            AreYouSure();
        }
        else
        {
            //we don't have enough coins
        }
    }

    public void AreYouSure()
    {
        

    }

    public void YouAgree()
    {
       
    }
    public void YouDontAgree()
    {
        
    }

   
}
