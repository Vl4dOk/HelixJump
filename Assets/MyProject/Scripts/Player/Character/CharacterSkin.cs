using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSkin : MonoBehaviour
{
    private GameObject _characterSkin;
    private MeshRenderer _materialSkin;
    private byte _numberCharacterSkin;
    private byte _numberSkinMaterial;


    public void Construct(GameObject characterSkin, byte numberCharacterSkin, byte numberSkinMaterial)
    {
        _characterSkin = characterSkin;
        _numberCharacterSkin = numberCharacterSkin;
        _numberSkinMaterial = numberSkinMaterial;

        


        AddCharacterSkin(_numberCharacterSkin);
        AddSkinMaterial(_numberSkinMaterial);
    }



    private void AddCharacterSkin(byte numberCharacterSkin)
    {
        _characterSkin = Instantiate(Resources.Load<GameObject>("Player/Character/Skins/Skins" + numberCharacterSkin), _characterSkin.transform);

    }

    private void AddSkinMaterial(byte numberSkinMaterial)
    {
        _materialSkin = _characterSkin.GetComponent<MeshRenderer>();
        _materialSkin.material = Resources.Load<Material>("Player/Character/Materials/Content" + numberSkinMaterial);
       
    }


}
