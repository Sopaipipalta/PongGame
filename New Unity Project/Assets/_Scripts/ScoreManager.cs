using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    public int TeddyBears;
    public int ViciousWorms;


    public void TeddyBearsScored()
    {
        TeddyBears += 1;
    }
    public void ViciousWormsScored()
    {
        ViciousWorms++;
    }

    

}
