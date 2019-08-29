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
   // public string PunchAxis;
  // [SerializeField] private bool punching;
    private Rigidbody paddleRB;
   // public float punchPower;
  //  public float startX;
  //  public float clampX;
    

    private void Start()
    {
       // startX = transform.position.x;
        paddleRB = GetComponent<Rigidbody>();
        if (playerSettings == PlayerController.Player1)
        {
            axisName = "Player1";
        }
        if (playerSettings == PlayerController.Player2)
        {
            axisName = "Player2";
           
        }
    }



  //  public void Punch()
   // {


     //   paddleRB.AddForce(-transform.right * punchPower);

  //  }
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

      //  if (Input.GetKey(KeyCode.Space))
      //  {
       //     punching = true;
      //  }

     //   transform.position = new Vector3(Mathf.Clamp (transform.position.x,startX,clampX), transform.position.y, transform.position.z);


      //  if (punching== true){
        //    Punch();
      //  }
    }

   
}



