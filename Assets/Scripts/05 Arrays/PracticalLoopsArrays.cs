using UnityEngine;

public class PracticalLoopsArrays : MonoBehaviour {

    public GameObject[] cubes;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            for (int i = 0; i < cubes.Length; i++)
                cubes[i].GetComponent<MeshRenderer>().material.color = Color.red;
        }
        
        //if (Input.GetKeyDown(KeyCode.Space)) {
        //    foreach (GameObject cube in cubes)
        //        cube.GetComponent<MeshRenderer>().material.color = Color.red;
        //}
    }
}
        



