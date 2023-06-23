using System.Data;
using UnityEngine;

public class CustomerDatabase : MonoBehaviour {
    //add customers to a database. create a custom class that represents a customer
    //create 3 customers via code using a constructor and then allow user to add customers
    //through the inspector. you'll need two classes. A CustomerDatabase MB which holds
    //info and a Customer custom class

    //traits: First Name, Last Name, Age, Gender, Occupation

    public Customer[] customers = new Customer[3];

    private void Start() {
        //for (int i = 0; i < customers.Length; i++) {
            customers[0] = new Customer("Sandy", "Wiggins", 32, "Female", "Student");
            customers[1] = new Customer("Dave", "Haddon", 43, "Male", "CEO");
            customers[2] = new Customer("Natalia", "DaLomba", 30, "Female", "Boss");
        //}
    }
}
