using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Dictionary<string, int> Consumables = new Dictionary<string, int>();
    public Dictionary<string, float> Achievements = new Dictionary<string, float>();
    public Dictionary<string, int> Skins = new Dictionary<string, int>();


    private void Awake()
    {
        LoadingSave();
    }


    public void LoadingSave()
    {
        Consumables.Add("Coins", PlayerPrefs.HasKey("Coins") ? PlayerPrefs.GetInt("Coins") : 0);

        Achievements.Add("RecordTier", PlayerPrefs.HasKey("RecordTier") ? PlayerPrefs.GetInt("RecordTier") : 0);
        Achievements.Add("TimeInPlay", PlayerPrefs.HasKey("TimeInPlay") ? PlayerPrefs.GetInt("TimeInPlay") : 0);//Seconds

        
        Skins.Add("Content0", 1);
        for (int i = 1; i < 12; i++)
        {
            Skins.Add("Content" + i, PlayerPrefs.HasKey("Content" + i) ? PlayerPrefs.GetInt("Content" + i) : 0);

        }
    }

    public void SaveInventory()
    {
        PlayerPrefs.SetInt("Coins", Consumables["Coins"]);
        PlayerPrefs.SetFloat("RecordTier", Achievements["RecordTier"]);        
    }


    private void AddCoins(int numberConis)
    {
        PlayerPrefs.SetInt("Coins", Consumables["Coins"] += numberConis);
    }


}
