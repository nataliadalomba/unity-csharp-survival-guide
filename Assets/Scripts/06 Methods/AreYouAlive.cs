using UnityEngine;

public class AreYouAlive : MonoBehaviour {

    //when space key pressed, damage player random amount (never goes below 0).
    //if player is dead (health <= 0), print out "the player has died!"
    //bonus: prevent the damage method from being called if player is dead
    [SerializeField] private int health = 50;

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && IsDead() == false)
            Damage(Random.Range(3, 8));
    }

    private void Damage(int damageAmount) {
        health -= damageAmount;

        if (IsDead()) {
            health = 0;
            Debug.Log("The player has died!");
        }
    }

    private bool IsDead() {
        return health <= 0;
    }
}