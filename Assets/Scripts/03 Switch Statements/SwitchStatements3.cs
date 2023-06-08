using UnityEngine;

public class SwitchStatements3 : MonoBehaviour {

    //1 Bow
    //2 Dagger
    //3 Wand
    [SerializeField] private int weaponID;

    void Start() {
        Debug.Log("Select a weapon!\n1: Bow\n2: Dagger\n3: Wand");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
            weaponID = 1;
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
            weaponID = 2;
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
            weaponID = 3;

        switch (weaponID) {
            case 1:
                Debug.Log("You've selected the Bow!");
                break;
            case 2:
                Debug.Log("You've selected the Dagger!");
                break;
            case 3:
                Debug.Log("You've selected the Wand!");
                break;
            default:
                Debug.Log("That's not a valid weapon.");
                break;
        }
    }
}
