using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text player1score;
    public Text player2score;

     void Start()
    {
        player1score.text = "0";
        player2score.text = "0";
    }

    public void UpdateScore(int p1score,int p2score)
    {
        player1score.text = p1score.ToString();
        player2score.text = p2score.ToString();
    }
 
}
