using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float Ballthrust;
    private Rigidbody RB;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.AddForce(transform.forward * Ballthrust,ForceMode.Acceleration);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
