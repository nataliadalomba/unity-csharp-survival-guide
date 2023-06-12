using UnityEngine;

public class ArraysAndLoops : MonoBehaviour {

    [System.Serializable]
    public class Item {
        public int iD;
        public string name;
        public string description;
    }

    [SerializeField] public Item[] items;

    private void Update() {

    }

    void ForEachLoops1() {

        string[] kittenColors = { "blue", "pink", "brown", "white" };

        if (Input.GetKeyDown(KeyCode.Space)) {
            foreach (string color in kittenColors)
                if (color == "brown")
                    Debug.Log(color);
        }

        object[] mixedArray = { 3.14, "green", 10, true };

        if (Input.GetKeyDown(KeyCode.Space)) {
            foreach (var item in mixedArray)
                Debug.Log(item);
        }
    }
}