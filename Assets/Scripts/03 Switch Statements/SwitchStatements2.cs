using UnityEngine;

public class SwitchStatements2 : MonoBehaviour {

    //1 red
    //2 green
    //3 blue
    //4 black
    Material mat;

    private void Start() {
        mat = gameObject.GetComponent<MeshRenderer>().material;
        mat.color = Color.magenta;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            mat.color = Color.red;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            mat.color = Color.green;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            mat.color = Color.blue;
        if (Input.GetKeyDown(KeyCode.Alpha4))
            mat.color = Color.black;
    }
}
