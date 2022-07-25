using UnityEngine;

public class Tier : MonoBehaviour
{
    private bool IsControlOn;
    private Vector3 _previousMousePosition;


    

    private void OnTriggerExit(Collider other)
    {
        if (Levels.MainLevels.MaxTier > LevelBiulder.MainLevelBiulder._builtTiers)//��� ����������� �������� ���� �������� ��������� ���, ���� ��������� � ����������� �� ���������� �������� � ������
        { LevelBiulder.MainLevelBiulder.AddTier(); }
        else if (Levels.MainLevels.MaxTier == LevelBiulder.MainLevelBiulder._builtTiers)
        { LevelBiulder.MainLevelBiulder.AddFinishTier(); }

        UIManager.MainUIManager.Update_sliderCurrentTier();

        GameManager.MainGameManeger.AddNumberTier();
        Destroy(gameObject);
    }



  

}
