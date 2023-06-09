using System.Collections;
using UnityEngine;

public class ForLoops : MonoBehaviour {

    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Color[] colors = {
        Color.red,
        Color.green,
        Color.blue,
    };

    private Material mat;
    private Color previousColor;
    private int currentColorIndex = -1;

    private void OnEnable() {
        mat = enemyPrefab.GetComponent<Renderer>().sharedMaterial;
        previousColor = mat.color;
        StartCoroutine(InstantiateEnemyRoutine());
        CycleUpdateColor();
    }

    private void OnDisable() {
        mat.color = previousColor;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.R))
            CycleUpdateColor();
    }

    IEnumerator InstantiateEnemyRoutine() {
        for (int i = 0; i < 10; i++) {
            GameObject instance = GameObject.Instantiate(enemyPrefab);
            instance.transform.position = new Vector3(Random.Range(-5, 5), 1, Random.Range(-5, 5));
            yield return new WaitForSeconds(1);
        }
    }

    private void CycleUpdateColor() {
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        mat.color = colors[currentColorIndex];
    }
    //currentColorIndex++;
    //if (currentColorIndex >= colors.Length)
    //    currentColorIndex = 0;

    //4 % 10 = 4
    //6 % 10 = 6
    //12 % 10 = 2
    //14 % 10 = 4
    //20 % 10 = 0
    //21 % 10 = 1

    //974 % 1000 = 974
    //999 % 1000 = 999
    //2341 % 1000 = 341
    //6 % 5 = 1
    //76 % 5 = 1
    //19 % 3 = 1

    //The RANGE (output) would be [0, 3)
    //COLOR         EXPRESSION          VALUE
    //red           (0 + 1) % 3         1
    //green         (1 + 1) % 3         2
    //blue          (2 + 1) % 3         0
    //              4       % 3         1
    //              5       % 3         2
    //              6       % 3         0
    //              7       % 3         1
    //              8       % 3         2

}
