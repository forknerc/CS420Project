using UnityEngine;
using System.Collections;

public class GameDataManager : MonoBehaviour 
{
    public static float CurrentScore;

    public static float ShotsLeft;

    public static GameState CurrentGameState;
}

public enum GameState
{
    MainMenu,
    Playing,
    Paused
}
