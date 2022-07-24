using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player MainPlayerConstr; private void Awake()
    {
        if (MainPlayerConstr == null) { MainPlayerConstr = this; }
        else if (MainPlayerConstr != this) { Destroy(gameObject); }
    }
    public GameObject GO_Player;
    public Character _character;
    private CameraController _camera;
    private int _healh;





/*
    public Player(byte numberCharacter, Transform parent = null)
    {
        GO_Player = Instantiate(Resources.Load<GameObject>("_CommonPrefabs/EmptyObject"), new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)),parent);
        GO_Player.name = "Player";

        _ = numberCharacter == 0 ? _character = new Sphere(GO_Player.transform) :
            numberCharacter == 1 ? _character = new Character.Cube(GO_Player.transform) :
            numberCharacter == 2 ? _character = new Character.Cylinder(GO_Player.transform) : 
                                   _character = new Character.Capsule(GO_Player.transform);


        _camera = new CameraController(GO_Player.transform);
    
    }
*/



    public void ConstrPlayer(byte numberCharacter, Transform parent = null)
    {
        GO_Player = Instantiate(Resources.Load<GameObject>("_CommonPrefabs/EmptyObject"), new Vector3(0, 0, 0), Quaternion.Euler(new Vector3(0, 0, 0)), parent);
        GO_Player.name = "Player";

        Character.MainCharacterConstr.ConstrCharacterSphere(GO_Player.transform, parent);

        _camera.ConstrCameraController(GO_Player.transform, parent);
    }

}
