using UnityEngine;

public class LoopDataPresentation : MonoBehaviour {

    [SerializeField] private Item[] items;

    void Start() {
        for (int i = 0; i < items.Length; i++) {
            if (items[i].name == "Sword")
                Debug.Log("You have the item!");
            else Debug.Log("You don't have the item.");
        }
    }
}