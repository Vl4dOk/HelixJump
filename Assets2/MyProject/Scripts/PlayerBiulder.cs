using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBiulder : MonoBehaviour
{
    public static PlayerBiulder MainPlayerBiulder; private void Awake()
    {
        if (MainPlayerBiulder == null) { MainPlayerBiulder = this; }
        else if (MainPlayerBiulder != this) { Destroy(gameObject); }

    }
    // CharacterNumber = PlayerPrefs.GetInt("CharacterNumber");
    // CharacterSkinNumber = PlayerPrefs.GetInt("CharacterSkinNumber");


    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private GameObject _cameraPrefab;
    [HideInInspector] public GameObject _player;
    private GameObject _camera;


    [SerializeField] private GameObject[] CharactersPrefab;    
    [HideInInspector] public GameObject CurrentCharacter;
    public byte CharacterNumber = 0;

    [SerializeField] private Material[] CharactersMaterialPrefab;
    [SerializeField] private byte CharacterSkinNumber;



    public PlayerBiulder()
    {
        _player = _playerPrefab;
        _player.name = "Player";

        _camera = _cameraPrefab;
        _camera.transform.SetParent(_player.transform);
        _camera.name = "Camera";

        CurrentCharacter = CharactersPrefab[CharacterNumber];
        CurrentCharacter.transform.SetParent(_player.transform);
        CurrentCharacter.name = "Character" + CharacterNumber;

    }


    public void AddPlayer()
    {
        _player = Instantiate(_playerPrefab, new Vector3(0, 0, 0), Quaternion.Euler(0, 0, 0));
        _player.name = "Player";
        AddCharacter();
        AddCamera();

        ChangeCharacterSkin();
    }

    private void AddCamera()
    {
        _camera = Instantiate(_cameraPrefab, new Vector3(0, 10, -9), Quaternion.Euler(40, 0, 0), _player.transform);
    }

    private void AddCharacter()
    {
        CurrentCharacter = Instantiate(CharactersPrefab[CharacterNumber], new Vector3(0, 6, -3), Quaternion.Euler(0, 0, 0), _player.transform);
    }

    private void ChangeCharacterSkin()
    {
        CurrentCharacter.GetComponent<MeshRenderer>().material = CharactersMaterialPrefab[CharacterSkinNumber];
    }


}
