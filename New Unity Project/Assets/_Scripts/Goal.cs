using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    

    public string TeamName;
    public ScoreManager sm;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);

        BallManager.instance.InstantiateBall();

        if (TeamName == "TeddyBears")
        { 

            sm.ViciousWormsScored();
    }
        if (TeamName == "ViciousWorms")
        {
            sm.TeddyBearsScored();
        }
            }

}
