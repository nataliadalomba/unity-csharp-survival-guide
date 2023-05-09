using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour {

    //create 5 quiz grades
    //create a program that calculates random grades
    //print the average

    public float quiz1, quiz2, quiz3, quiz4, quiz5;

    void Start() {
        quiz1 = Random.Range(0f, 100f);
        quiz2 = Random.Range(0f, 100f);
        quiz3 = Random.Range(0f, 100f);
        quiz4 = Random.Range(0f, 100f);
        quiz5 = Random.Range(0f, 100f);

        float averageGrade = (quiz1 + quiz2 + quiz3 + quiz4 + quiz5) / 5;
        averageGrade = Mathf.Round(averageGrade * 10f) / 10f;
        Debug.Log("The average grade is " + averageGrade + "%");
    }

    void Update() {

    }
}
