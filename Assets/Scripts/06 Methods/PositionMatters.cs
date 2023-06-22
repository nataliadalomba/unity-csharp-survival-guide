using UnityEngine;

public class PositionMatters: MonoBehaviour {

    //create array of 5 different positions and use a method to generate a random index
    //use another method to set the position to that sub index
    //at start, random position is picked. have script attached to player

    //make PositionMatters better by generating 5 random positions in code
    //then write article on it

    [SerializeField] private Vector3[] positions = new Vector3[5];

    private void Start() {
        for (int i = 0; i < positions.Length; i++)
            positions[i] = new Vector3(Random.Range(-14, 15), 0, 
                Random.Range(-14, 15));
        SetPosition();
    }

    private int GetRandomIndex() {
        int index = Random.Range(0, positions.Length);
        return index;
    }

    private void SetPosition() {
        transform.position = positions[GetRandomIndex()];
    }
}