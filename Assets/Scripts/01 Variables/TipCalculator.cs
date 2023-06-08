using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipCalculator : MonoBehaviour {

    //bill is 40
    //tip is 20% or based on what the user wants
    //calculate the total amount
    public float bill = 40f;
    public float tip = 20f;
    public float totalAmount;

    void Start() {
        float tipAmount = bill * (tip / 100);
        totalAmount = bill + tipAmount;
        Debug.Log("Your bill is: $" + bill + ", your tip amount is: $" + tipAmount + " so you owe: $" + totalAmount);
    }

    void Update() {

    }
}
