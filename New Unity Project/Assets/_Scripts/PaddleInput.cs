using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerController
{
    Player1,
    Player2
}

public class PaddleInput : MonoBehaviour
{

    public PlayerController playerSettings;

    public float speed;
    public float ClampValue;
    public string axisName;


    private void Start()
    {
        if (playerSettings == PlayerController.Player1)
        {
            axisName = "Player1";
        }
        if (playerSettings == PlayerController.Player2)
        {
            axisName = "Player2";
           
        }
    }
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

        MovePaddle(Input.GetAxis(axisName));



    }
    }



