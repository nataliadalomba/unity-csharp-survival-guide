using UnityEngine;

public class PositionMatters: MonoBehaviour {

    //create array of 5 different positions and use a method to generate a random index
    //use another method to set the position to that sub index
    //at start, random position is picked. have script attached to player

    [SerializeField] private Vector3[] positions = new Vector3[5];

    private void Start() {
        SetPosition();
    }

    private int GetRandomIndex(Vector3[] array) {
        int index = Random.Range(0, array.Length);
        return index;
    }

    private void SetPosition() {
        transform.position = positions[GetRandomIndex(positions)];
    }
}