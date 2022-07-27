using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBody : MonoBehaviour
{
    private GameObject _characterBody;
    private byte _characterNumber;



    public void Construct(GameObject characterBody, byte characterNumber)
    {
        _characterBody = characterBody;
        _characterNumber = characterNumber;


        AddCharacterBody(_characterNumber);
    }

    private void AddCharacterBody(byte numberCharacterSkin)
    {
        _characterBody = Instantiate(Resources.Load<GameObject>("Player/Character/Body/Body" + _characterNumber), _characterBody.transform);
    }



}
