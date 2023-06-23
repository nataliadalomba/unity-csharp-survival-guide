using System.Collections;
using UnityEngine;

    [RequireComponent(typeof(MeshRenderer))]
public class ColorChange : MonoBehaviour {

    //the cube's color changes every 3 seconds to a random color
    private new MeshRenderer renderer;

    private void Start() {
        renderer = GetComponent<MeshRenderer>();
        StartCoroutine(ColorChangeCoroutine());
    }

    private IEnumerator ColorChangeCoroutine() {
        while (true) {
            Color c = renderer.material.color;
            c = new Color(Random.value, Random.value, Random.value);
            renderer.material.color = c;
            yield return new WaitForSeconds(3);
        }
    }
}