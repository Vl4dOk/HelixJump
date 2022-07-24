using UnityEngine;

public class Tier : MonoBehaviour
{
    [SerializeField] private float _sensitivity;
    private Vector3 _previousMousePosition;

    private void Update()
    {
        if (!MenuManager.MainMenuManager._isMenu_PauseIncluded)
        {
            if (Input.GetMouseButton(0))
            {
                Vector3 delta = Input.mousePosition - _previousMousePosition;
                transform.Rotate(0f, -delta.x * _sensitivity, 0f);
            }
            _previousMousePosition = Input.mousePosition;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A)) { transform.Rotate(0f, -_sensitivity * 15, 0f); }
        if (Input.GetKey(KeyCode.D)) { transform.Rotate(0f, _sensitivity * 15, 0f); }
    }

    private void OnTriggerExit(Collider other)
    {
        if (Levels.MainLevels.MaxTier > LevelBiulder.MainLevelBiulder._builtTiers)//При пересечении триггера либо строится следующий тир, либо финальный в зависимости от количества заданное в уровне
        { LevelBiulder.MainLevelBiulder.AddTier(); }
        else if (Levels.MainLevels.MaxTier == LevelBiulder.MainLevelBiulder._builtTiers)
        { LevelBiulder.MainLevelBiulder.AddFinishTier(); }

        UIManager.MainUIManager.Update_sliderCurrentTier();

        GameManager.MainGameManeger.AddNumberTier();
        Destroy(gameObject);
    }



  

}
