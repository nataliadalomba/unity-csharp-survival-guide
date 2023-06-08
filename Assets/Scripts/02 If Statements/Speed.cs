using UnityEngine;

public class Speed : MonoBehaviour {

    [SerializeField] private int speed = 10;

    void Update() {
        if (Input.GetKeyDown(KeyCode.S)) {
            speed++;
            if (speed >= 20)
                Debug.Log("Slow down!");
        }
        else if (Input.GetKeyDown(KeyCode.A)) {
            speed--;
            if (speed >= 20)
                Debug.Log("Slow down more!");
            if (speed <= 0) {
                speed = 0;
                Debug.Log("Speed up!");
            }
        }
    }
}
