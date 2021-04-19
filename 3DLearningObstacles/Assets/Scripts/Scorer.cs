using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {

            score += 1;
            Debug.Log("Looks like you've hit something new " + " Your score id " + score);
        }
        else
        {
            
            Debug.Log("You have bumped into this already " + " Your score id " + score);
        }
        
    }
}
