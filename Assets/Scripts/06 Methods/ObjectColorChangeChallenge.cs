using UnityEngine;

public class ObjectColorChangeChallenge : MonoBehaviour {

    //assign cube in inspector and if space key pressed, pass object into ChangeColor
    //ChangeColor takes in GameObject and color to change to

    [SerializeField] private GameObject capsule;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            ChangeColor(capsule, Color.green);
    }

    private void ChangeColor(GameObject obj, Color color) {
        obj.GetComponent<MeshRenderer>().material.color = color;
    }
}