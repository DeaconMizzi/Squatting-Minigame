using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public GameObject itemToShowInMenu;
    public GameObject itemToShowInGame;
    public GameObject itemToShowInGameOver;

    public Timer Timer;

    public enum GameState
    {
        Menu,
        Playing,
        GameOver
    }

    private GameState currentState;

    // Start is called before the first frame update
    void Start()
    {
        currentState = GameState.Menu;
        UpdateItemsVisibility();   
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && currentState == GameState.Menu)
        {
            currentState = GameState.Playing;
            UpdateItemsVisibility();
            Timer.StartTimer();
        }
        if (PlayerLosesCondition() && currentState != GameState.GameOver)
        {
            currentState = GameState.GameOver;
            UpdateItemsVisibility();
        }

    }

    void UpdateItemsVisibility()
    {
        // Update item visibility based on the current game state
        switch (currentState)
        {
            case GameState.Menu:
                itemToShowInMenu.SetActive(true);
                itemToShowInGame.SetActive(false);
                break;
            case GameState.Playing:
                itemToShowInMenu.SetActive(false);
                itemToShowInGame.SetActive(true);
                break;
            case GameState.GameOver:
                itemToShowInGame.SetActive(false);
                itemToShowInGameOver.SetActive(true);
                break;
        }
    }

    bool PlayerLosesCondition()
    {
        return Timer.timer <= 0f;

    }
}
