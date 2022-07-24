using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Character
{
   /*
    public Sphere(Transform transform, Transform parent = null)
    {
        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterSphere"), transform.position, transform.rotation, parent);
        GO_character.name = "CharacterSphere";
        _health = 1;
        _speedJump = 15;
        SensitivityPlayer = 0.1f;
    }*/
    public void ConstrCharacter(Transform transform, Transform parent = null)
    {
        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterSphere"), transform.position, transform.rotation, parent);
        GO_character.name = "CharacterSphere";
        _health = 1;
        _speedJump = 15;
        SensitivityPlayer = 0.1f;
    }

}
