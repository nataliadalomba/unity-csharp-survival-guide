using System.Collections;
using UnityEngine;

//1. Auto-adds a MeshRenderer to this GameObject, because we depend on it privately (Otherwise, wow would a designer know?)
//2. Prevents the designer from deleting the MeshRenderer while this script is attached, because we depend on it!
[RequireComponent(typeof(MeshRenderer))]
public class WasThatAMagicTrick : MonoBehaviour {
    //If the "i" key is pressed, turn the cube invisibile for 5 seconds and then it re-appears
    //Make sure to not to respond to i key presses if the cube is already hidden.

    private new MeshRenderer renderer;

    private void Start() {
        renderer = GetComponent<MeshRenderer>();
    }

    private void Update() {
        //This (renderer.enabled) prevents this script from (normally) starting 2+ coroutines simultaneously.
        //This prevents 1st coroutine from ruining 2nd coroutine's ending.
        if (Input.GetKeyDown(KeyCode.I) && renderer.enabled) {
            StartCoroutine(HideCoroutine());
        }
    }

    private IEnumerator HideCoroutine() {
        renderer.enabled = false;

        //This prevents "old" coroutines from messing up new ones! Stop immediately when interrupted.
        //This prevents outdated 1st coroutine from ruining 2nd coroutine's ending.
        float elapsedTime = 0;
        while (elapsedTime < 5) {
            yield return null;

            bool interrupted = renderer.enabled;
            if (interrupted)
                yield break;
            elapsedTime += Time.deltaTime;
        }
        renderer.enabled = true;
    }
}