using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Dictionary<string, int> Consumables = new Dictionary<string, int>();
    public Dictionary<string, float> Achievements = new Dictionary<string, float>();
    public Dictionary<string, byte> Skins = new Dictionary<string, byte>();

    private void Awake()
    {
        LoadingSave();
    }


    public void LoadingSave()
    {
        Consumables.Add("Coins", PlayerPrefs.HasKey("Coins") ? PlayerPrefs.GetInt("Coins") : 0);
        Achievements.Add("RecordTier", PlayerPrefs.HasKey("RecordTier") ? PlayerPrefs.GetInt("RecordTier") : 0);
        Achievements.Add("TimeInPlay", PlayerPrefs.HasKey("TimeInPlay") ? PlayerPrefs.GetInt("TimeInPlay") : 0);//Seconds    
        SaveInventory();
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
