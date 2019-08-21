using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    
    public int TeddyBears;
    public int ViciousWorms;
    private UIManager uiMan;


    private void Start()
    {
        uiMan = GetComponent<UIManager>();
    }

    public void TeddyBearsScored()
    {
        TeddyBears += 1;
        uiMan.UpdateScore(TeddyBears, ViciousWorms);
    }
    public void ViciousWormsScored()
    {
        ViciousWorms++;
        uiMan.UpdateScore(TeddyBears, ViciousWorms);
    }

    

}
