using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int dropMoment = 0;
    float timeCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter = Time.time;

        if(timeCounter > dropMoment)
        {
            GetComponent<Rigidbody>().useGravity = true;
        }
        
        //Debug.Log(Time.time);
    }
}
