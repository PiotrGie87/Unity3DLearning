using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer renderer;
    private void OnCollisionEnter(Collision other)
    {
        renderer = GetComponent<MeshRenderer>();

        if(other.gameObject.tag == "Player")
        {
            gameObject.tag = "Hit";
            Debug.Log("You touched something!");

            renderer.material.color = Color.red;
            
            //SwitchColor();


        }
        
        


    }

    private void SwitchColor() //metoda pozwalaj¹ca na zmiane koloru za ka¿dym razem gdy gracz dotknie przeszkody
    {
        if (renderer.material.color == Color.red)
        {
            renderer.material.color = Color.blue;

        }
        else
        {
            renderer.material.color = Color.red;
        }

        
    }

   

}
