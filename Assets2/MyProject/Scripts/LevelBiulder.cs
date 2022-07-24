using UnityEngine;

public class LevelBiulder : MonoBehaviour
{
    public static LevelBiulder MainLevelBiulder; private void Awake()
    {
        if (MainLevelBiulder == null) { MainLevelBiulder = this; }
        else if (MainLevelBiulder != this) { Destroy(gameObject); }
    }


    [SerializeField] private GameObject EmptyObject;
    [SerializeField] private GameObject PlayerPrefab;
    private GameObject Game;
    private GameObject Level;
    private GameObject Player;
    public bool IsControlPlayer = false;

    [SerializeField] private GameObject _startTier;
    [SerializeField] private GameObject _finishTier;

    private GameObject _newTier;
    public int _builtTiers;






    public void BuildLevel()
    {
        AddGame(); 
        AddLevel(); 
        AddPlayer();
        IsControlPlayer = true;
        AddStartTier();
        AddTier(); AddTier(); AddTier();
    }


    public void DestroyGame()
    {
        Destroy(Game);
        _builtTiers = 0;
    }

   

    private void AddGame()
    {   Game = Instantiate(EmptyObject, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
    }

    private void AddLevel()
    {   Level = Instantiate(EmptyObject, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0), Game.transform);
    }

    private void AddPlayer()
    {   Player = Instantiate(PlayerPrefab, new Vector3(0, 5, 0), Quaternion.Euler(0, 0, 0), Game.transform);
    }


    public void AddStartTier()
    {   _newTier = Instantiate(_startTier,new Vector3(0, 0, 0),Quaternion.Euler(0, 0, 0), Level.transform);
        _builtTiers++;
    }

    public void AddTier()
    {
        _newTier = Instantiate(Levels.MainLevels.Tiers[Random.Range(0, Levels.MainLevels.Tiers.Count)], Level.transform);
        _newTier.transform.position = new Vector3(0, -6 * _builtTiers, 0);
        _newTier.transform.rotation = Quaternion.Euler(0, Random.Range(0,360), 0);
        _builtTiers++;
    }

    public void AddFinishTier()
    {   _newTier = Instantiate(_finishTier, Level.transform);
        _newTier.transform.position = new Vector3(0, -6 * _builtTiers, 0);
        _builtTiers++;
    }
}
