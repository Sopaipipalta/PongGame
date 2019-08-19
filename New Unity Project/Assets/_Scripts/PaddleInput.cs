using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleInput : MonoBehaviour
{
    public float speed;
    public float ClampValue;
    public void MovePaddle(float amountToMove)
    {
        Vector3 ClampedGameobjectPosition=
        gameObject.transform.position + new Vector3(0, 0,(amountToMove*speed));

        ClampedGameobjectPosition.z = Mathf.Clamp(ClampedGameobjectPosition.z, -ClampValue, ClampValue);
        gameObject.transform.position = ClampedGameobjectPosition;
    }



    // Update is called once per frame
    void Update()
    {
        
        MovePaddle(Input.GetAxis("Horizontal"));
       

       gameObject.transform.position +=new Vector3(0,0,Input.GetAxis("Horizontal"));
       
    }

      
    }



