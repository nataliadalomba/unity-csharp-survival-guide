using UnityEngine;

public class SwitchStatements : MonoBehaviour {

    [SerializeField] private int points = 25;
    private bool messagePrinted;

    void Start() {
        Debug.Log("Press:\nQ: 50 points\nW: 100 points\nE: 0 points");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Q)) {
            points = 50;
            messagePrinted = false;
        }
        else if (Input.GetKeyDown(KeyCode.W)) {
            points = 100;
            messagePrinted = false;
        }
        else if (Input.GetKeyDown(KeyCode.E)) {
            points = 0;
            messagePrinted = false;
        }

        switch (points) {
            case 50:
                if (messagePrinted == false) {
                    Debug.Log("Points: " + points);
                    messagePrinted = true;
                }
                break;
            case 100:
                if (messagePrinted == false) {
                    Debug.Log("Points: " + points);
                    messagePrinted = true;
                }
                break;
            default:
                if (messagePrinted == false) {
                    Debug.Log("You need 50 or 100 points to receive a message!");
                    messagePrinted = true;
                }
                break;
        }
    }
}
