using UnityEngine;

public class ParametersAndReturnTypes : MonoBehaviour {

    //public int health = 50;

    //alpha is updating in inspector but not in the scene
    //this is an excellent example to write the struct article
    //because it shows you can't edit the struct ... property directly
    [SerializeField] private GameObject sphere;
    private Renderer render;

    private void Start() {
        render = sphere.GetComponent<Renderer>();
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
            DecreaseObjectAlpha(.2f);
    }

    public void DecreaseObjectAlpha(float incrementor) {
        Color c = render.material.color;
        c.a -= incrementor;
        render.material.color = c;
    }

    //public void Damage(int damageAmount) {
    //    health -= damageAmount;

    //    if (health <= 0) {
    //        health = 0;
    //        Destroy(this.gameObject);
    //    }
    //}

    //public int getHealth() {
    //    return health;
    //}

    //-----------
    //void Start() {
    //    Sum(2, 5);
    //}

    //int Sum(int a, int b) {
    //    int sum;
    //    sum = a + b;
    //    return sum;
    //}
}