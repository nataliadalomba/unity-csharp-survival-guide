using UnityEngine;

public class DoWhilePractice : MonoBehaviour {

    public int babyFoxes = 1;

    void Start() {

        do {
            Debug.Log("I see " + babyFoxes + " baby foxes out in the field!");
            babyFoxes++;
        } while (babyFoxes < 5);
    }
}
