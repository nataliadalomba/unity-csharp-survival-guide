using UnityEngine;

public class RedToGreen : MonoBehaviour {

    [SerializeField] private int score;

    private Material mat;

    void Start() {
        mat = gameObject.GetComponent<MeshRenderer>().material;
        mat.color = Color.red;
        if (mat == null)
            Debug.LogError("The mesh renderer is missing on the Cube object.");
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            score++;
            if (score >= 50)
                mat.color = Color.green;
        }
    }
}
