using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForce : MonoBehaviour
{

    public Rigidbody2D armBody;//settingup arm
    Rigidbody2D mainBody; //settingup torso

    //setting up soundeffects
    public AudioSource mySource;
    public AudioClip jumpClip; 

    public float power = 2f; //power is the speed at which you move


    // Start is called before the first frame update


    void Start()
    {
        mainBody = GetComponent<Rigidbody2D>(); //this does the same thing as dragging in an object into a component, we're assigning mainBody to rigidbody
    }

    // Update is called once per frame
    void Update()

    {

        mainBody.velocity = Vector3.zero; //this makes the ragdoll not move until you touch a WASD key

        if (Input.GetKeyDown(KeyCode.Space)) //if I press spacebar then arm moves
        {
            
            mySource.clip = jumpClip; //sets up audio file
            mySource.Play(); //plays sound

            armBody.AddForce(transform.up * power, ForceMode2D.Impulse); //moves arm
        }

        //RAGDOLL KEY MOVEMENT 
        if (Input.GetKey(KeyCode.W)) //MOVE UP
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
    }



  
}
