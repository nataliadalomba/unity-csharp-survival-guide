using UnityEngine;

public class PetGame : MonoBehaviour {

    [SerializeField] private Pet pet;

    void Start() {
        pet.Speak();
    }
}
