using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public static Character MainCharacterConstr; private void Awake()
    {
        if (MainCharacterConstr == null) { MainCharacterConstr = this; }
        else if (MainCharacterConstr != this) { Destroy(gameObject); }
    }

    public GameObject GO_character;//GameObject
    protected Rigidbody RB_character;

    protected byte _health;
    public byte _speedJump;
    protected float SensitivityPlayer;//Чувствительность мышки и кнопок
    protected float _isJump = 0; //bool




    //public abstract void ConstrCharacter(Transform transform, Transform parent = null);



    public void ConstrCharacterSphere(Transform transform, Transform parent = null)
    {
        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterSphere"), transform.position, transform.rotation, parent);
        GO_character.name = "CharacterSphere";
        _health = 1;
        _speedJump = 15;
        SensitivityPlayer = 0.1f;
    }

    public void ConstrCube(Transform parent = null)
    {
        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterCube"), transform.position, transform.rotation, parent);
        _health = 1;
        _speedJump = 20;
        SensitivityPlayer = 0.6f;
    }

    public void ConstrCylinder(Transform transform, Transform parent = null)
    {
        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterCylinder"), transform.position, transform.rotation, parent);
        _health = 1;
        _speedJump = 18;
        SensitivityPlayer = 0.8f;
    }
    public void ConstrCapsule(Transform transform, Transform parent = null)
    {
        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterCapsule"), transform.position, transform.rotation, parent);
        _health = 2;
        _speedJump = 12;
        SensitivityPlayer = 0.8f;
    }


    protected void Start()
    {
        RB_character = GetComponent<Rigidbody>();
    }




    protected void FixedUpdate()
    {
        if (_isJump > 0)
        { _isJump -= Time.deltaTime; }
    }






   









    public void JumpCharacter(float jumpSpeed)
    {
        if (_isJump <= 0)
        {
            RB_character.AddForce(0f, jumpSpeed, 0f, ForceMode.Impulse);
            _isJump += 0.05f;
        }
    }

    public void DamageCharacter(byte Damage = 1)
    {
        if (_health > 1)
        {
            _health -= Damage;
        }
        else
        {
            MenuManager.MainMenuManager.CallingMenu_DefeatScreen();
            LevelBiulder.MainLevelBiulder.IsControlPlayer = false;
            RB_character.isKinematic = true;
        }
    }














   
    //public class Cube : Character
    //{
    //   /*public Cube(Transform parent = null)
    //    {
    //        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterCube"), new Vector3(0, 5, 0), Quaternion.Euler(new Vector3(0, 0, 0)), parent);
    //        _health = 1;
    //        _speedJump = 20;
    //        SensitivityPlayer = 0.6f;
    //    }*/
    //    public void ConstrCube(Transform parent = null)
    //    {
    //        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterCube"), new Vector3(0, 5, 0), Quaternion.Euler(new Vector3(0, 0, 0)), parent);
    //        _health = 1;
    //        _speedJump = 20;
    //        SensitivityPlayer = 0.6f;
    //    }

    //}
    //public class Cylinder : Character
    //{
    //    /*public Cylinder(Transform parent = null)
    //    {
    //        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterCylinder"), new Vector3(0, 5, 0), Quaternion.Euler(new Vector3(0, 0, 0)), parent);
    //        _health = 1;
    //        _speedJump = 18;
    //        SensitivityPlayer = 0.8f;
    //    }*/
    //    public void ConstrCylinder(Transform parent = null)
    //    {
    //        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterCylinder"), new Vector3(0, 5, 0), Quaternion.Euler(new Vector3(0, 0, 0)), parent);
    //        _health = 1;
    //        _speedJump = 18;
    //        SensitivityPlayer = 0.8f;
    //    }
    //}
    //public class Capsule : Character
    //{
    //   /*public Capsule(Transform parent = null)
    //    {
    //        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterCapsule"), new Vector3(0, 5, 0), Quaternion.Euler(new Vector3(0, 0, 0)), parent);
    //        _health = 2;
    //        _speedJump = 12;
    //        SensitivityPlayer = 0.8f;
    //    }*/
    //    public void ConstrCapsule(Transform parent = null)
    //    {
    //        GO_character = Instantiate(Resources.Load<GameObject>("Player/Charactor/Prefabs/CharacterCapsule"), new Vector3(0, 5, 0), Quaternion.Euler(new Vector3(0, 0, 0)), parent);
    //        _health = 2;
    //        _speedJump = 12;
    //        SensitivityPlayer = 0.8f;
    //    }
    //}


}
























