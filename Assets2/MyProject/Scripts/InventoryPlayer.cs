using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryPlayer : MonoBehaviour
{
    public static InventoryPlayer MainInventoryPlayer; private void Awake()
    {
        if (MainInventoryPlayer == null) { MainInventoryPlayer = this; }
        else if (MainInventoryPlayer != this) { Destroy(gameObject); }

        LoadingSave();
    }

    public Dictionary<string, int> Consumables = new Dictionary<string, int>();
    public Dictionary<string, float> Achievements = new Dictionary<string, float>();
    public Dictionary<string, byte> Skins = new Dictionary<string, byte>();

    


    



    private void FixedUpdate()
    {
        Achievements["TimeInPlaySecond"] += 0.02f; //Ќачисление времени в игре    0.02f * 50 операций в сек = 1 сек
    }


    public void LoadingSave()
    {

        Consumables.Add("Score", PlayerPrefs.HasKey("Score") ? PlayerPrefs.GetInt("Score") : 0);

        Achievements.Add("RecordTier", PlayerPrefs.HasKey("RecordTier") ? PlayerPrefs.GetInt("RecordTier") : 0);
        Achievements.Add("TimeInPlay", PlayerPrefs.HasKey("TimeInPlay") ? PlayerPrefs.GetInt("TimeInPlay") : 0);//Seconds



        if (PlayerPrefs.HasKey("Skin0"))
        {
            for (int i = 0; i < 8; i++)
            {
                if (PlayerPrefs.HasKey("Skin" + i))
                {
                    Skins.Add("Skin" + i, 1);
                }
                else
                {
                    Skins.Add("Skin" + i, 0);
        }   }   }
        else
        {
            PlayerPrefs.SetInt("Skin0", 1);
            Skins.Add("Skin" + 0, 1);
        }
    }


    public void SaveGame()
    {


        PlayerPrefs.SetInt("Score", Consumables["Score"]);

        PlayerPrefs.SetFloat("RecordTier", Achievements["RecordTier"]);
        PlayerPrefs.SetFloat("TimeInPlay", Achievements["TimeInPlay"]);

        for (int i = 0; i < 8; i++)
        {
            PlayerPrefs.SetInt("Skin" + i, Skins["Skin" + i] );            
        }


    }










}
