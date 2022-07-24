using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager MainUIManager; private void Awake()
    {
        if (MainUIManager == null) { MainUIManager = this; }
        else if (MainUIManager != this) { Destroy(gameObject); }
    }


    [SerializeField] private Text _textCurrentLevel;
    [SerializeField] private Text _textNextLevel;
    [SerializeField] private Text _textScore;
    [SerializeField] private Text _textRecord;
    [SerializeField] private Text _textCurrentTier;

    [SerializeField] public Slider _barCurrentTier;



    private void Update()//Вывод статистики на экран (_interface_Payer)
    {
        _textCurrentLevel.text = Levels.MainLevels.NameLevel.ToString();
        _textNextLevel.text = (Levels.MainLevels.NameLevel+1).ToString();

        _textScore.text = "Score: " + GameManager.MainGameManeger.Score;
        _textRecord.text = "Record: " + GameManager.MainGameManeger.Record;
        _textCurrentTier.text = "Tier: " + GameManager.MainGameManeger.CurrentTier;

    }

    public void Update_sliderCurrentTier()
    {
        _barCurrentTier.maxValue = Levels.MainLevels.MaxTier;
        _barCurrentTier.value = GameManager.MainGameManeger.CurrentTier;

    }


    //public void Calling_interface_Payer()
    //{   _interface_Payer.SetActive(true);
    //}
    //public void Close_interface_Payer()
    //{   _interface_Payer.SetActive(false);
    //}



}

