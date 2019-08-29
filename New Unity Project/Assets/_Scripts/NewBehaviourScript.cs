using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public static NewBehaviourScript instance;
    private List<int> potentialAngles = new List<int>
    {
        60,25,-60,-25
    };



    public GameObject ball;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        InstantiateBall();
   
      
     

    }
    public void InstantiateBall()
    {
        int AngleIndex = Random.Range(0, 4);
        GameObject ballCopy = Instantiate(ball, new Vector3(0, 0, 33), Quaternion.Euler(0, potentialAngles[AngleIndex], 0));




    }




}
