using UnityEngine;

public class DoLoops : MonoBehaviour {

    public int babyFoxes = 1;

    void Start() {
        do {
            Debug.Log("I see " + babyFoxes + " out in the field!");
            babyFoxes++;
        } while (babyFoxes < 5);
    }
}