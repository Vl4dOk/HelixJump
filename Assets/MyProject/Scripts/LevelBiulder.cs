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
    private GameObject _game;
    private GameObject _level;
    private GameObject _player;
    private byte _playerNumber;


    [SerializeField] private GameObject _startTier;
    [SerializeField] private GameObject _finishTier;

    private GameObject _newTier;
    public int _builtTiers;
    public bool IsControlPlayer;







    public void BuildLevel()
    {
        AddGame(); 
        AddLevel();

        AddStartTier();
        AddTier(); AddTier(); AddTier();


        AddPlayer();
        IsControlPlayer = true;

    }


    public void DestroyGame()
    {
        IsControlPlayer = false;
        Destroy(_game);
        _builtTiers = 0;
    }

   

    private void AddGame()
    {   
        _game = Instantiate(EmptyObject, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        _game.name = "Game";
    }

    private void AddLevel()
    {   
        _level = Instantiate(EmptyObject, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0), _game.transform);
        _level.name = "Level";
    }

    private void AddPlayer()
    {
        Player.MainPlayerConstr.ConstrPlayer(_playerNumber, _game.transform);
        
    }


    public void AddStartTier()
    {   _newTier = Instantiate(_startTier,new Vector3(0, 0, 0),Quaternion.Euler(0, 0, 0), _level.transform);
        _builtTiers++;
    }

    public void AddTier()
    {
        _newTier = Instantiate(Levels.MainLevels.Tiers[Random.Range(0, Levels.MainLevels.Tiers.Count)], _level.transform);
        _newTier.transform.position = new Vector3(0, -6 * _builtTiers, 0);
        _newTier.transform.rotation = Quaternion.Euler(0, Random.Range(0,360), 0);
        _builtTiers++;
    }

    public void AddFinishTier()
    {   _newTier = Instantiate(_finishTier, _level.transform);
        _newTier.transform.position = new Vector3(0, -6 * _builtTiers, 0);
        _builtTiers++;
    }
}
