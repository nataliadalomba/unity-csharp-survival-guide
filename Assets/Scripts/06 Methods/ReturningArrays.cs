using UnityEngine;

public class ReturningArrays : MonoBehaviour {

    [SerializeField] private GameObject[] players;

    private GameObject[] GetAndColorAllPlayers() {
        GameObject[] allPlayers = GameObject.FindGameObjectsWithTag("Player");

        foreach (GameObject p in allPlayers)
            p.GetComponent<MeshRenderer>().material.color = new Color(Random.value,
                Random.value, Random.value);
        return allPlayers;
    }
}