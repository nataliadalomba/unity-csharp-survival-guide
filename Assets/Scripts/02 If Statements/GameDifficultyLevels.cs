using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDifficultyLevels : MonoBehaviour {

    public int easyDifficulty = 0;
    public int mediumDifficulty = 1;
    public int hardDifficulty = 2;
    public int currentDifficulty;

    void Start() {
        currentDifficulty = mediumDifficulty;
    }

    void Update() {
        if (currentDifficulty == easyDifficulty)
            Debug.Log("You selected easy.");
        else if (currentDifficulty == mediumDifficulty)
            Debug.Log("You selected medium.");
        else if (currentDifficulty == hardDifficulty)
            Debug.Log("You selected hard.");
        else Debug.Log("Invalid difficulty level selected.");
    }
}
