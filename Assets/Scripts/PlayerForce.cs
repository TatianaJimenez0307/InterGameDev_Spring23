using System.Collections;
using System.Collections.Generic;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class PlayerForce : MonoBehaviour
{

    public Rigidbody2D armBodyRight;//settingup right arm

    public Rigidbody2D armBodyLeft;//setting up left arm

    public Rigidbody2D legBodyRight; //setting up right leg

    public Rigidbody2D legBodyLeft; //setting up left leg

    Rigidbody2D mainBody; //settingup torso 

    //setting up soundeffects
    public AudioSource mySource;
    public AudioClip jumpClip;

    public float power = 2f; //power is the speed at which you move

    public float jump = 5f; //amount by which you jump


    // Start is called before the first frame update

   



    void Start()
    {
        mainBody = GetComponent<Rigidbody2D>(); //this does the same thing as dragging in an object into a component, we're assigning mainBody to rigidbody
    }

    // Update is called once per frame
    void Update()

    {
        
        //update torso position, then smoothdamp towards the position

        



        mainBody.velocity = Vector3.zero; //this makes the ragdoll not move until you touch a WASD key

        if (Input.GetKey(KeyCode.W)) //if I press W then Right Arm Moves Up
        {

            //  mySource.clip = jumpClip; //sets up audio file which we want to play
            //  mySource.Play(); //plays sound

            armBodyRight.AddForce(transform.up * power, ForceMode2D.Impulse); // right arm movesup
        }

        if (Input.GetKey(KeyCode.Q)) //if I press Q then Left Arm Moves Up
        {
            armBodyLeft.AddForce(transform.up * power, ForceMode2D.Impulse); // left arm moves up
        }

        if (Input.GetKey(KeyCode.O)) //if I press O left leg moves up
        {
            legBodyLeft.AddForce(transform.up * power, ForceMode2D.Impulse); //left leg moves up
        }

        if (Input.GetKey(KeyCode.P)) //if I press P right leg moves up
        {
            legBodyRight.AddForce(transform.up * power, ForceMode2D.Impulse); //right leg moves up 
        }

        if (Input.GetKey(KeyCode.Space)) // If I press space bar I jump
        {
            mainBody.AddForce(Vector3.up * jump, ForceMode2D.Impulse); //giving speed to jump
        }

      //RAGDOLL WASD MOVEMENT 
       /* if (Input.GetKey(KeyCode.W)) //MOVE UP
        {                           //Vector(x, y, z)
            mainBody.velocity = new Vector3(0, power, 0); //giving a speed to the mainBody. NOTE: All Rigidbody components have velocity (because they control the pyshics of an object)
        }

        if (Input.GetKey(KeyCode.A)) // MOVE LEFT
        {                           //Vector(x, y, z)
            mainBody.velocity = new Vector3(-power, 0, 0); //giving a speed to the mainBody. NOTE: All Rigidbody components have velocity (because they control the pyshics of an object)
        }

        if (Input.GetKey(KeyCode.S)) // MOVE DOWN
        {                           //Vector(x, y, z)
            mainBody.velocity = new Vector3(0, -power, 0); //giving a speed to the mainBody. NOTE: All Rigidbody components have velocity (because they control the pyshics of an object)
        }

        if (Input.GetKey(KeyCode.D)) // MOVE RIGHT
        {                           //Vector(x, y, z)
            mainBody.velocity = new Vector3(power, 0, 0); //giving a speed to the mainBody. NOTE: All Rigidbody components have velocity (because they control the pyshics of an object)
        }
       */
    }



  
}
