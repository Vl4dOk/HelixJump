using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Shop_Skins : MonoBehaviour
{
   

    private Dictionary<string, GameObject> _contentAll;
    [SerializeField] private GameObject[] _skinButtonBuy;
    [SerializeField] private Toggle[] _isToggleActive;

    private void Awake()
    {
        
    }

    private void Start()
    {

        
    }


    public void UseSkin(byte numberSkin)
    {
        _isToggleActive[numberSkin].enabled = true;

        for (int i = 0; i < _skinButtonBuy.Length; i++)
        {
            _isToggleActive[i].enabled = false;
        }

        _isToggleActive[numberSkin].enabled = true;
    }





    public void ChooseSkin(byte numberSkin)
    {
        
    }


    public void BuySkin0(byte numberSkin)
    {

       
        PriceComparison();
    }


    public void BuySkin1()
    {

       // _priceSkin = 100;
        PriceComparison();
    }


    public void BuySkin2()
    {

       // _priceSkin = 200;
        PriceComparison();
    }



    private void PriceComparison()
    {
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