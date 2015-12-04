using UnityEngine;
using UnityEngine.UI;
public class GameDataManager : Singleton<GameDataManager> 
{
    public string ScorePretext;
    public Text ScoreText;

    public float CurrentScore
    {
        get
        {
            return currentScore;
        }
        set
        {
            if(currentScore != value)
            {
                currentScore = value;
                ScoreText.text = ScorePretext + currentScore;
            }
        }
    }

    public float ShotsLeft;

    public GameState CurrentGameState;

    private float currentScore;

    protected void Start()
    {
        CurrentScore = 0;
        ScoreText.text = ScorePretext + CurrentScore;
    }
}

public enum GameState
{
    MainMenu,
    SelectingLevels,
    Playing,
    Paused
}
