using System.Collections;
using UnityEngine;

public class CoroutinePractice : MonoBehaviour {

    private int cycles;

    private void Start() {
        StartCoroutine(LevelUpFireworksRoutine());
    }

    IEnumerator LevelUpFireworksRoutine() {
        while(cycles < 5) {
            yield return new WaitForSeconds(2);
            Debug.Log("Play fireworks animation");
            cycles++;
        }
    }
}