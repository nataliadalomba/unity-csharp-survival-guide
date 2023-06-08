using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizGradeLetters : MonoBehaviour {

    //5 quiz grades
    //calculate the average quiz grade
    //print out the grade average letter

    //print A > 90
    //print B >= 80 and < 90
    //print C > 70 and < 80
    //print F < 70

    [SerializeField] private float q1, q2, q3, q4, q5;
    private char gradeLetter;

    void Start() {
        q1 = Random.Range(50f, 100f);
        q2 = Random.Range(50f, 100f);
        q3 = Random.Range(70f, 100f);
        q4 = Random.Range(80f, 100f);
        q5 = Random.Range(0f, 100f);
        float averageGrade = (q1 + q2 + q3 + q4 + q5) / 5;
        averageGrade = Mathf.Round((averageGrade * 100f) / 100f);

        if (averageGrade >= 90)
            gradeLetter = 'A';
        else if (averageGrade >= 80 && averageGrade < 90)
            gradeLetter = 'B';
        else if (averageGrade >= 70 && averageGrade < 80)
            gradeLetter = 'C';
        else gradeLetter = 'F';

        if (gradeLetter == 'A' || gradeLetter == 'F')
            Debug.Log("The average grade is " + averageGrade + "% which is an " + gradeLetter);
        if (gradeLetter == 'B' || gradeLetter == 'C')
            Debug.Log("The average grade is " + averageGrade + "% which is a " + gradeLetter);
    }
}
