using System.Collections.Generic;
using UnityEngine;

public class Levels : MonoBehaviour
{
    public static Levels MainLevels; private void Awake()
    {
        if (MainLevels == null) { MainLevels = this; }
        else if (MainLevels != this) { Destroy(gameObject); }
    }


    public int NameLevel;
    public int MaxTier;
    [SerializeField] private GameObject[] TiersPrefab_1_2_3;
    [SerializeField] private GameObject[] TiersPrefab_4_5_6;
    [SerializeField] private GameObject[] TiersPrefab_7_8_9;
    //public GameObject[] Tiers;
    public List<GameObject> Tiers = new List<GameObject>();



    private void Start()
    {
        Level1();
    }


    public void Level1()
    {
        NameLevel = 1;
        MaxTier = 40;

        if (Tiers != null) { Tiers.RemoveRange(0, Tiers.Count); }
        for (int i = 0; i < TiersPrefab_1_2_3.Length; i++)
        {
            Tiers.Add(TiersPrefab_1_2_3[i]);
        }
    }

    public void Level2()
    {
        NameLevel = 2;
        MaxTier = 50;

        
        for (int i = 0; i < TiersPrefab_1_2_3.Length; i++)
        {
            Tiers.Add(TiersPrefab_1_2_3[i]);

        }
    }

    public void Level3()
    {
        NameLevel = 3;
        MaxTier = 60;

        
        for (int i = 0; i < TiersPrefab_1_2_3.Length; i++)
        {
            Tiers.Add(TiersPrefab_1_2_3[i]);
        }
    }

    public void Level4()
    {
        NameLevel = 4;
        MaxTier = 65;


        for (int i = 0; i < TiersPrefab_4_5_6.Length; i++)
        {
            Tiers.Add(TiersPrefab_4_5_6[i]);
        }
    }

    public void Level5()
    {
        NameLevel = 5;
        MaxTier = 70;


        for (int i = 0; i < TiersPrefab_4_5_6.Length; i++)
        {
            Tiers.Add(TiersPrefab_4_5_6[i]);
        }
    }

    public void Level6()
    {
        NameLevel = 6;
        MaxTier = 75;


        for (int i = 0; i < TiersPrefab_4_5_6.Length; i++)
        {
            Tiers.Add(TiersPrefab_4_5_6[i]);
        }
    }


    public void Level7()
    {
        NameLevel = 7;
        MaxTier = 80;


        for (int i = 0; i < TiersPrefab_7_8_9.Length; i++)
        {
            Tiers.Add(TiersPrefab_7_8_9[i]);
        }
    }





}
