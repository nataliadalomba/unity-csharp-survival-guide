using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollector : MonoBehaviour {

    private int _points;

    //hasSaidMessage bool
    private bool _hasSaidMessage;

    void Start() {

    }

    void Update() {
        //if we hit space key
        //add 10 points to points

        if(Input.GetKeyDown(KeyCode.Space)) {
            _points += 10;
            Debug.Log("Points: " + _points);
        }

        //if points is >= to 50 AND hasSaidMessage is false
        //then print you are awesome!
        if (_points >= 50 && _hasSaidMessage == false) {
            Debug.Log("You are awesome!");
            _hasSaidMessage = true;
        }
    }
}
