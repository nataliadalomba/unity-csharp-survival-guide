using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class ModulusExample : MonoBehaviour {

    void Start() {
        Debug.Log("Even numbers:");
        for (int i = 0; i < 100; i++) {
            if (i % 2 == 0)
                Debug.Log(i);
        }
    }
}
