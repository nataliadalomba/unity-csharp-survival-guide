using UnityEngine;

public class ChangePosition : MonoBehaviour {

    void Start() {
        transform.position = GetPosition(4, 2, 8);
    }

    public Vector3 GetPosition(float x, float y, float z) {
        return new Vector3(x, y, z);
    }
}