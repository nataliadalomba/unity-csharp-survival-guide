using System.Collections;
using UnityEngine;

public class ForLoops : MonoBehaviour {

    [SerializeField] private GameObject enemyPrefab;
    Material mat;
    //Create 10 new enemy cubes in random spots of the map
    //Change all materials on all enemies to red when the player presses the R key
    void Start() {
        mat = enemyPrefab.GetComponent<MeshRenderer>().sharedMaterial;
        for (int i = 0; i < 10; i++) {
            StartCoroutine(InstantiateEnemyRoutine());
        }
    }
    void Update() {
        if (Input.GetKeyDown(KeyCode.R))
            mat.color = Color.red;
        if (Input.GetKeyDown(KeyCode.G))
            mat.color = Color.green;
    }

    IEnumerator InstantiateEnemyRoutine() {
        while (true) {
            Instantiate(enemyPrefab, new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5)), Quaternion.identity);
            yield return new WaitForSeconds(1);
        }
    }

    //update script from discord
}
