using UnityEngine;

public class Arrays : MonoBehaviour {

    #region Array Master
    [SerializeField] private string[] names = { 
        "Natalia DaLomba", "Carlos DaLomba", "Marisela DaLomba", "Scott Lewandowski", "Raquel Almeida" };
    [SerializeField] private int[] ages = new int[5];
    [SerializeField] private string[] carModels;
    #endregion

    private void Update() {
        ArrayMaster();
    }
    
    void ArrayMaster() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            int rand = Random.Range(0, (names.Length));
            Debug.Log("Name: " + names[rand] + ", Age: " + ages[rand] + ", Model: " + carModels[rand]);
        }
    }
}