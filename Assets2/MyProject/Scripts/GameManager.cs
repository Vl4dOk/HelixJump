using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager MainGameManeger; private void Awake()
    {
        if (MainGameManeger == null) { MainGameManeger = this; }
        else if (MainGameManeger != this) { Destroy(gameObject); }

        Record = PlayerPrefs.GetInt("Record");
    }

    public bool IsTheGameRunning = false;
    public int Level;
    public int Score;
    public int Record;//Score

    public int CurrentTier = 0;

    
    public void StartGame()
    {
        IsTheGameRunning = true;
        LevelBiulder.MainLevelBiulder.BuildLevel();
        MenuManager.MainMenuManager.CallingInterface_Payer();
        MenuManager.MainMenuManager.CloseMainMenu();
    }

    public void FinishGame()
    {
        IsTheGameRunning = false;
        CurrentTier = 0;
        UIManager.MainUIManager._barCurrentTier.value = 0;
        LevelBiulder.MainLevelBiulder.DestroyGame();
        MenuManager.MainMenuManager.CloseInterface_Payer();
        Time.timeScale = 1f;
    }

    public void NextLevel()
    {
        FinishGame();

        switch (Levels.MainLevels.NameLevel)
        {
            case 1:
                Levels.MainLevels.Level2();
                break;
            case 2:
                Levels.MainLevels.Level3();
                break;
            case 3:
                Levels.MainLevels.Level4();
                break;
            case 4:
                Levels.MainLevels.Level5();
                break;
            case 5:
                Levels.MainLevels.Level6();
                break;
            case 6:
                Levels.MainLevels.Level7();
                break;
                
            default:
                Levels.MainLevels.Level1();
                break;
        }

        StartGame();
    }


    public void Restart()
    {
        FinishGame();
        StartGame();

       // LevelBiulder.MainLevelBiulder.BuildLevel();
        MenuManager.MainMenuManager.CloseMenu_VictoryScreen();
        MenuManager.MainMenuManager.CloseMenu_DefeatScreen();
    }


    public void AddScore(int scoreToAdd)
    {
        Score += scoreToAdd;
    }

    public void AddNumberTier()
    {
        CurrentTier++;
        if (CurrentTier > Record)
        {
            Record = CurrentTier;
            // Store highscore/ best in PlayerPrefs
            PlayerPrefs.SetInt("Record", CurrentTier);
        }
    }

    public void ResetRecord()
    {
        Record = 0;
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
