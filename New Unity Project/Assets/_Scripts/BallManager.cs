using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    public static BallManager instance;
    private List<int> potentialAngles = new List<int>
    {
        60,160,270,20
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
        GameObject ballCopy = Instantiate(ball, Vector3.zero, Quaternion.Euler(0, potentialAngles[AngleIndex],0));

        

    }

  
    
          
}

