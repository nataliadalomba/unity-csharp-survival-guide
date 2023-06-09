using UnityEngine;

public class SwitchStatements3 : MonoBehaviour {

    //1 Bow
    //2 Dagger
    //3 Wand
    [SerializeField] private int weaponID;
    private bool messagePrinted;

    void Start() {
        Debug.Log("Select a weapon!\n1: Bow\n2: Dagger\n3: Wand");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1)) {
            weaponID = 1;
            messagePrinted = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2)) {
            weaponID = 2;
            messagePrinted = false;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3)) {
            weaponID = 3;
            messagePrinted = false;
        }

        switch (weaponID) {
            case 1:
                if (messagePrinted == false) {
                    Debug.Log("You've selected the Bow!");
                    messagePrinted = true;
                }
                break;
            case 2:
                if (messagePrinted == false) {
                    Debug.Log("You've selected the Dagger!");
                    messagePrinted = true;
                }
                break;
            case 3:
                if (messagePrinted == false) {
                    Debug.Log("You've selected the Wand!");
                    messagePrinted = true;
                }
                break;
        }
    }
}
