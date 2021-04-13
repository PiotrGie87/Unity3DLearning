using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xValue = 0.01f;
    [SerializeField] float yValue = 0.01f;
    [SerializeField] float zvalue = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, yValue, 0);
    }
}
