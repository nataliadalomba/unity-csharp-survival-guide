using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LoopChallenges : MonoBehaviour {

    [SerializeField] int speed;
    [SerializeField] private int maxSpeed;

    void Start () {

        HowFastYoureGoing();
        
        //void UltimatePrintOuts() {
        //    //total numbers from 0-30
        //    //print out 0-10 and then prints out only even numbers to 20
        //    //then print out only odd numbers to 30. use modulus

        //    for (int i = 0; i <= 30; i++) {
        //        if (i <= 10)
        //            Debug.Log(i);

        //        else if (i >= 11 && i <= 20 && i % 2 == 0)
        //            Debug.Log(i);

        //        else if (i >= 20 && i <= 30 && i % 2 == 1)
        //            Debug.Log(i);
        //    }
        //}

        void HowFastYoureGoing() {
            maxSpeed = Random.Range(60, 120);
            //increment the value of speed by 5 every second. when speed is greater
            //than maxSpeed, stop incrementing. use a coroutine
            StartCoroutine(IncreaseSpeedRoutine());
        }

        IEnumerator IncreaseSpeedRoutine() {
            while (speed < maxSpeed) {
                Debug.Log("Speed: " + speed);
                speed += 5;

                yield return new WaitForSeconds(1);
                if (speed >= maxSpeed) {
                    speed = maxSpeed;
                    Debug.Log("You've reached the max speed of " + speed);
                }
            }
        }
    }
}
