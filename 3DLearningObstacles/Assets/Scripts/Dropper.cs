using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] int dropMoment = 0;
    float timeCounter = 0;
    MeshRenderer renderer; //klasyczny przyk³ad Cachingu
    Rigidbody body;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
        body = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter = Time.time;

        if(timeCounter > dropMoment)
        {
            renderer.enabled = true;
            body.useGravity = true;
        }
        
        //Debug.Log(Time.time);
    }
}
