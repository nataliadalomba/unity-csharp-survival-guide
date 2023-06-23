using System.Collections;
using UnityEngine;

public class CoroutinePractice : MonoBehaviour {

    private void Start() {
        StartCoroutine(ExampleCoroutine());
    }

    private IEnumerator ExampleCoroutine() {
        for (int i = 0; i < 5; i++) {
            Debug.Log("routine running");
            yield return new WaitForSeconds(2);
        }
    }
}